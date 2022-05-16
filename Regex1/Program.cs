// See https://aka.ms/new-console-template for more information
using Regex1;

Console.WriteLine("Validation for Form ");
while (true)
{
    Console.WriteLine("Please choose the option :\n1)First Name \n2 Last Name");
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
        default:
            Console.WriteLine("Please enter the correct value.");
            break;
    }
}