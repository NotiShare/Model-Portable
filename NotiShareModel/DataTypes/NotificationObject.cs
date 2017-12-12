using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace NotiShareModel.DataTypes
{
    public class NotificationObject
    {

        [JsonProperty(PropertyName = "notification_title")]
        public string Title { get; set; }

        [JsonProperty(PropertyName = "notification_text")]
        public string NotificationText { get; set; }


        [JsonProperty(PropertyName = "image")]
        public string ImageBase64 { get; set; }

        [JsonProperty(PropertyName = "datetime_sending")]
        public DateTime DatetimeCreation { get; set; }
    }
}
