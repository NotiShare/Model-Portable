using Newtonsoft.Json;

namespace NotiShareModel.DataTypes
{
    public abstract class DefaultUserData
    {
        [JsonProperty(PropertyName = "user_name")]
        public string UserName { get; set; }

        [JsonProperty(PropertyName = "password_hash")]
        public string PasswordHash { get; set; }
    }
}
