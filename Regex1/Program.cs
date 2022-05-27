// See https://aka.ms/new-console-template for more information
using Regex1;

Console.WriteLine("Validation for Form ");
while (true)
{
    Console.WriteLine("Please choose the option :\n1) First Name\n2 Last Name\n3) Email\n4) Mobile Number\n5) Password With min 8 Characters\n6) Password with atleast one capital letter\n7)Password with atleast one number\n8)Password with atleast one special character\n9)Email Sample Validation\n10)Using Custom Exception First Name\n11)Using Custom Exception Last Name\n12)Using Custom Exception Email Id\n13)Using Custom Exception Mobile Number\n14)Using Custom Exception Password\n15)Validation using Lambda Expression");
    int option = Convert.ToInt16(Console.ReadLine());
    switch (option)
    {
        case 1:
            RegexValidation r1 = new();
            Console.WriteLine("Enter First Name");
            string Firstname = Console.ReadLine();
            r1.FirstNameValidation(Firstname);
            break;
        case 2:
            Console.WriteLine("Enter Last Name");
            string Lastname = Console.ReadLine();
            RegexValidation r2 = new();
            r2.LastNameValidation(Lastname);
            break;
        case 3:
            RegexValidation r3 = new();
            Console.WriteLine("Enter Email Id");
            string email = Console.ReadLine();
            r3.Email(email);
            break;
        case 4:
            RegexValidation r4 = new();
            Console.WriteLine("Enter Mobile Number");
            string Number = Console.ReadLine();
            r4.MobileNumber(Number);
            break;
        case 5:
            RegexValidation r5 = new();
            Console.WriteLine("Enter Password :");
            string Password = Console.ReadLine();
            r5.Password(Password);
            break;
        case 6:
            RegexValidation r6 = new();
            Console.WriteLine("Enter Password :");
            string Password1 = Console.ReadLine();
            r6.PasswordRule2(Password1);
            break;
        case 7:
            RegexValidation r7 = new();
            Console.WriteLine("Enter Password :");
            string Password2 = Console.ReadLine();
            r7.PasswordRule3(Password2);
            break;
        case 8:
            RegexValidation r8 = new();
            Console.WriteLine("Enter Password :");
            string Password3 = Console.ReadLine();
            r8.PasswordRule4(Password3);
            break;
        case 9:
            EmailValidation test = new();
            Console.WriteLine("Enter Password :");
            string email1 = Console.ReadLine();
            test.EmailSampleValidation(email1);
            break;
        case 10:
            UserRegistration c1 = new();
            string custom = c1.CustomException_FirstName(null);
            Console.WriteLine(custom);
            break;
        case 11:
            UserRegistration c2 = new();
            string custom1 = c2.CustomException_LastName(null);
            Console.WriteLine(custom1);
            break;
        case 12:
            UserRegistration c3 = new();
            string custom2 = c3.CustomException_EmailId("abc.xyz@bl.co.in");
            Console.WriteLine(custom2);
            break;
        case 13:
            UserRegistration c4 = new();
            string custom3 = c4.CustomException_MobileNumber(null);
            Console.WriteLine(custom3);
            break;
        case 14:
            UserRegistration c5 = new();
            string custom4 = c5.CustomException_Password("Password@123");
            Console.WriteLine(custom4);
            break;
        case 15:
            RegexValidation l1 = new();
            //FirstName
            Console.WriteLine("Enter First name :");
            string firstName1 = Console.ReadLine();
            string output1 = l1.LambdaExpressionFirstName(firstName1);
            Console.WriteLine(output1);
            //lasName
            Console.WriteLine("Enter Last Name :");
            string lastName1 = Console.ReadLine();
            string output2 = l1.LambdaExpressionLastName(lastName1);
            Console.WriteLine(output2);
            //Email
            Console.WriteLine("Enter Email Id :");
            string emailId = Console.ReadLine();
            string output3 = l1.LambdaExpressionEmail(emailId);
            Console.WriteLine(output3);
            //Mobile Number
            Console.WriteLine("Enter Mobile Number :");
            string PhoneNumber = Console.ReadLine();
            string output4 = l1.LambdaExpressionPhoneNumber(PhoneNumber);
            Console.WriteLine(output4);
            //Password
            Console.WriteLine("Enter Password :");
            string Password_Lambda = Console.ReadLine();
            string output5 = l1.LambdaExpressionPassword(Password_Lambda);
            Console.WriteLine(output5);
            break;
        default:
            Console.WriteLine("Please Enter the correct value.");
            break;
    }
}