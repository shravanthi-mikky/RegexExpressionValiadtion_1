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
    public class EmailValidationTests
    {
        [TestMethod()]
        public void EmailSampleValidationTest()
        {
            EmailValidation test = new();
            test.EmailSampleValidation("abc@yahoo.com");
            Assert.AreEqual(true, test.EmailSampleValidation("abc@yahoo.com"));
        }
        [TestMethod()]
        public void EmailSampleValidationTest1()
        {
            EmailValidation test = new();
            test.EmailSampleValidation("abc-100@yahoo.com");
            Assert.AreEqual(true, test.EmailSampleValidation("abc-100@yahoo.com"));
        }
        [TestMethod()]
        public void EmailSampleValidationTest2()
        {
            EmailValidation test = new();
            test.EmailSampleValidation("abc.100@yahoo.com");
            Assert.AreEqual(true, test.EmailSampleValidation("abc.100@yahoo.com"));
        }
        [TestMethod()]
        public void EmailSampleValidationTest3()
        {
            EmailValidation test = new();
            test.EmailSampleValidation("abc111@abc.com");
            Assert.AreEqual(true, test.EmailSampleValidation("abc111@abc.com"));
        }
        [TestMethod()]
        public void EmailSampleValidationTest4()
        {
            EmailValidation test = new();
            test.EmailSampleValidation("abc-100@abc.net");
            Assert.AreEqual(true, test.EmailSampleValidation("abc-100@abc.net"));
        }
        [TestMethod()]
        public void EmailSampleValidationTest5()
        {
            EmailValidation test = new();
            test.EmailSampleValidation("abc.100@abc.com.au");
            Assert.AreEqual(true, test.EmailSampleValidation("abc.100@abc.com.au"));
        }
        [TestMethod()]
        public void EmailSampleValidationTest6()
        {
            EmailValidation test = new();
            test.EmailSampleValidation("abc@1.com");
            Assert.AreEqual(true, test.EmailSampleValidation("abc@1.com"));
        }
        [TestMethod()]
        public void EmailSampleValidationTest7()
        {
            EmailValidation test = new();
            test.EmailSampleValidation("abc.100@gmail.com.com");
            Assert.AreEqual(true, test.EmailSampleValidation("abc.100@gmail.com.com"));
        }
        [TestMethod()]
        public void EmailSampleValidationTest8()
        {
            EmailValidation test = new();
            test.EmailSampleValidation("abc+100@gmail.com");
            Assert.AreEqual(true, test.EmailSampleValidation("abc+100@gmail.com"));
        }
    }
}