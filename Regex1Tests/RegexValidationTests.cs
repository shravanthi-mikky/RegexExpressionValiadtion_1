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
    public class RegexValidationTests
    {
        [TestMethod()]
        public void FirstNameValidationTest()
        {
            RegexValidation r1 = new();
            r1.FirstNameValidation("Sravanthi");
            Assert.AreEqual(true, r1.FirstNameValidation("Sravanthi"));
        }

        [TestMethod()]
        public void LastNameValidationTest1()
        {
            RegexValidation r2 = new();
            r2.LastNameValidation("");
            Assert.AreEqual(true, r2.LastNameValidation("Pabboji"));
        }

        [TestMethod()]
        public void EmailTest()
        {
            RegexValidation r3 = new();
            r3.Email("");
            Assert.AreEqual(true, r3.Email("abc.xyz@bl.co.in"));
        }

        [TestMethod()]
        public void MobileNumberTest()
        {
            RegexValidation r4 = new();
            r4.MobileNumber("+91 8282828282");
            Assert.AreEqual(true, r4.MobileNumber("+91 8282828282"));
        }

        [TestMethod()]
        public void PasswordTest()
        {
            RegexValidation r5 = new();
            r5.Password("");
            Assert.AreEqual(true, r5.Password("sravanthi"));
        }

        [TestMethod()]
        public void PasswordRule2Test()
        {
            RegexValidation r6 = new();
            r6.PasswordRule2("");
            Assert.AreEqual(true, r6.PasswordRule2("Sravanthi"));
        }

        [TestMethod()]
        public void PasswordRule3Test()
        {
            RegexValidation r7 = new();
            r7.PasswordRule3("");
            Assert.AreEqual(true, r7.PasswordRule3("Sravanthi12"));
        }

        [TestMethod()]
        public void PasswordRule4Test()
        {
            RegexValidation r8 = new();
            r8.PasswordRule4("");
            Assert.AreEqual(true, r8.PasswordRule4("P@ssw0rd123"));
        }
    }
}