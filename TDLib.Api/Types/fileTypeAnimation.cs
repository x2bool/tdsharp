using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class FileType : Structure
    {

        public partial class fileTypeAnimation : FileType
        {

                [JsonProperty("@type")]
                public override string Type { get; set; } = "fileTypeAnimation";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

        }

    }

}
