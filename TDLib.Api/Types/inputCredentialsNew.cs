using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class InputCredentials : Structure
    {

        public partial class inputCredentialsNew : InputCredentials
        {

                [JsonProperty("@type")]
                public override string Type { get; set; } = "inputCredentialsNew";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("data")]
                public string data_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("allow_save")]
                public bool? allow_save_;

        }

    }

}
