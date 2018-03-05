using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class TextEntities : Structure
    {

        public partial class textEntities : TextEntities
        {

                [JsonProperty("@type")]
                public override string Type { get; set; } = "textEntities";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("entities")]
                public TextEntity.textEntity[] entities_;

        }

    }

}
