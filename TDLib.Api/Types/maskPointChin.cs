using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class MaskPoint : Structure
    {

        public partial class maskPointChin : MaskPoint
        {

                [JsonProperty("@type")]
                public override string Type { get; set; } = "maskPointChin";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

        }

    }

}
