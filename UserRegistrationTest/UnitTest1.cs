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
        [DataRow("abc123@gmail.com")]
        [DataRow("abc123@gmail.com.in")]
        [DataRow("abc.123@gmail.com")]
        [DataRow("abc123@gml.com")]
        [DataRow("abc.123@gmail.com.in")]
        public void Validate_Multiple_Email_Enteries(string email)
        {
            //Arrange
            UserDetailsValidation validate = new UserDetailsValidation();
            bool expected = true;
            //Act
            bool result = validate.ValidateEmail(email);
            //Assert
            Assert.AreEqual(expected, result);
        }
    }
}
