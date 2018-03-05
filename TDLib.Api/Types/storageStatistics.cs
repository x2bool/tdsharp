using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class StorageStatistics : Structure
    {

        public partial class storageStatistics : StorageStatistics
        {

                [JsonProperty("@type")]
                public override string Type { get; set; } = "storageStatistics";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("size")]
                public long? size_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("count")]
                public int? count_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("by_chat")]
                public StorageStatisticsByChat.storageStatisticsByChat[] by_chat_;

        }

    }

}
