using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FalazAgriMart.Utils
{
    internal class AlertHelper
    {
        // Menampilkan pesan sukses
        public static void ShowSuccess(string message, string title = "Sukses")
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Menampilkan pesan error
        public static void ShowError(string message, string title = "Error")
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        // Menampilkan pesan warning
        public static void ShowWarning(string message, string title = "Peringatan")
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        // Menampilkan pesan informasi
        public static void ShowInfo(string message, string title = "Informasi")
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Menampilkan konfirmasi Yes/No
        public static bool ShowConfirmation(string message, string title = "Konfirmasi")
        {
            DialogResult result = MessageBox.Show(message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            return result == DialogResult.Yes;
        }

        // Menampilkan konfirmasi Yes/No/Cancel
        public static DialogResult ShowConfirmationYesNoCancel(string message, string title = "Konfirmasi")
        {
            return MessageBox.Show(message, title, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
        }

        // Validasi input kosong
        public static bool ValidateNotEmpty(string value, string fieldName)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                ShowWarning($"{fieldName} tidak boleh kosong!", "Validasi");
                return false;
            }
            return true;
        }

        // Validasi input numerik
        public static bool ValidateNumeric(string value, string fieldName)
        {
            if (!decimal.TryParse(value, out decimal result))
            {
                ShowWarning($"{fieldName} harus berupa angka!", "Validasi");
                return false;
            }
            return true;
        }

        // Validasi input positif
        public static bool ValidatePositive(decimal value, string fieldName)
        {
            if (value <= 0)
            {
                ShowWarning($"{fieldName} harus lebih dari 0!", "Validasi");
                return false;
            }
            return true;
        }

        // Validasi stok mencukupi
        public static bool ValidateStock(int requested, int available, string productName)
        {
            if (requested > available)
            {
                ShowWarning($"Stok {productName} tidak mencukupi!\nStok tersedia: {available}", "Stok Tidak Cukup");
                return false;
            }
            return true;
        }

        // Menampilkan pesan untuk operasi database
        public static void ShowDatabaseError(string operation)
        {
            ShowError($"Gagal melakukan {operation}. Silakan coba lagi.", "Database Error");
        }

        // Menampilkan konfirmasi hapus
        public static bool ConfirmDelete(string itemName)
        {
            return ShowConfirmation($"Apakah Anda yakin ingin menghapus {itemName}?", "Konfirmasi Hapus");
        }

        // Menampilkan konfirmasi logout
        public static bool ConfirmLogout()
        {
            return ShowConfirmation("Apakah Anda yakin ingin keluar dari aplikasi?", "Konfirmasi Logout");
        }
    }
}