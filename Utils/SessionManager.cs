using System;
// TAMBAHKAN ALIAS:
using UserModel = FalazAgriMart.Models.User;

namespace FalazAgriMart.Utils
{
    public sealed class SessionManager
    {
        private static SessionManager _instance = null;
        private static readonly object _lock = new object();

        // GUNAKAN ALIAS
        private UserModel _currentUser;
        private DateTime _loginTime;

        private SessionManager() { }

        public static SessionManager Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_lock)
                    {
                        if (_instance == null)
                        {
                            _instance = new SessionManager();
                        }
                    }
                }
                return _instance;
            }
        }

        // GUNAKAN ALIAS untuk parameter
        public void SetUser(UserModel user)
        {
            _currentUser = user;
            _loginTime = DateTime.Now;
        }

        // GUNAKAN ALIAS untuk return type
        public UserModel GetCurrentUser()
        {
            return _currentUser;
        }

        public bool IsLoggedIn()
        {
            return _currentUser != null;
        }

        public bool IsAdmin()
        {
            return _currentUser != null && _currentUser.Role == "Admin";
        }

        public bool IsPegawai()
        {
            return _currentUser != null && _currentUser.Role == "Pegawai";
        }

        public DateTime GetLoginTime()
        {
            return _loginTime;
        }

        public void ClearSession()
        {
            _currentUser = null;
            _loginTime = DateTime.MinValue;
        }

        public string GetNamaLengkap()
        {
            return _currentUser?.NamaLengkap ?? "Guest";
        }

        public string GetUsername()
        {
            return _currentUser?.Username ?? "guest";
        }

        public int GetUserId()
        {
            return _currentUser?.UserId ?? 0;
        }

        public string GetRole()
        {
            return _currentUser?.Role ?? "Unknown";
        }
    }
}