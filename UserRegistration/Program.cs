using System;
using System.Collections.Generic;

namespace UserRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ValidationResult> validEnteries = new List<ValidationResult>();
            UserDetailsValidation validation = new UserDetailsValidation();
            Console.WriteLine("User Registration");

            Console.WriteLine("Enter first name with first letter captial and minimum 3 characters");
            string fName = Console.ReadLine();
            bool validFirstName = validation.ValidateFirstName(fName);
            ValidationResult fNameObj = new ValidationResult(fName, validFirstName);
            validEnteries.Add(fNameObj);
            
            Console.WriteLine("Enter last name with first letter captial and minimum 3 characters");
            string lName = Console.ReadLine();
            bool validLastName = validation.ValidateLastName(lName);
            ValidationResult lNameObj = new ValidationResult(lName, validLastName);
            validEnteries.Add(lNameObj);
           
            Console.WriteLine("Enter Email");
            string email = Console.ReadLine();
            bool validEmail = validation.ValidateEmail(email);
            ValidationResult emailObj = new ValidationResult(email, validEmail);
            validEnteries.Add(emailObj);
            
            Console.WriteLine("Enter Mobile Number");
            string number = Console.ReadLine(); 
            bool validNumber = validation.ValidateNumber(number);
            ValidationResult numberObj = new ValidationResult(number, validNumber);
            validEnteries.Add(numberObj);
            
            Console.WriteLine("Enter Password");
            string password = Console.ReadLine();
            bool validPassword = validation.ValidatePassword(password);
            ValidationResult passwordObj = new ValidationResult(password, validPassword);
            validEnteries.Add(passwordObj);

            foreach (ValidationResult entry in validEnteries.FindAll(e => e.Result == false))
            {
                Console.WriteLine("Invalid Entry : " + entry.UserEntry);
            }
            
        }
    }
}
