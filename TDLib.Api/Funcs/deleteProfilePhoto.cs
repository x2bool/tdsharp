using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class Methods : object
    {

        public partial class deleteProfilePhoto : Method<Ok>
        {

                [JsonProperty("@type")]
                public override string Type { get; set; } = "deleteProfilePhoto";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("profile_photo_id")]
                public string profile_photo_id_;

        }

    }

}
