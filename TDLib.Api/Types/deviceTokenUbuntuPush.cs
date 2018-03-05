using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class DeviceToken : Structure
    {

        public partial class deviceTokenUbuntuPush : DeviceToken
        {

                [JsonProperty("@type")]
                public override string Type { get; set; } = "deviceTokenUbuntuPush";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("token")]
                public string token_;

        }

    }

}
