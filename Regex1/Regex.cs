﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Regex1
{
    public class RegexValidation
    {
        public void FirstNameValidation()
        {  
            Console.WriteLine("Enter First Name");
            string Firstname = Console.ReadLine();
            string firstname = "^[A-Z]{1}[a-z]{2,}";
            Regex regex = new Regex(firstname);
            if (regex.IsMatch(Firstname))
            {
                Console.Write("Name is Valid \n");
            }
            else
            {
                Console.Write("Please Enter First Letter Capital \n");
            }
        }
        public void LastNameValidation()
        {
            Console.WriteLine("Enter Last Name");
            string Lastname = Console.ReadLine();
            string lastname = "^[A-Z]{1}[a-z]{2,}$";
            Regex regex1 = new Regex(lastname);
            if (regex1.IsMatch(Lastname))
            {
                Console.Write("Name is Valid \n");
            }
            else
            {
                Console.Write("Please Enter First Letter Capital \n");
            }
        }
        public void Email()
        {
            Console.WriteLine("Enter Email Id");
            string email = Console.ReadLine();
            string emailFormat = "^[A-Za-z](.[a-z])+@[A-Za-z]+.[a-z]{2,4}(.[a-z]{2,3})?$";
            Regex regex1 = new Regex(emailFormat);
            if (regex1.IsMatch(email))
            {
                Console.Write("Given Email ID is Valid \n");
            }
            else
            {
                Console.Write("Please Enter Email ID in Proper Format \n");
            }
        }
        public void MobileNumber()
        {
            Console.WriteLine("Enter Mobile Number :");
            var Number = Console.ReadLine();
            var NumberFormat = "^[0-9]{2}\\s[0-9]{10}$";
            Regex regex1 = new Regex(NumberFormat);
            if (regex1.IsMatch(Number))
            {
                Console.Write("Given Phone Number is Valid \n");
            }
            else
            {
                Console.Write("Please Enter Number in Proper Format \n");
            }
        }
    }
}