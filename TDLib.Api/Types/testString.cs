using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class TestString : Structure
    {

        public partial class testString : TestString
        {

                [JsonProperty("@type")]
                public override string Type { get; set; } = "testString";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("value")]
                public string value_;

        }

    }

}
