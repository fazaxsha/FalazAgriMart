using System;
using System.Text.RegularExpressions;

namespace FalazAgriMart.Utils
{
    /// Helper untuk validasi input
    public static class ValidationHelper
    {
        /// Validasi input tidak boleh kosong
        public static bool IsNotEmpty(string input, string fieldName, out string errorMessage)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                errorMessage = $"{fieldName} tidak boleh kosong!";
                return false;
            }
            errorMessage = string.Empty;
            return true;
        }

        /// Validasi email format
        public static bool IsValidEmail(string email, out string errorMessage)
        {
            if (string.IsNullOrWhiteSpace(email))
            {
                errorMessage = "Email tidak boleh kosong!";
                return false;
            }

            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            if (!Regex.IsMatch(email, pattern))
            {
                errorMessage = "Format email tidak valid!";
                return false;
            }

            errorMessage = string.Empty;
            return true;
        }

        /// Validasi nomor telepon (Indonesia)
        public static bool IsValidPhoneNumber(string phone, out string errorMessage)
        {
            if (string.IsNullOrWhiteSpace(phone))
            {
                errorMessage = "Nomor telepon tidak boleh kosong!";
                return false;
            }

            // Format: 08xx atau 62xx (minimal 10 digit)
            string pattern = @"^(08|62)\d{8,13}$";
            if (!Regex.IsMatch(phone.Replace("-", "").Replace(" ", ""), pattern))
            {
                errorMessage = "Format nomor telepon tidak valid!";
                return false;
            }

            errorMessage = string.Empty;
            return true;
        }

        /// Validasi input numerik
        public static bool IsValidNumber(string input, string fieldName, out decimal number, out string errorMessage)
        {
            if (!decimal.TryParse(input, out number))
            {
                errorMessage = $"{fieldName} harus berupa angka!";
                return false;
            }

            if (number < 0)
            {
                errorMessage = $"{fieldName} tidak boleh negatif!";
                return false;
            }

            errorMessage = string.Empty;
            return true;
        }

        /// Validasi input integer
        public static bool IsValidInteger(string input, string fieldName, out int number, out string errorMessage)
        {
            if (!int.TryParse(input, out number))
            {
                errorMessage = $"{fieldName} harus berupa angka bulat!";
                return false;
            }

            if (number < 0)
            {
                errorMessage = $"{fieldName} tidak boleh negatif!";
                return false;
            }

            errorMessage = string.Empty;
            return true;
        }

        /// Validasi panjang karakter
        public static bool IsValidLength(string input, string fieldName, int minLength, int maxLength, out string errorMessage)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                errorMessage = $"{fieldName} tidak boleh kosong!";
                return false;
            }

            if (input.Length < minLength || input.Length > maxLength)
            {
                errorMessage = $"{fieldName} harus antara {minLength}-{maxLength} karakter!";
                return false;
            }

            errorMessage = string.Empty;
            return true;
        }
    }
}