using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class Document : Structure
    {

        public partial class document : Document
        {

                [JsonProperty("@type")]
                public override string Type { get; set; } = "document";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("file_name")]
                public string file_name_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("mime_type")]
                public string mime_type_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("thumbnail")]
                public PhotoSize.photoSize thumbnail_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("document")]
                public File.file document_;

        }

    }

}
