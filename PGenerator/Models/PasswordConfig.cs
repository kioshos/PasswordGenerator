namespace PGenerator.Models;

public class PasswordConfig
{
    public int PasswordLength { get; set; }
    public bool IncludeUppercase { get; set; }
    public bool IncludeNumbers { get; set; }
    public bool IncludeSpecialCharacters { get; set; }
}