using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class User : Structure
    {

        public partial class user : User
        {

                [JsonProperty("@type")]
                public override string Type { get; set; } = "user";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("id")]
                public int? id_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("first_name")]
                public string first_name_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("last_name")]
                public string last_name_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("username")]
                public string username_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("phone_number")]
                public string phone_number_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("status")]
                public UserStatus status_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("profile_photo")]
                public ProfilePhoto.profilePhoto profile_photo_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("outgoing_link")]
                public LinkState outgoing_link_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("incoming_link")]
                public LinkState incoming_link_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("is_verified")]
                public bool? is_verified_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("restriction_reason")]
                public string restriction_reason_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("have_access")]
                public bool? have_access_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("type")]
                public UserType type_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("language_code")]
                public string language_code_;

        }

    }

}
