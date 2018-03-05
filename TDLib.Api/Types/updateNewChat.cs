using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class Update : Structure
    {

        public partial class updateNewChat : Update
        {

                [JsonProperty("@type")]
                public override string Type { get; set; } = "updateNewChat";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("chat")]
                public Chat.chat chat_;

        }

    }

}
