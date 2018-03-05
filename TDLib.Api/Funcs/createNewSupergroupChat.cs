using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class Methods : object
    {

        public partial class createNewSupergroupChat : Method<Chat>
        {

                [JsonProperty("@type")]
                public override string Type { get; set; } = "createNewSupergroupChat";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("title")]
                public string title_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("is_channel")]
                public bool? is_channel_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("description")]
                public string description_;

        }

    }

}
