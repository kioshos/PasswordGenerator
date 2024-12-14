using PGenerator.Models;
using PGenerator.Services;

namespace PGenerator.UI;

public class ConsoleInterface
{
    public static void Run()
    {
        Console.WriteLine("=== Password Generator ===");
        Console.Write("Enter password length: ");
        int length = int.Parse(Console.ReadLine());

        Console.Write("Include uppercase letters? (y/n): ");
        bool includeUppercase = Console.ReadLine()?.ToLower() == "y";

        Console.Write("Include numbers? (y/n): ");
        bool includeNumbers = Console.ReadLine()?.ToLower() == "y";

        Console.Write("Include special characters? (y/n): ");
        bool includeSpecialChars = Console.ReadLine()?.ToLower() == "y";

        var config = new PasswordConfig
        {
            PasswordLength = length,
            IncludeUppercase = includeUppercase,
            IncludeNumbers = includeNumbers,
            IncludeSpecialCharacters = includeSpecialChars
        };

        try
        {
            string password = PasswordGenerator.GeneratePassword(config);
            Console.WriteLine($"Generated Password: {password}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}