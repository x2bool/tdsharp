using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class ChatAction : Structure
    {

        public partial class chatActionChoosingContact : ChatAction
        {

                [JsonProperty("@type")]
                public override string Type { get; set; } = "chatActionChoosingContact";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

        }

    }

}
