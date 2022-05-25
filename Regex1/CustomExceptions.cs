using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Regex1
{
    public class CustomExceptions : Exception
    {
        public enum ValidationMessage
        {
            InvalidFirstName, InvalidLastName,
            InvalidEmailId, InvalidMobileNumber,
            InvalidPassword,
            InvalidSampleEmailId

        }
        public readonly ValidationMessage Type;

        public CustomExceptions(ValidationMessage Type, string message) : base(message)
        {
            this.Type = Type;
        }
    }
    public class UserRegistration
    {
        public string CustomException_FirstName(string message)
        {

            try
            {

                if (string.IsNullOrEmpty(message))
                {
                    throw new CustomExceptions(CustomExceptions.ValidationMessage.InvalidFirstName, "FirstName Should not be Empty or Null");
                }

                string firstname = "^[A-Z]{1}[a-z]{2,}$";
                Regex regex = new Regex(firstname);

                if (regex.IsMatch(message))
                {
                    Console.Write("Name is Valid\n");
                    return "Name is Valid";
                }
                else
                {
                    throw new CustomExceptions(CustomExceptions.ValidationMessage.InvalidFirstName, "Invalid First Name! Please enter first letter Capital.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                //throw new CustomExceptions(CustomExceptions.ValidationMessage.InvalidFirstName, "Please Enter First Letter Capital ");

            }
            return default(String);
        }
        public string CustomException_LastName(string message)
        {
            try
            {
                if (string.IsNullOrEmpty(message))
                {
                    throw new CustomExceptions(CustomExceptions.ValidationMessage.InvalidLastName, "LastName Should not be Empty or Null");
                }

                string lastname = "^[A-Z]{1}[a-z]{2,}$";
                Regex regex = new Regex(lastname);

                if (regex.IsMatch(message))
                {
                    Console.Write("Last Name is Valid\n");
                    return "Last Name is Valid";
                }
                else
                {
                    throw new CustomExceptions(CustomExceptions.ValidationMessage.InvalidLastName, "Invalid Last Name! Please enter first letter Capital.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                //throw new CustomExceptions(CustomExceptions.ValidationMessage.InvalidFirstName, "Please Enter Last Letter Capital ");

            }
            return default(String);
        }
        public string CustomException_EmailId(string message)
        {
            try
            {
                if (string.IsNullOrEmpty(message))
                {
                    throw new CustomExceptions(CustomExceptions.ValidationMessage.InvalidEmailId, "Email ID Should not be Empty or Null");
                }

                string emailFormat = "^[A-Za-z](.[a-z])+@[A-Za-z]+.[a-z]{2,4}(.[a-z]{2,3})?$";
                Regex regex1 = new Regex(emailFormat);

                if (regex1.IsMatch(message))
                {
                    Console.Write("Email ID is Valid \n");
                    return "Email ID is Valid ";
                }
                else
                {
                    throw new CustomExceptions(CustomExceptions.ValidationMessage.InvalidEmailId, "Invalid Email ID!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                //throw new CustomExceptions(CustomExceptions.ValidationMessage.InvalidEmailID");

            }
            return default(String);
        }
        public string CustomException_MobileNumber(string message)
        {
            try
            {
                if (string.IsNullOrEmpty(message))
                {
                    throw new CustomExceptions(CustomExceptions.ValidationMessage.InvalidMobileNumber, "Mobile Number Should not be Empty or Null");
                }

                string NumberFormat = "^[0-9]{2}\\s[0-9]{10}$";
                Regex regex1 = new Regex(NumberFormat);

                if (regex1.IsMatch(message))
                {
                    Console.Write("Mobile Number is Valid \n");
                    return "Mobile Number is Valid";
                }
                else
                {
                    throw new CustomExceptions(CustomExceptions.ValidationMessage.InvalidMobileNumber, "Invalid Mobile Number!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                //throw new CustomExceptions(CustomExceptions.ValidationMessage.InvalidMobileNumber");

            }
            return default(String);
        }
        public string CustomException_Password(string message)
        {
            try
            {
                if (string.IsNullOrEmpty(message))
                {
                    throw new CustomExceptions(CustomExceptions.ValidationMessage.InvalidPassword, "Password Should not be Empty or Null");
                }

                string Password = "^(?=.*[@#$%0-9A-Z])[@#$%0-9a-zA-Z]{8,}$";
                Regex regex1 = new Regex(Password);

                if (regex1.IsMatch(message))
                {
                    Console.Write("Password is Valid \n");
                    return "Password is Valid";
                }
                else
                {
                    throw new CustomExceptions(CustomExceptions.ValidationMessage.InvalidPassword, "Invalid Password!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                //throw new CustomExceptions(CustomExceptions.ValidationMessage.InvalidPassword");
            }
            return default(String);
        }

    } 
}
