// See https://aka.ms/new-console-template for more information
using Regex1;

Console.WriteLine("Validation for Form ");
while (true)
{
    Console.WriteLine("Please choose the option :\n1)First Name \n2 Last Name\n3) Email\n4) Mobile Number\n5) Password With min 8 Characters\n6) Password with atleast one capital letter\n7)Password with atleast one number\n8)Password with atleast one special character\n9)Email Sample Validation");
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
        default:
            Console.WriteLine("Please enter the correct value.");
            break;
    }
}