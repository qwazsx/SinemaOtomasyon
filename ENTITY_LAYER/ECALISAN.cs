using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY_LAYER
{
   public class ECALISAN
    {
        private int _CalisanID;
        private String _KullaniciAd;
        private string _Parola;
        private string _Ad;
        private string _Soyad;
        private DateTime _DogumTarih;
        private DateTime _IseGiris;
        private int _CalisanKategoriID;
        private string _TCNO;

        public int CalisanID
        {
            get
            {
                return _CalisanID;
            }

            set
            {
                _CalisanID = value;
            }
        }

        public string KullaniciAd
        {
            get
            {
                return _KullaniciAd;
            }

            set
            {
                _KullaniciAd = value;
            }
        }

        public string Parola
        {
            get
            {
                return _Parola;
            }

            set
            {
                _Parola = value;
            }
        }

        public string Ad
        {
            get
            {
                return _Ad;
            }

            set
            {
                _Ad = value;
            }
        }

        public string Soyad
        {
            get
            {
                return _Soyad;
            }

            set
            {
                _Soyad = value;
            }
        }

        public DateTime DogumTarih
        {
            get
            {
                return _DogumTarih;
            }

            set
            {
                _DogumTarih = value;
            }
        }

        public int CalisanKategoriID
        {
            get
            {
                return _CalisanKategoriID;
            }

            set
            {
                _CalisanKategoriID = value;
            }
        }

        public DateTime IseGiris
        {
            get
            {
                return _IseGiris;
            }

            set
            {
                _IseGiris = value;
            }
        }

        public string TCNO
        {
            get
            {
                return _TCNO;
            }

            set
            {
                _TCNO = value;
            }
        }
    }
}
