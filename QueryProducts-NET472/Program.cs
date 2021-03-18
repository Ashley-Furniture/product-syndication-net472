using Newtonsoft.Json;
using QueryProducts_NET472.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace QueryProducts_NET472
{
    class Program
    {
        //Create an HTTP Client and enable Compression
        static readonly HttpClient Client = new HttpClient(new HttpClientHandler() { AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate });

        //These are your specific configuration values that you need to populate
        const string ClientId = "API Key";
        const string Customer = "Ashley Wholesale Customer Account Number";
        const string ShipTo = "Ashley Ship-To related to the Customer Number";
        const string AshleyDirectUsername = "Ashley Direct Username";
        const string AshleyDirectPassword = "Ashley Direct Password";
        const string PageLimit = "500";

        //These are the initial connection properties for the Product Syndication API
        const string BaseUrl = "https://apigw3.ashleyfurniture.com/productinformation/";
        static string Path = $"products?customer={Customer}&shipto={ShipTo}&limit={PageLimit}";

        static async Task Main()
        {
            Client.BaseAddress = new Uri(BaseUrl);
            Client.DefaultRequestHeaders.TryAddWithoutValidation("client_id", ClientId);

            //Converting the username and password to a Base64 encoded byte array
            var byteArray = Encoding.ASCII.GetBytes($"{AshleyDirectUsername}:{AshleyDirectPassword}");
            Client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", Convert.ToBase64String(byteArray));

            Console.Out.WriteLine($"Starting requests for Ashley Customer {Customer}-{ShipTo}");

            //For the sake of a simple implementation, we will kick off the asynchronous GetAllProducts method and await the result.
            var items = await GetAllProducts();

            foreach(var i in items)
            {
                //You would now do something with this data -- write it to a file, write it to a database, send it to another API, etc.
            }

            Console.Out.WriteLine("Please press any key to close");
            Console.ReadKey();
        }

        private static async Task<List<Entity>> GetAllProducts()
        {
            Console.Out.WriteLine("Starting Download");
            var items = new List<Entity>();

            do
            {
                await Client.GetAsync(Path)
                    .ContinueWith(async (itemSearchTask) =>
                    {
                        var response = await itemSearchTask;
                        if (response.IsSuccessStatusCode) //If we get back an HTTP 200 response, start deserializing it with Newtonsoft JSON
                        {
                            string jsonString = await response.Content.ReadAsStringAsync();
                            var result = JsonConvert.DeserializeObject<Products>(jsonString);

                            if (result != null)
                            {
                                // Add this page of items to the full list that we will return after the loop
                                if (result.Entities.Any())
                                    items.AddRange(result.Entities.ToList());

                                Console.Out.WriteLine($"{items.Count} / {result.Metadata.TotalRecords} SKUs Downloaded");

                                // Get the URL for the next page, if it exists, otherwise clear out our Path variable which will end our loop
                                Path = result.Links.Where(x => x.Rel == "Next").Select(x => x.Href).FirstOrDefault() ?? string.Empty;
                            }
                        }
                        else
                        {
                            // End loop since we had some kind of error
                            Console.Out.WriteLine($"Error: {response.ReasonPhrase}");
                            Path = string.Empty;
                            
                        }
                    });

            } while (!string.IsNullOrEmpty(Path));
            return items;
        }
    }
}
