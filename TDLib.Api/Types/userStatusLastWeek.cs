using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class UserStatus : Structure
    {

        public partial class userStatusLastWeek : UserStatus
        {

                [JsonProperty("@type")]
                public override string Type { get; set; } = "userStatusLastWeek";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

        }

    }

}
