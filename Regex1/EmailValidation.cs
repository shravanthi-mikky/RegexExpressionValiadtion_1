using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Regex1
{
    public class EmailValidation
    {
        public void EmailSampleValidation()
        {
            Console.WriteLine("Enter Email Id");
            string email = Console.ReadLine();
            string emailFormat = "[A-Za-z0-9](.[-+a-z0-9A-Z])+@[A-Za-z0-9]+.[a-z]{2,4}(.[a-z]{2,3})?$";
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
    }
}
