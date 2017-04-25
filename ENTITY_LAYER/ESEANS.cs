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

        public string SeansNo
        {
            get { return _SeansNo; }
            set { _SeansNo = value; }
        }
        private int _FilmID;
        private int _SalonID;
        private DateTime _Tarih;
        private bool _Active;

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

        public DateTime Tarih
        {
            get
            {
                return _Tarih;
            }

            set
            {
                _Tarih = value;
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
