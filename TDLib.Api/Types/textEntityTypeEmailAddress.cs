using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class TextEntityType : Structure
    {

        public partial class textEntityTypeEmailAddress : TextEntityType
        {

                [JsonProperty("@type")]
                public override string Type { get; set; } = "textEntityTypeEmailAddress";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

        }

    }

}
