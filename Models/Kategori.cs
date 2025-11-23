namespace FalazAgriMart.Models
{
    public class Kategori
    {
        private int _kategoriId;
        private string _namaKategori;
        private string _deskripsi;
        private bool _status;

        public int KategoriId
        {
            get { return _kategoriId; }
            set { _kategoriId = value; }
        }

        public string NamaKategori
        {
            get { return _namaKategori; }
            set { _namaKategori = value; }
        }

        public string Deskripsi
        {
            get { return _deskripsi; }
            set { _deskripsi = value; }
        }

        public bool Status
        {
            get { return _status; }
            set { _status = value; }
        }

        public Kategori() { }

        public Kategori(int kategoriId, string namaKategori, string deskripsi, bool status)
        {
            _kategoriId = kategoriId;
            _namaKategori = namaKategori;
            _deskripsi = deskripsi;
            _status = status;
        }
    }
}