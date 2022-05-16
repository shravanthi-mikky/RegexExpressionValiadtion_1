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
    }
}
