using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    class UserDetailsValidation
    {
        public static string REGEX_FIRST_NAME = "^[A-Z]{1}[a-z]{2,10}$";
        public static string REGEX_LAST_NAME = "^[A-Z]{1}[a-z]{2,10}$";
        public static string REGEX_EMAIL = "^[a-z]{2,10}[_+-.]?[a-z0-9]{0,10}?@[a-z]{2,10}.[a-z]{2,10}[.]?[a-z]{2}?";
        public bool validateFirstName(string fName)
        {
            return Regex.IsMatch(fName, REGEX_FIRST_NAME);
        }
        public bool validateLastName(string lName)
        {
            return Regex.IsMatch(lName, REGEX_LAST_NAME);
        }
        public bool validateEmail(string email)
        {
            return Regex.IsMatch(email, REGEX_EMAIL);
        }
    }
}
