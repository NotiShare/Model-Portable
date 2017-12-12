using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace NotiShareModel.DataTypes
{
    public class RegisterDeviceObject
    {
        
        [JsonProperty(PropertyName = "user_id")]
        public int UserId { get; set; }

        [JsonProperty(PropertyName = "deviceId")]
        public string DeviceId { get; set; }

        [JsonProperty(PropertyName = "device_type_id")]
        public int DeviceType { get; set; }

        [JsonProperty(PropertyName = "device_name")]
        public string DeviceName { get; set; }
    }
}
