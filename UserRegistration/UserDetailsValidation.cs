using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    class UserDetailsValidation
    {
        public static string REGEX_FIRST_NAME = "^[A-Z][a-zA-Z]{2,}$";
        public static string REGEX_LAST_NAME = "^[A-Z][a-zA-Z]{2,}$";
        public static string REGEX_EMAIL = "^[a-zA-Z0-9]+([.+-_@#$][a-zA-Z0-9]+)*[@][a-zA-Z0-9]+[.][a-zA-Z]{2,3}([.][a-zA-Z]{2})?$";
        public static string REGEX_NUMBER = "^[1-9][0-9]\\s[1-9]{1}[0-9]{9}$";
        public static string REGEX_PASSWORD = "(?=.*[A-Z])(?=.*[0-9])(?=.?[@#$%^&-+=().]{1}).{8,}";
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
        public bool validateNumber(string number)
        {
            return Regex.IsMatch(number, REGEX_NUMBER);
        }
        public bool validatePassword(string password)
        {
            return Regex.IsMatch(password, REGEX_PASSWORD);
        }
    }
}
