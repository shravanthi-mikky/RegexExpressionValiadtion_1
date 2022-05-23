using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Regex1
{
    public class RegexValidation
    {
        public bool FirstNameValidation(string FirstName)
        {
            bool status;
            string firstname = "^[A-Z]{1}[a-z]{2,}";
            Regex regex = new Regex(firstname);
            if (regex.IsMatch(FirstName))
            {
                status = true;
                Console.Write("Name is Valid \n");
            }
            else
            {
                status = false;
                Console.Write("Please Enter First Letter Capital \n");
            }
            return status;
        }
        public bool LastNameValidation(string Lastname)
        {
            bool status;
            string lastname = "^[A-Z]{1}[a-z]{2,}$";
            Regex regex1 = new Regex(lastname);
            if (regex1.IsMatch(Lastname))
            {
                status = true;
                Console.Write("Name is Valid \n");
            }
            else
            {
                status = false;
                Console.Write("Please Enter First Letter Capital \n");
            }
            return status;
        }
        public bool Email(string email)
        {
            bool status;
            string emailFormat = "^[A-Za-z](.[a-z])+@[A-Za-z]+.[a-z]{2,4}(.[a-z]{2,3})?$";
            Regex regex1 = new Regex(emailFormat);
            if (regex1.IsMatch(email))
            {
                status = true;
                Console.Write("Given Email ID is Valid \n");
            }
            else
            {
                status = false;
                Console.Write("Please Enter Email ID in Proper Format \n");
            }
            return status;
        }
        public bool MobileNumber(string Number)
        {
            bool status;
            string NumberFormat = "^[+]{1}[0-9]{2}\\s[6-9]{1}[0-9]{9}$";
            Regex regex1 = new Regex(NumberFormat);
            if (regex1.IsMatch(Number))
            {
                status = true;
                Console.Write("Given Phone Number is Valid \n");
            }
            else
            {
                status = false;
                Console.Write("Please Enter Number in Proper Format \n");
            }
            return status;
        }
        public bool Password(string Password)
        {
            bool status;
            var PasswordFormat = "[a-zA-Z0-9]{8,}";
            Regex regex1 = new Regex(PasswordFormat);
            if (regex1.IsMatch(Password))
            {
                status = true;
                Console.Write("Given Password is Valid \n");
            }
            else
            {
                status = false;
                Console.Write("Please Enter Password in Proper Format \n");
            }
            return status;
        }
        public bool PasswordRule2(string Password)
        {
            bool status;
            var PasswordFormat = "(?=.*[A-Z])[a-zA-Z0-9]{8,}";
            Regex regex1 = new Regex(PasswordFormat);
            if (regex1.IsMatch(Password))
            {
                status = true;
                Console.Write("Given Password is Valid \n");
            }
            else
            {
                status = false;
                Console.Write("Please Enter Password in Proper Format \n");
            }
            return status;
        }
        public bool PasswordRule3(string Password)
        {
            bool status;
            var PasswordFormat = "(?=.*[A-Z0-9])[a-zA-Z0-9]{8,}";
            Regex regex1 = new Regex(PasswordFormat);
            if (regex1.IsMatch(Password))
            {
                status = true;
                Console.Write("Given Password is Valid \n");
            }
            else
            {
                status = false;
                Console.Write("Please Enter Password in Proper Format \n");
            }
            return status;
        }
        public bool PasswordRule4(string Password)
        {
            bool status;
            var PasswordFormat1= "^(?=.*[@#$%0-9A-Z])[@#$%0-9a-zA-Z]{8,}$";
            Regex regex1 = new Regex(PasswordFormat1);
            if (regex1.IsMatch(Password))
            {
                status = true;
                Console.Write("Given Password is Valid \n");
            }
            else
            {
                status = false;
                Console.Write("Please Enter Password in Proper Format \n");
            }
            return status;
        }
        
    }
}
