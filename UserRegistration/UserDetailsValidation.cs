using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    public class UserDetailsValidation
    {
        public static string REGEX_FIRST_NAME = "^[A-Z][a-zA-Z]{2,}$";
        public static string REGEX_LAST_NAME = "^[A-Z][a-zA-Z]{2,}$";
        public static string REGEX_EMAIL = "^[a-zA-Z0-9]+([-.+_#$][a-zA-Z0-9]+)*[@][a-zA-Z0-9]+[.][a-zA-Z]{2,3}([.][a-zA-Z]{2})?$";
        public static string REGEX_NUMBER = "^[1-9][0-9]\\s[1-9]{1}[0-9]{9}$";
        public static string REGEX_PASSWORD = "((?=.*[A-Z])(?=.*[0-9])(?=^[a-zA-Z0-9]*[@$#^!-+][a-zA-Z0-9]*$)).{8,}";
        public bool ValidateFirstName(string fName)
        {
            return Regex.IsMatch(fName, REGEX_FIRST_NAME);
        }
        public bool ValidateLastName(string lName)
        {
            return Regex.IsMatch(lName, REGEX_LAST_NAME);
        }
        public bool ValidateEmail(string email)
        {
            return Regex.IsMatch(email, REGEX_EMAIL);
        }
        public bool ValidateNumber(string number)
        {
            return Regex.IsMatch(number, REGEX_NUMBER);
        }
        public bool ValidatePassword(string password)
        {
            return Regex.IsMatch(password, REGEX_PASSWORD);
        }
    }
}
