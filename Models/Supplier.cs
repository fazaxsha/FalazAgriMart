namespace FalazAgriMart.Models
{
    public class Supplier
    {
        private int _supplierId;
        private string _namaSupplier;
        private string _alamat;
        private string _noTelp;
        private string _email;
        private bool _status;

        public int SupplierId
        {
            get { return _supplierId; }
            set { _supplierId = value; }
        }

        public string NamaSupplier
        {
            get { return _namaSupplier; }
            set { _namaSupplier = value; }
        }

        public string Alamat
        {
            get { return _alamat; }
            set { _alamat = value; }
        }

        public string NoTelp
        {
            get { return _noTelp; }
            set { _noTelp = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public bool Status
        {
            get { return _status; }
            set { _status = value; }
        }

        public Supplier() { }

        public Supplier(int supplierId, string namaSupplier, string alamat, string noTelp, string email, bool status)
        {
            _supplierId = supplierId;
            _namaSupplier = namaSupplier;
            _alamat = alamat;
            _noTelp = noTelp;
            _email = email;
            _status = status;
        }
    }
}