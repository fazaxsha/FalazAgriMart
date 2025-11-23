using System;
using System.Security.Cryptography;
using System.Text;

namespace FalazAgriMart.Utils
{
    /// <summary>
    /// Helper untuk hashing dan verifikasi password
    /// CATATAN: Untuk production, gunakan BCrypt.Net-Next (NuGet)
    /// Ini versi sederhana menggunakan SHA256
    /// </summary>
    public static class PasswordHelper
    {
        /// <summary>
        /// Hash password menggunakan SHA256
        /// UNTUK DEMO SAJA - Production harus pakai BCrypt!
        /// </summary>
        public static string HashPassword(string password)
        {
            if (string.IsNullOrEmpty(password))
                throw new ArgumentException("Password tidak boleh kosong");

            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }

        /// <summary>
        /// Verify password dengan hash yang tersimpan
        /// </summary>
        public static bool VerifyPassword(string password, string hashedPassword)
        {
            if (string.IsNullOrEmpty(password) || string.IsNullOrEmpty(hashedPassword))
                return false;

            string hashInput = HashPassword(password);
            return hashInput.Equals(hashedPassword, StringComparison.OrdinalIgnoreCase);
        }

        /// <summary>
        /// Generate random password (untuk fitur reset password)
        /// </summary>
        public static string GenerateRandomPassword(int length = 8)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            Random random = new Random();
            char[] password = new char[length];

            for (int i = 0; i < length; i++)
            {
                password[i] = chars[random.Next(chars.Length)];
            }

            return new string(password);
        }

        /// <summary>
        /// Validasi kekuatan password
        /// </summary>
        public static bool IsPasswordStrong(string password)
        {
            if (string.IsNullOrEmpty(password) || password.Length < 6)
                return false;

            // Minimal 6 karakter, ada huruf dan angka
            bool hasLetter = false;
            bool hasDigit = false;

            foreach (char c in password)
            {
                if (char.IsLetter(c)) hasLetter = true;
                if (char.IsDigit(c)) hasDigit = true;
            }

            return hasLetter && hasDigit;
        }
    }
}