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
            try
            {
                if (fName.Equals(string.Empty))
                {
                    throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.EMPTY_INPUT, "First Name should not be empty");
                }
                return Regex.IsMatch(fName, REGEX_FIRST_NAME);
            }
            catch (NullReferenceException)
            {
                throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.NULL_INPUT, "First Name should not be null");
            }
        }
        public bool ValidateLastName(string lName)
        {
            try
            {
                if (lName.Equals(string.Empty))
                {
                    throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.EMPTY_INPUT, "Last Name should not be empty");
                }
                return Regex.IsMatch(lName, REGEX_LAST_NAME);
            }
            catch (NullReferenceException)
            {
                throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.NULL_INPUT, "Last Name should not be null");
            }
        }
        public bool ValidateEmail(string email)
        {
            try
            {
                if (email.Equals(string.Empty))
                {
                    throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.EMPTY_INPUT, "Email should not be empty");
                }
                return Regex.IsMatch(email, REGEX_EMAIL);
            }
            catch (NullReferenceException)
            {
                throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.NULL_INPUT, "Email should not be null");
            }
        }
        public bool ValidateNumber(string number)
        {
            try
            {
                if (number.Equals(string.Empty))
                {
                    throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.EMPTY_INPUT, "Mobile Number should not be empty");
                }
                return Regex.IsMatch(number, REGEX_NUMBER);
            }
            catch (NullReferenceException)
            {
                throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.NULL_INPUT, "Mobile Number should not be null");
            }
        }
        public bool ValidatePassword(string password)
        {
            try
            {
                if (password.Equals(string.Empty))
                {
                    throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.EMPTY_INPUT, "Password should not be empty");
                }
                return Regex.IsMatch(password, REGEX_PASSWORD);
            }
            catch (NullReferenceException)
            {
                throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.NULL_INPUT, "Password should not be null");
            }
        }
    }
}
