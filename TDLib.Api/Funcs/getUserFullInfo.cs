using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class Methods : object
    {

        public partial class getUserFullInfo : Method<UserFullInfo>
        {

                [JsonProperty("@type")]
                public override string Type { get; set; } = "getUserFullInfo";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("user_id")]
                public int? user_id_;

        }

    }

}
