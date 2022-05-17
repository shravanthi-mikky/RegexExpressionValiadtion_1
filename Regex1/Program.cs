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
            r1.FirstNameValidation();
            break;
        case 2:
            RegexValidation r2 = new();
            r2.LastNameValidation();
            break;
        case 3:
            RegexValidation r3 = new();
            r3.Email();
            break;
        case 4:
            RegexValidation r4 = new();
            r4.MobileNumber();
            break;
        case 5:
            RegexValidation r5 = new();
            r5.Password();
            break;
        case 6:
            RegexValidation r6 = new();
            r6.PasswordRule2();
            break;
        case 7:
            RegexValidation r7 = new();
            r7.PasswordRule3();
            break;
        case 8:
            RegexValidation r8 = new();
            r8.PasswordRule3();
            break;
        case 9:
            EmailValidation test = new();
            test.EmailSampleValidation();
            break;
        default:
            Console.WriteLine("Please enter the correct value.");
            break;
    }
}