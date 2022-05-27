using Microsoft.VisualStudio.TestTools.UnitTesting;
using Regex1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Regex1.Tests
{
    [TestClass()]
    public class UserRegistrationTests
    {
        [TestMethod()]
        public void CustomException_FirstNameTest()
        {
            UserRegistration c1 = new();
            string exp = "Name is Valid";
            string custom = c1.CustomException_FirstName("Shravanthi");
            exp.Equals(custom);
        }
        [TestMethod()]
        public void CustomException_LastNameTest()
        {
            UserRegistration c1 = new();
            string exp = "Last Name is Valid";
            string custom = c1.CustomException_LastName("Pabboji");
            exp.Equals(custom);

        }

        [TestMethod()]
        public void CustomException_EmailIdTest2()
        {
            UserRegistration c1 = new();
            string exp = "Email ID is Valid ";
            string custom = c1.CustomException_EmailId("abc.xyz@gmail.co.in");
            exp.Equals(custom);
        }
        [TestMethod()]
        public void CustomException_MobileNumberTest2()
        {
            UserRegistration c1 = new();
            string exp = "Mobile Number is Valid";
            string custom = c1.CustomException_MobileNumber("+91 8912345678");
            exp.Equals(custom);
        }
        [TestMethod()]
        public void CustomException_PasswordTest()
        {
            UserRegistration c1 = new();
            string exp = "Password is Valid";
            string custom = c1.CustomException_Password("Password!23");
            exp.Equals(custom);
        }
       
    }
}