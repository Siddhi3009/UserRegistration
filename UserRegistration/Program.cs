using System;

namespace UserRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            UserDetailsValidation validation = new UserDetailsValidation();
            //Console.WriteLine("User Registration");
            //Console.WriteLine("Enter first name with first letter captial and minimum 3 characters");
            //string fName = Console.ReadLine();
            //bool validFirstName = validation.validateFirstName(fName);
            //Console.WriteLine("First Name Valid : " + validFirstName);
            //Console.WriteLine("______________________________________________________________________");
            //Console.WriteLine("Enter last name with first letter captial and minimum 3 characters");
            //string lName = Console.ReadLine();
            //bool validLastName = validation.validateLastName(lName);
            //Console.WriteLine("Last Name Valid : " + validLastName);
            //Console.WriteLine("______________________________________________________________________");
            //Console.WriteLine("Enter Email");
            //string email = Console.ReadLine();
            //bool validEmail = validation.validateEmail(email);
            //Console.WriteLine("Email Valid : " + validEmail);
            //Console.WriteLine("______________________________________________________________________");
            //Console.WriteLine("Enter Mobile Number");
            //string number = Console.ReadLine();
            //bool validNumber = validation.validateNumber(number);
            //Console.WriteLine("Mobile Number Valid : " + validNumber);
            //Console.WriteLine("______________________________________________________________________");
            Console.WriteLine("Enter Password");
            string password = Console.ReadLine();
            bool validPassword = validation.validatePassword(password);
            Console.WriteLine("Password Valid : " + validPassword);
            Console.WriteLine("______________________________________________________________________");
        }
    }
}
