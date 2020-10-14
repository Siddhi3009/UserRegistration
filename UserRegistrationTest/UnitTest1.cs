using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using UserRegistration;
namespace UserRegistrationTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ValidateFirstName_Should_return_true_on_valid_input()
        {
            //Arrange
            UserDetailsValidation validate = new UserDetailsValidation();
            bool expected = true;
            //Act
            bool result = validate.ValidateFirstName("Siddhi");
            //Assert
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void ValidateFirstName_Should_return_false_on_invalid_input()
        {
            //Arrange
            UserDetailsValidation validate = new UserDetailsValidation();
            bool expected = false;
            //Act
            bool result = validate.ValidateFirstName("siddhi");
            //Assert
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void Given_Empty_FirstName_Should_Throw_UserRegistrationException_Indicating_EmptyInput()
        {
            try
            {
                string fName = string.Empty;
                UserDetailsValidation details = new UserDetailsValidation();
                bool actual = details.ValidateFirstName(fName);
            }
            catch (UserRegistrationCustomException e)
            {
                Assert.AreEqual("First Name should not be empty", e.Message);
            }
        }
        [TestMethod]
        public void Given_NULL_FirstName_Should_Throw_UserRegistrationException()
        {
            try
            {
                string fName = null;
                UserDetailsValidation details = new UserDetailsValidation();
                bool actual = details.ValidateFirstName(fName);
            }
            catch (UserRegistrationCustomException e)
            {
                Assert.AreEqual("First Name should not be null", e.Message);
            }
        }
        [TestMethod]
        public void ValidateLastName_Should_return_true_on_valid_input()
        {
            //Arrange
            UserDetailsValidation validate = new UserDetailsValidation();
            bool expected = true;
            //Act
            bool result = validate.ValidateLastName("Seth");
            //Assert
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void ValidateLastName_Should_return_false_on_invalid_input()
        {
            //Arrange
            UserDetailsValidation validate = new UserDetailsValidation();
            bool expected = false;
            //Act
            bool result = validate.ValidateLastName("seth");
            //Assert
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void Given_Empty_LastName_Should_Throw_UserRegistrationException_Indicating_EmptyInput()
        {
            try
            {
                string lName = string.Empty;
                UserDetailsValidation details = new UserDetailsValidation();
                bool actual = details.ValidateLastName(lName);
            }
            catch (UserRegistrationCustomException e)
            {
                Assert.AreEqual("Last Name should not be empty", e.Message);
            }
        }
        [TestMethod]
        public void Given_NULL_LastName_Should_Throw_UserRegistrationException()
        {
            try
            {
                string lName = null;
                UserDetailsValidation details = new UserDetailsValidation();
                bool actual = details.ValidateLastName(lName);
            }
            catch (UserRegistrationCustomException e)
            {
                Assert.AreEqual("Last Name should not be null", e.Message);
            }
        }
        [TestMethod]
        public void ValidateEmail_Should_return_true_on_valid_input()
        {
            //Arrange
            UserDetailsValidation validate = new UserDetailsValidation();
            bool expected = true;
            //Act
            bool result = validate.ValidateEmail("Siddhi.seth3009@gmail.com.in");
            //Assert
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void ValidateEmail_Should_return_false_on_invalid_input()
        {
            //Arrange
            UserDetailsValidation validate = new UserDetailsValidation();
            bool expected = false;
            //Act
            bool result = validate.ValidateEmail("siddhi@abc@gmail.co.in.au");
            //Assert
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void Given_Empty_Email_Should_Throw_UserRegistrationException_Indicating_EmptyInput()
        {
            try
            {
                string email = string.Empty;
                UserDetailsValidation details = new UserDetailsValidation();
                bool actual = details.ValidateEmail(email);
            }
            catch (UserRegistrationCustomException e)
            {
                Assert.AreEqual("Email should not be empty", e.Message);
            }
        }
        [TestMethod]
        public void Given_NULL_Email_Should_Throw_UserRegistrationException()
        {
            try
            {
                string email = null;
                UserDetailsValidation details = new UserDetailsValidation();
                bool actual = details.ValidateEmail(email);
            }
            catch (UserRegistrationCustomException e)
            {
                Assert.AreEqual("Email should not be null", e.Message);
            }
        }
        [TestMethod]
        [DataRow("abc123@gmail.com", true)]
        [DataRow("abc123@gmail.com.in", true)]
        [DataRow("abc.123gmail.com", false)]
        [DataRow("abc123@gml.com", true)]
        [DataRow("abc.123@gmail.com.in", true)]
        public void Validate_Multiple_Email_Enteries(string email, bool expected)
        {
            //Arrange
            UserDetailsValidation validate = new UserDetailsValidation();
            //Act
            bool result = validate.ValidateEmail(email);
            //Assert
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void ValidateNumber_Should_return_true_on_valid_input()
        {
            //Arrange
            UserDetailsValidation validate = new UserDetailsValidation();
            bool expected = true;
            //Act
            bool result = validate.ValidateNumber("91 6958348751");
            //Assert
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void ValidateNumber_Should_return_false_on_invalid_input()
        {
            //Arrange
            UserDetailsValidation validate = new UserDetailsValidation();
            bool expected = false;
            //Act
            bool result = validate.ValidateNumber("12548963");
            //Assert
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void Given_Empty_Number_Should_Throw_UserRegistrationException_Indicating_EmptyInput()
        {
            try
            {
                string number = string.Empty;
                UserDetailsValidation details = new UserDetailsValidation();
                bool actual = details.ValidateNumber(number);
            }
            catch (UserRegistrationCustomException e)
            {
                Assert.AreEqual("Mobile Number should not be empty", e.Message);
            }
        }
        [TestMethod]
        public void Given_NULL_Number_Should_Throw_UserRegistrationException()
        {
            try
            {
                string number = null;
                UserDetailsValidation details = new UserDetailsValidation();
                bool actual = details.ValidateNumber(number);
            }
            catch (UserRegistrationCustomException e)
            {
                Assert.AreEqual("Mobile Number should not be null", e.Message);
            }
        }
        [TestMethod]
        public void ValidatePassword_Should_return_true_on_valid_input()
        {
            //Arrange
            UserDetailsValidation validate = new UserDetailsValidation();
            bool expected = true;
            //Act
            bool result = validate.ValidatePassword("Sg753eyt@fhmD");
            //Assert
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void ValidatePassword_Should_return_false_on_invalid_input()
        {
            //Arrange
            UserDetailsValidation validate = new UserDetailsValidation();
            bool expected = false;
            //Act
            bool result = validate.ValidatePassword("S348gbjdFTY");
            //Assert
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void Given_Empty_Password_Should_Throw_UserRegistrationException_Indicating_EmptyInput()
        {
            try
            {
                string password = string.Empty;
                UserDetailsValidation details = new UserDetailsValidation();
                bool actual = details.ValidatePassword(password);
            }
            catch (UserRegistrationCustomException e)
            {
                Assert.AreEqual("Password should not be empty", e.Message);
            }
        }
        [TestMethod]
        public void Given_NULL_Password_Should_Throw_UserRegistrationException()
        {
            try
            {
                string password = null;
                UserDetailsValidation details = new UserDetailsValidation();
                bool actual = details.ValidatePassword(password);
            }
            catch (UserRegistrationCustomException e)
            {
                Assert.AreEqual("Password should not be null", e.Message);
            }
        }
    }
}
