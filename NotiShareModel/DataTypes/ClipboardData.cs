using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace NotiShareModel.DataTypes
{
    public class ClipboardData
    {
        [JsonProperty(PropertyName = "clipboardData")]
        public string ClipboardStringData { get; set; }

        [JsonProperty(PropertyName = "dataType")]
        public int DataType { get; set; }


        [JsonProperty(PropertyName = "datetimeCreation")]
        public DateTime DatetimeCreation { get; set; }
    }
}
