using System;

namespace _04._Password_Validator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            bool check1 = IfContainRecomendedChars(password);
            bool check2 = IfContainLetterDigits(password);
            bool check3 = IfContainRecomendedDigits(password);

            if (check1 && check2 && check3)
            {
                Console.WriteLine("Password is valid");
            }
            
        }
        static bool IfContainRecomendedDigits(string password)
        {
          
            int count = 0;
            for (int i = 0; i < password.Length; i++)
            {
                if (password[i] >= 48 && password[i] <= 57)
                {
                    count++;
                }
            }
            if (count < 2)
            {
                Console.WriteLine("Password must have at least 2 digits");
                return false;
            }
            return true;
        }

        static bool IfContainLetterDigits(string password)
        {
            
            for (int i = 0; i < password.Length; i++)
            {
                if (!(password[i] >= 48 && password[i] <= 57 ||
                    password[i] >= 65 && password[i] <= 90 ||
                    password[i] >= 97 && password[i] <= 122))
                {
                    Console.WriteLine("Password must consist only of letters and digits");
                    
                    return false;
                }
            }
            return true;
        }

        static bool IfContainRecomendedChars(string password)
        {
            
            if (password.Length < 6 || password.Length > 10)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
                return false;
            }
            return true;
        }
    }
}
