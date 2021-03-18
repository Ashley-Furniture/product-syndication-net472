using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace QueryProducts_NET472.Models
{
    public class Products
    {
        [JsonProperty("links")]
        public List<Link> Links { get; set; }

        [JsonProperty("metadata")]
        public Metadata Metadata { get; set; }

        [JsonProperty("entities")]
        public List<Entity> Entities { get; set; }
    }

    public class Entity
    {
        [JsonProperty("additionalDimensions")]
        public List<AdditionalDimension> AdditionalDimensions { get; set; }

        [JsonProperty("brandName")]
        public string BrandName { get; set; }

        [JsonProperty("cartonDepthInches")]
        public string CartonDepthInches { get; set; }

        [JsonProperty("cartonDepthMm")]
        public string CartonDepthMm { get; set; }

        [JsonProperty("cartonHeightInches")]
        public string CartonHeightInches { get; set; }

        [JsonProperty("cartonHeightMm")]
        public string CartonHeightMm { get; set; }

        [JsonProperty("cartonVolumeCuFeet")]
        public string CartonVolumeCuFeet { get; set; }

        [JsonProperty("cartonVolumeCuMeters")]
        public string CartonVolumeCuMeters { get; set; }

        [JsonProperty("cartonWidthInches")]
        public string CartonWidthInches { get; set; }

        [JsonProperty("cartonWidthMm")]
        public string CartonWidthMm { get; set; }

        [JsonProperty("chairQtyPerCarton")]
        public string ChairQtyPerCarton { get; set; }

        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("covers")]
        public List<Cover> Covers { get; set; }

        [JsonProperty("detailedDescription")]
        public string DetailedDescription { get; set; }

        [JsonProperty("fobBasePrice")]
        public string FobBasePrice { get; set; }

        [JsonProperty("friendlyDescription")]
        public string FriendlyDescription { get; set; }

        [JsonProperty("generalColor")]
        public List<string> GeneralColor { get; set; }

        [JsonProperty("harmonizationCode")]
        public string HarmonizationCode { get; set; }

        [JsonProperty("imageSet")]
        public List<ImageSet> ImageSet { get; set; }

        [JsonProperty("intendedRooms")]
        public List<string> IntendedRooms { get; set; }

        [JsonProperty("isExpressShipEligible")]
        public bool IsExpressShipEligible { get; set; }

        [JsonProperty("isSupplierDirectShipOnly")]
        public bool IsSupplierDirectShipOnly { get; set; }

        [JsonProperty("itemClass")]
        public string ItemClass { get; set; }

        [JsonProperty("itemCode")]
        public string ItemCode { get; set; }

        [JsonProperty("itemName")]
        public string ItemName { get; set; }

        [JsonProperty("itemsPerCase")]
        public string ItemsPerCase { get; set; }

        [JsonProperty("itemRoomImage")]
        public Uri ItemRoomImage { get; set; }

        [JsonProperty("itemType")]
        public string ItemType { get; set; }

        [JsonProperty("itemWeightKg")]
        public string ItemWeightKg { get; set; }

        [JsonProperty("itemWeightLbs")]
        public string ItemWeightLbs { get; set; }

        [JsonProperty("isCommodity")]
        public bool IsCommodity { get; set; }

        [JsonProperty("kitIncludes")]
        public List<object> KitIncludes { get; set; }

        [JsonProperty("knockout")]
        public Uri Knockout { get; set; }

        [JsonProperty("largeImageUrl")]
        public Uri LargeImageUrl { get; set; }

        [JsonProperty("lifestyle")]
        public List<string> Lifestyle { get; set; }

        [JsonProperty("links")]
        public List<Link> Links { get; set; }

        [JsonProperty("manufacturerWarrantyDays")]
        public string ManufacturerWarrantyDays { get; set; }

        [JsonProperty("material")]
        public List<string> Material { get; set; }

        [JsonProperty("mediumImageUrl")]
        public Uri MediumImageUrl { get; set; }

        [JsonProperty("numberofPieces", NullValueHandling = NullValueHandling.Ignore)]
        public string NumberofPieces { get; set; }

        [JsonProperty("pattern")]
        public List<string> Pattern { get; set; }

        [JsonProperty("pillowSize", NullValueHandling = NullValueHandling.Ignore)]
        public string PillowSize { get; set; }

        [JsonProperty("productDetails")]
        public List<string> ProductDetails { get; set; }

        [JsonProperty("seatCount")]
        public string SeatCount { get; set; }

        [JsonProperty("seriesId")]
        public string SeriesId { get; set; }

        [JsonProperty("shippingWeightKg")]
        public string ShippingWeightKg { get; set; }

        [JsonProperty("shippingWeightLbs")]
        public string ShippingWeightLbs { get; set; }

        [JsonProperty("sku")]
        public string Sku { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("statusDate")]
        public string StatusDate { get; set; }

        [JsonProperty("marketIntroDates")]
        public List<string> MarketIntroDates { get; set; }

        [JsonProperty("unitDepthInches")]
        public string UnitDepthInches { get; set; }

        [JsonProperty("unitDepthMm")]
        public string UnitDepthMm { get; set; }

        [JsonProperty("unitFriendlyDimensionsInches")]
        public string UnitFriendlyDimensionsInches { get; set; }

        [JsonProperty("unitFriendlyDimensionsMm")]
        public string UnitFriendlyDimensionsMm { get; set; }

        [JsonProperty("unitHeightInches")]
        public string UnitHeightInches { get; set; }

        [JsonProperty("unitHeightMm")]
        public string UnitHeightMm { get; set; }

        [JsonProperty("unitWidthInches")]
        public string UnitWidthInches { get; set; }

        [JsonProperty("unitWidthMm")]
        public string UnitWidthMm { get; set; }

        [JsonProperty("upc")]
        public string Upc { get; set; }

        [JsonProperty("vendorName")]
        public string VendorName { get; set; }

        [JsonProperty("isExclusive")]
        public bool IsExclusive { get; set; }

        [JsonProperty("retailType")]
        public string RetailType { get; set; }

        [JsonProperty("consumerDescription")]
        public string ConsumerDescription { get; set; }

        [JsonProperty("consumerAssembly", NullValueHandling = NullValueHandling.Ignore)]
        public string ConsumerAssembly { get; set; }

        [JsonProperty("assemblyInstructionsUrl", NullValueHandling = NullValueHandling.Ignore)]
        public Uri AssemblyInstructionsUrl { get; set; }

        [JsonProperty("colorSwatch", NullValueHandling = NullValueHandling.Ignore)]
        public Uri ColorSwatch { get; set; }

        [JsonProperty("fabric", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Fabric { get; set; }

        [JsonProperty("shade", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Shade { get; set; }

        [JsonProperty("upholsteryFeature", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> UpholsteryFeature { get; set; }
    }

    public class AdditionalDimension
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("alternateDimensionMm")]
        public string AlternateDimensionMm { get; set; }

        [JsonProperty("alternateDimensionInches")]
        public string AlternateDimensionInches { get; set; }

        [JsonProperty("widthMm")]
        public string WidthMm { get; set; }

        [JsonProperty("widthInches")]
        public string WidthInches { get; set; }

        [JsonProperty("heightMm")]
        public string HeightMm { get; set; }

        [JsonProperty("heightInches")]
        public string HeightInches { get; set; }

        [JsonProperty("depthMm")]
        public string DepthMm { get; set; }

        [JsonProperty("depthInches")]
        public string DepthInches { get; set; }
    }

    public class Cover
    {
        [JsonProperty("itemNumber")]
        public string ItemNumber { get; set; }

        [JsonProperty("cleaningCode")]
        public string CleaningCode { get; set; }

        [JsonProperty("cleaningCodeDescription")]
        public string CleaningCodeDescription { get; set; }

        [JsonProperty("contents")]
        public List<Content> Contents { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("percentageMakeup")]
        public string PercentageMakeup { get; set; }
    }

    public class Content
    {
        [JsonProperty("contentTypeDescription")]
        public string ContentTypeDescription { get; set; }

        [JsonProperty("percentage")]
        public string Percentage { get; set; }
    }

    public class ImageSet
    {
        [JsonProperty("href")]
        public Uri Href { get; set; }
    }

    public class Link
    {
        [JsonProperty("rel")]
        public string Rel { get; set; }

        [JsonProperty("href")]
        public string Href { get; set; }
    }

    public class Metadata
    {
        [JsonProperty("totalRecords")]
        public string TotalRecords { get; set; }

        [JsonProperty("currentPageRecords")]
        public string CurrentPageRecords { get; set; }
    }
}
