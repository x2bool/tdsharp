using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class Update : Structure
    {

        public partial class updateUserFullInfo : Update
        {

                [JsonProperty("@type")]
                public override string Type { get; set; } = "updateUserFullInfo";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("user_id")]
                public int? user_id_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("user_full_info")]
                public UserFullInfo.userFullInfo user_full_info_;

        }

    }

}
