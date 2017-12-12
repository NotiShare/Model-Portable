using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace NotiShareModel.DataTypes
{
    public class ClipboardData
    {
        [JsonProperty(PropertyName = "clipboardText")]
        public string ClipboardStringData { get; set; }

        [JsonProperty(PropertyName = "clipboard_data_type_id")]
        public int DataType { get; set; }


        [JsonProperty(PropertyName = "clipboardDateCreation")]
        public DateTime DatetimeCreation { get; set; }
    }
}
