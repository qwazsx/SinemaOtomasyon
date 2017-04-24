using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY_LAYER
{
   public class EKOLTUK
    {
        private int _KoltukID;
        private int _SeyirciID;
        private int _SalonID;

        public int KoltukID
        {
            get
            {
                return _KoltukID;
            }

            set
            {
                _KoltukID = value;
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
