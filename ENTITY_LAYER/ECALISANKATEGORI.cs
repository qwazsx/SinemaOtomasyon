using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY_LAYER
{
   public class ECALISANKATEGORI
    {
        private int _CalisanKategoriID;
        private String _KategoriAd;
        private bool _BiletYetki;
        private bool _AdminYetki;

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

        public bool BiletYetki
        {
            get
            {
                return _BiletYetki;
            }

            set
            {
                _BiletYetki = value;
            }
        }

        public bool AdminYetki
        {
            get
            {
                return _AdminYetki;
            }

            set
            {
                _AdminYetki = value;
            }
        }
    }
}
