using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
public class Utils
{
    public static string HashPassword(string password)
    {
        using (SHA256 sha256 = SHA256.Create())
        {
            byte[] bytes = Encoding.UTF8.GetBytes(password);
            byte[] hash = sha256.ComputeHash(bytes);
            StringBuilder sb = new StringBuilder();
            foreach (byte b in hash)
            {
                sb.Append(b.ToString("x2"));
            }
            return sb.ToString();
        }
    }

    public static bool IsValidEmail(string email)
    {
        if (string.IsNullOrWhiteSpace(email))
            return false;

        string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
        return Regex.IsMatch(email, pattern);
    }

    public static int GetPasswordStrength(string password)
    {
        if (string.IsNullOrEmpty(password))
            return 0;

        int score = 0;

        if (password.Length >= 8) score++;
        if (Regex.IsMatch(password, @"[a-z]")) score++;
        if (Regex.IsMatch(password, @"[A-Z]")) score++;
        if (Regex.IsMatch(password, @"\d")) score++;
        if (Regex.IsMatch(password, @"[^a-zA-Z0-9]")) score++;

        return score; 
    }
}



