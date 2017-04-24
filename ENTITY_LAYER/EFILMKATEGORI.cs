using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY_LAYER
{
    public class EFILMKATEGORI
    {
        private int _KategoriID;
        private String _KategoriAd;
        private bool _GenelIzleyici;

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

        public string KategoriAd
        {
            get
            {
                return _KategoriAd;
            }

            set
            {
                _KategoriAd = value;
            }
        }

        public bool GenelIzleyici
        {
            get
            {
                return _GenelIzleyici;
            }

            set
            {
                _GenelIzleyici = value;
            }
        }
    }
}
