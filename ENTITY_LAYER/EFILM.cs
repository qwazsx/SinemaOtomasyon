using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY_LAYER
{
    public class EFILM
    {
        private int _FilmID;
        private int _KategoriID;
        private String _FilmAd;
        private string _Yapimci;
        private DateTime _YayinTarih;
        private int _Sure;
        private bool _Active;

        public int FilmID
        {
            get
            {
                return _FilmID;
            }

            set
            {
                _FilmID = value;
            }
        }

        public int KategoriID
        {
            get
            {
                return _KategoriID;
            }

            set
            {
                _KategoriID = value;
            }
        }

        public string FilmAd
        {
            get
            {
                return _FilmAd;
            }

            set
            {
                _FilmAd = value;
            }
        }

        public string Yapimci
        {
            get
            {
                return _Yapimci;
            }

            set
            {
                _Yapimci = value;
            }
        }

        public DateTime YayinTarih
        {
            get
            {
                return _YayinTarih;
            }

            set
            {
                _YayinTarih = value;
            }
        }

        public int Sure
        {
            get
            {
                return _Sure;
            }

            set
            {
                _Sure = value;
            }
        }

        public bool Active
        {
            get
            {
                return _Active;
            }

            set
            {
                _Active = value;
            }
        }
    }
}
