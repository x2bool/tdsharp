using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class TestVectorString : Structure
    {

        public partial class testVectorString : TestVectorString
        {

                [JsonProperty("@type")]
                public override string Type { get; set; } = "testVectorString";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("value")]
                public string[] value_;

        }

    }

}
