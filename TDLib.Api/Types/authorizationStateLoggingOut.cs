using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class AuthorizationState : Structure
    {

        public partial class authorizationStateLoggingOut : AuthorizationState
        {

                [JsonProperty("@type")]
                public override string Type { get; set; } = "authorizationStateLoggingOut";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

        }

    }

}
