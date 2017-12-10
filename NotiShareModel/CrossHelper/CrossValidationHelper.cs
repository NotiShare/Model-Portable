using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace NotiShareModel.CrossHelper
{
    public static class CrossValidationHelper
    {
        public static bool CheckEmail(string inputEmail)
        {
            var regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            var match = regex.Match(inputEmail);
            return match.Success;
        }


        public static bool ValidatePasswordLenght(string password)
        {
            return password.Length > 5 && password.Length < 17;
        }


        public static bool ValidatePasswords(string originalPassword, string repeatedPassword)
        {
            return originalPassword.Equals(repeatedPassword);
        }
    }
}
