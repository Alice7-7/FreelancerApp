using System;
using System.Security.Cryptography;

public static class PasswordHasher
{

    // Defending Brute_Force

    private const int SaltSize = 16;
    private const int HashSize = 32;
    private const int Iterations = 100_000;


    // Hashing Password :::

    public static string HashPassword(string password, out string salt)
    {
        byte[] saltBytes = new byte[SaltSize];
        using (var rng = RandomNumberGenerator.Create())
        {
            rng.GetBytes(saltBytes);
        }

        salt = Convert.ToBase64String(saltBytes);

        using (var deriveBytes = new Rfc2898DeriveBytes(password, saltBytes, Iterations, HashAlgorithmName.SHA256))
        {
            return Convert.ToBase64String(deriveBytes.GetBytes(HashSize));
        }
    }

    // Verifying Password :::

    public static bool VerifyPassword(string password, string storedSalt, string storedHash)
    {
        byte[] saltBytes = Convert.FromBase64String(storedSalt);
        using (var deriveBytes = new Rfc2898DeriveBytes(password, saltBytes, Iterations, HashAlgorithmName.SHA256))
        {
            string newHash = Convert.ToBase64String(deriveBytes.GetBytes(HashSize));
            return SecureTiming(newHash, storedHash);
        }
    }


    // Securing Timing Attack :::
    private static bool SecureTiming(string a, string b)
    {
        if (a.Length != b.Length)
            return false;

        int result = 0;
        for (int i = 0; i < a.Length; i++)
        {
            result |= a[i] ^ b[i];
        }
        return result == 0;
    }
}
