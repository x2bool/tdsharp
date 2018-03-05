using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class Methods : object
    {

        public partial class toggleSupergroupIsAllHistoryAvailable : Method<Ok>
        {

                [JsonProperty("@type")]
                public override string Type { get; set; } = "toggleSupergroupIsAllHistoryAvailable";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("supergroup_id")]
                public int? supergroup_id_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("is_all_history_available")]
                public bool? is_all_history_available_;

        }

    }

}
