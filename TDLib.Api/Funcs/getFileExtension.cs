using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class Methods : object
    {

        public partial class getFileExtension : Method<Text>
        {

                [JsonProperty("@type")]
                public override string Type { get; set; } = "getFileExtension";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("mime_type")]
                public string mime_type_;

        }

    }

}
