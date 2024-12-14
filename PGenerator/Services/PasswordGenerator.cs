using System.Security.Cryptography;
using PGenerator.Models;

namespace PGenerator.Services;

public class PasswordGenerator
{
    private static readonly Random _random = new Random();

    public static string GeneratePassword(PasswordConfig config)
    {
        const string lowercase = "abcdefghijklmnopqrstuvwxyz";
        const string uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        const string numbers = "0123456789";
        const string specialChars = "!@#$%^&*";

        string characterPool = lowercase;

        if (config.IncludeUppercase) characterPool += uppercase;
        if (config.IncludeNumbers) characterPool += numbers;
        if (config.IncludeSpecialCharacters) characterPool += specialChars;

        if (string.IsNullOrEmpty(characterPool))
            throw new InvalidOperationException("No characters selected for password generation.");
        
        return new string(Enumerable.Range(0, config.PasswordLength)
            .Select(_ => characterPool[_random.Next(characterPool.Length)])
            .ToArray());
    }
}