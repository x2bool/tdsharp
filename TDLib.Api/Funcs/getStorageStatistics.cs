using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class Methods : object
    {

        public partial class getStorageStatistics : Method<StorageStatistics>
        {

                [JsonProperty("@type")]
                public override string Type { get; set; } = "getStorageStatistics";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("chat_limit")]
                public int? chat_limit_;

        }

    }

}
