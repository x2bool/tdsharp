using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class Methods : object
    {

        public partial class resetAllNotificationSettings : Method<Ok>
        {

                [JsonProperty("@type")]
                public override string Type { get; set; } = "resetAllNotificationSettings";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

        }

    }

}
