using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY_LAYER
{
    public class EBILET
    {
        private int _BiletID;
        private int _SeyirciID;
        private int _SeansID;
        private decimal _Ucret;
        private int _BiletAdedi;
        private int _SalonID;
        private int _Yas;

        public int BiletID
        {
            get
            {
                return _BiletID;
            }

            set
            {
                _BiletID = value;
            }
        }

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

        public decimal Ucret
        {
            get
            {
                return _Ucret;
            }

            set
            {
                _Ucret = value;
            }
        }

        public int BiletAdedi
        {
            get
            {
                return _BiletAdedi;
            }

            set
            {
                _BiletAdedi = value;
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
    }
}
