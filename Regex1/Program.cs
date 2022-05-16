// See https://aka.ms/new-console-template for more information
using Regex1;

Console.WriteLine("Validation for Form ");
while (true)
{
    Console.WriteLine("Please choose the option :\n1)First Name \n2 Last Name\n3) Email\n4) Mobile Number");
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
        default:
            Console.WriteLine("Please enter the correct value.");
            break;
    }
}