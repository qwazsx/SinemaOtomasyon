using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY_LAYER
{
   public class ESALON
    {
        private int _SalonID;
        private int _Kapasite;
        private string _SalonAd;

        public int Kapasite
        {
            get
            {
                return _Kapasite;
            }

            set
            {
                _Kapasite = value;
            }
        }

        public int SalonID
        {
            get
            {
                return _SalonID;
            }

            set
            {
                _SalonID = value;
            }
        }

        public string SalonAd
        {
            get
            {
                return _SalonAd;
            }

            set
            {
                _SalonAd = value;
            }
        }
    }
}
