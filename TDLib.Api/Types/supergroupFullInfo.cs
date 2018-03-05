using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class SupergroupFullInfo : Structure
    {

        public partial class supergroupFullInfo : SupergroupFullInfo
        {

                [JsonProperty("@type")]
                public override string Type { get; set; } = "supergroupFullInfo";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("description")]
                public string description_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("member_count")]
                public int? member_count_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("administrator_count")]
                public int? administrator_count_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("restricted_count")]
                public int? restricted_count_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("banned_count")]
                public int? banned_count_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("can_get_members")]
                public bool? can_get_members_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("can_set_username")]
                public bool? can_set_username_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("can_set_sticker_set")]
                public bool? can_set_sticker_set_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("is_all_history_available")]
                public bool? is_all_history_available_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("sticker_set_id")]
                public string sticker_set_id_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("invite_link")]
                public string invite_link_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("pinned_message_id")]
                public long? pinned_message_id_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("upgraded_from_basic_group_id")]
                public int? upgraded_from_basic_group_id_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("upgraded_from_max_message_id")]
                public long? upgraded_from_max_message_id_;

        }

    }

}
