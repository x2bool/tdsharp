using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class SecretChatState : Structure
    {

        public partial class secretChatStateClosed : SecretChatState
        {

                [JsonProperty("@type")]
                public override string Type { get; set; } = "secretChatStateClosed";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

        }

    }

}
