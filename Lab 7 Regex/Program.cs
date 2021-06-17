using System;
using System.Text.RegularExpressions;

namespace Lab_7_Regex
{
    class Program
    {
        static void Main(string[] args)
        {
            ValidateUserName();
            ValidateUserDate();
            ValidateUserEmail();
            ValidateUserInput();
        }

        static void ValidateUserName()
        {
            Regex namePattern = new Regex(@"(^[A-Za-z\s]{1,30}$)");
            Console.WriteLine("Please enter a name");
            var nameGiven = Console.ReadLine();

            if (namePattern.IsMatch(nameGiven))
            {
                Console.WriteLine("That's a great name");
            }
            else
            {
                Console.WriteLine("Sorry, your name is too long");
            }
        }

        static void ValidateUserDate()
        {
            Regex datePatern = new Regex(@"(\d{2}/)(\d{2}/)(\d{4})");
            Console.WriteLine("Please enter a valid Date");
            var validDate = Console.ReadLine();

            if (datePatern.IsMatch(validDate))
            {
                Console.WriteLine("This is a valid date");
            }
            else
            {
                Console.WriteLine("Please try again");
            }
        }

        static void ValidateUserEmail()
        {
            Regex emailPattern = new Regex(@"(\w +)@(\w +)(\.(\w{ 2,3}))");
            Console.WriteLine("Please enter a valid email address");
            var emailAddress = Console.ReadLine();

            if (emailPattern.IsMatch(emailAddress))
            {
                Console.WriteLine("Valid email bro");
            }
            else
            {
                Console.WriteLine("Invalid email address");
            }
        }
        static void ValidateUserInput()
        {
            Regex pattern = new Regex(@"(\d{3}-)(\d{3}-)(\d{4})");
            Console.WriteLine("Please enter a valid phone number");
            var phoneNumber = Console.ReadLine();

            if (pattern.IsMatch(phoneNumber))
            {
                Console.WriteLine("This is a real number");
            }
            else
            {
                Console.WriteLine("Not a real number");
            }
        }

    }
}
