﻿using Newtonsoft.Json;

namespace NotiShareModel.DataTypes
{
    public class DeviceRegisterResult
    {
        [JsonProperty(PropertyName = "idUserDevice")]
        public int UserDeviceDbId { get; set; }


        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }
    }
}
