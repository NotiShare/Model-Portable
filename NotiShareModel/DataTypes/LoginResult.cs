using Newtonsoft.Json;

namespace NotiShareModel.DataTypes
{
    public class LoginResult
    {

        [JsonProperty(PropertyName="userId")]
        public int UserId { get; set; }

        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }
    }
}
