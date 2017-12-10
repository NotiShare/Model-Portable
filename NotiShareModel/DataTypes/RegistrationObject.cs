using Newtonsoft.Json;

namespace NotiShareModel.DataTypes
{
    public class RegistrationObject : DefaultUserData
    {
         
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }  

        [JsonProperty(PropertyName = "surname")]
        public string Surname { get; set; }


        [JsonProperty(PropertyName = "email")]
        public string Email { get; set; }

        
    }
}
