using System;

namespace FalazAgriMart.Models
{
    /// Abstract Base Class untuk User
    /// Menerapkan ENCAPSULATION (private fields + properties)
    /// Tidak bisa diinstansiasi langsung, harus melalui turunannya
    public abstract class User
    {
        // Private fields - ENCAPSULATION
        private int _userId;
        private string _username;
        private string _password;
        private string _namaLengkap;
        private string _role;
        private bool _status;

        // Public Properties dengan getter/setter - ENCAPSULATION
        public int UserId
        {
            get { return _userId; }
            set { _userId = value; }
        }

        public string Username
        {
            get { return _username; }
            set { _username = value; }
        }

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        public string NamaLengkap
        {
            get { return _namaLengkap; }
            set { _namaLengkap = value; }
        }

        public string Role
        {
            get { return _role; }
            set { _role = value; }
        }

        public bool Status
        {
            get { return _status; }
            set { _status = value; }
        }

        // Constructor
        protected User() { }

        protected User(int userId, string username, string password, string namaLengkap, string role, bool status)
        {
            _userId = userId;
            _username = username;
            _password = password;
            _namaLengkap = namaLengkap;
            _role = role;
            _status = status;
        }

        // Abstract method - harus diimplementasikan oleh derived class (POLYMORPHISM)
        public abstract void TampilkanInfo();

        // Virtual method - bisa di-override oleh derived class (POLYMORPHISM)
        public virtual string GetDashboardTitle()
        {
            return $"Dashboard - {NamaLengkap}";
        }
    }
}