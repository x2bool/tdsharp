using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class InputMessageContent : Structure
    {

        public partial class inputMessageVoiceNote : InputMessageContent
        {

                [JsonProperty("@type")]
                public override string Type { get; set; } = "inputMessageVoiceNote";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("voice_note")]
                public InputFile voice_note_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("duration")]
                public int? duration_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("waveform")]
                public byte[] waveform_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("caption")]
                public FormattedText.formattedText caption_;

        }

    }

}
