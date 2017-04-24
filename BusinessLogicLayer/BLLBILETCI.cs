using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITY_LAYER;
using FacadeLayer;

namespace BusinessLogicLayer
{
    public class BLLBILETCI
    {

        public static int Bilet_Insert(EBILET item)
        {
            if ((item.SeyirciID > 0) && (item.SeansID > 0) && (item.Ucret > 0) && (item.BiletAdedi > 0) && (item.SalonID > 0))
            {
                return FBILETCI.Bilet_Insert(item);
            }

            else
            {
                return -1;
            }
        }

        public static bool Bilet_Update(EBILET item)
        {
            if ((item.BiletID > 0) && (item.SeyirciID > 0) && (item.SeansID > 0) && (item.Ucret > 0) && (item.BiletAdedi > 0) && (item.SalonID > 0))
            {
                return FBILETCI.Bilet_Update(item);
            }

            else
            {
                return false;
            }
        }

        public static bool Bilet_Delete(int _BiletID)
        {
            if (_BiletID > 0)
            {
                return FBILETCI.Bilet_Delete(_BiletID);
            }

            else
            {
                return false;
            }
        }

        public static EBILET Bilet_Select(int _BiletID)
        {
            if (_BiletID > 0)
            {
                return FBILETCI.Bilet_Select(_BiletID);
            }

            else
            {
                return null;
            }
        }

        public static List<EBILET> Bilet_SelectList()
        {
            return FBILETCI.Bilet_SelectList();
        }
    }
}
