﻿// <auto-generated />


namespace DBD_API.Modules.DbD.JsonResponse
{
    using System;
    using System.Globalization;
    using System.Diagnostics;
    using DBD_API.Modules.DbD.JsonResponse.Converters;
    using System.Text.Json.Serialization;
    using System.Text.Json;


    public partial class StoreResponse
    {
        [JsonPropertyName("outfits")]
        public Outfit[] Outfits { get; set; }
    }

    public partial class Outfit
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("defaultCost")]
        public DefaultCost[] DefaultCost { get; set; }

        [JsonPropertyName("character")]
        public string Character { get; set; }

        [JsonPropertyName("storeItems")]
        public string[] StoreItems { get; set; }

        [JsonPropertyName("newStartDate")]
        public DateTime NewStartDate { get; set; }

        [JsonPropertyName("newEndDate")]
        public DateTime NewEndDate { get; set; }
    }

    public partial class DefaultCost
    {
        [JsonPropertyName("currencyId")]
        public CurrencyId CurrencyId { get; set; }

        [JsonPropertyName("price")]
        public long Price { get; set; }

        [JsonPropertyName("discountPercentage")]
        public double DiscountPercentage { get; set; }
    }

    public enum CurrencyId { Cells, HalloweenEventCurrency, LunarNewYearCoins, Shards };

    public partial class StoreConvert
    {
        public static StoreResponse FromJson(string json) => JsonSerializer.Deserialize<StoreResponse>(json, StoreConverter.Settings);
    }

    internal static class StoreConverter
    {
        public static readonly JsonSerializerOptions Settings = new JsonSerializerOptions
        {
            WriteIndented = true,
            Converters =
            {
                DateTimeConverter.Singleton,
                CurrencyIdConverter.Singleton
            },
        };
    }
}
