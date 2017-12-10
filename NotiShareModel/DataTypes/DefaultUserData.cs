using Newtonsoft.Json;

namespace NotiShareModel.DataTypes
{
    public abstract class DefaultUserData
    {
        [JsonProperty(PropertyName = "userName")]
        public string UserName { get; set; }

        [JsonProperty(PropertyName = "passwordHash")]
        public string PasswordHash { get; set; }
    }
}
