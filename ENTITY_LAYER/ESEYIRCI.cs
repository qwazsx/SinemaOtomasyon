using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY_LAYER
{
    public class ESEYIRCI
    {
        private int _SeyirciID;
        private string _Isim;
        private bool _Ogrenci;
        private int _Yas;

        public int SeyirciID
        {
            get
            {
                return _SeyirciID;
            }

            set
            {
                _SeyirciID = value;
            }
        }

        public string Isim
        {
            get
            {
                return _Isim;
            }

            set
            {
                _Isim = value;
            }
        }

        public bool Ogrenci
        {
            get
            {
                return _Ogrenci;
            }

            set
            {
                _Ogrenci = value;
            }
        }

        public int Yas
        {
            get
            {
                return _Yas;
            }

            set
            {
                _Yas = value;
            }
        }
    }
}
