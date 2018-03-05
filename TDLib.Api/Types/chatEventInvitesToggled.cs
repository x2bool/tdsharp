using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class ChatEventAction : Structure
    {

        public partial class chatEventInvitesToggled : ChatEventAction
        {

                [JsonProperty("@type")]
                public override string Type { get; set; } = "chatEventInvitesToggled";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("anyone_can_invite")]
                public bool? anyone_can_invite_;

        }

    }

}
