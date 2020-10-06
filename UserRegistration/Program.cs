using System;

namespace UserRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            UserDetailsValidation validation = new UserDetailsValidation();
            Console.WriteLine("User Registration");
            Console.WriteLine("Enter first name with first letter captial and minimum 3 characters");
            string fName = Console.ReadLine();
            bool validFirstName = validation.validateFirstName(fName);
            Console.WriteLine("First Name Valid : " + validFirstName);
        }
    }
}
