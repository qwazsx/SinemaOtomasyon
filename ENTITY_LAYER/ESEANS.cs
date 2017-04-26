using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY_LAYER
{
   public class ESEANS
    {
        private int _SeansID;
        private string _SeansNo;
        private string _FilmAd;
        private string _SalonAd;

        public string SalonAd
        {
            get { return _SalonAd; }
            set { _SalonAd = value; }
        }

        public string FilmAd1
        {
            get { return _FilmAd; }
            set { _FilmAd = value; }
        }

        public string FilmAd
        {
            get { return _FilmAd; }
            set { _FilmAd = value; }
        }
        
        
        public int SeansID
        {
            get
            {
                return _SeansID;
            }

            set
            {
                _SeansID = value;
            }
        }

       public string SeansNo
        {
            get { return _SeansNo; }
            set { _SeansNo = value; }
        }


       
        
    }
}
