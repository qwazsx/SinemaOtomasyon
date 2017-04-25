using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITY_LAYER;
using FacadeLayer;

namespace BusinessLogicLayer
{
    public class BLLADMIN
    {
        //Login metodu.
        public static bool SINEMA_Login(String KullaniciAd, String Parola)
        {
            if (KullaniciAd != null && KullaniciAd.Trim().Length > 0 && Parola != null && Parola.Trim().Length > 0)
            {
                return FADMIN.SINEMA_Login(KullaniciAd, Parola);
            }

            else
            {
                return false;
            }
        }

        //Calisan işlemlerini yapan metotlar.
        public static int Calisan_Insert(ECALISAN item)
        {
            if ((item.KullaniciAd != null) && (item.KullaniciAd.Trim().Length > 0) && (item.Parola != null) && (item.Parola.Trim().Length > 0) && (item.Ad != null) && (item.Ad.Trim().Length > 0) && (item.Soyad != null) && (item.Soyad.Trim().Length > 0) && (item.DogumTarih != null) && (item.IseGiris != null) && (item.CalisanKategoriID > 0) && (item.TCNO != null) && (item.TCNO.Trim().Length > 0))
            {
                return FADMIN.Calisan_Insert(item);
            }

            else
            {
                return -1;
            }
        }

        public static bool Calisan_Update(ECALISAN item)
        {
            if ((item.CalisanID > 0) && (item.KullaniciAd != null) && (item.KullaniciAd.Trim().Length > 0) && (item.Parola != null) && (item.Parola.Trim().Length > 0) && (item.Ad != null) && (item.Ad.Trim().Length > 0) && (item.Soyad != null) && (item.Soyad.Trim().Length > 0) && (item.DogumTarih != null) && (item.IseGiris != null) && (item.CalisanKategoriID > 0) && (item.TCNO != null) && (item.TCNO.Trim().Length > 0))
            {
                return FADMIN.Calisan_Update(item);
            }

            else
            {
                return false;
            }
        }

        public static bool Calisan_Delete(int _CalisanID)
        {
            if (_CalisanID > 0)
            {
                return FADMIN.Calisan_Delete(_CalisanID);
            }

            else
            {
                return false;
            }
        }

        public static ECALISAN Calisan_Select(int _CalisanID)
        {
            if (_CalisanID > 0)
            {
                return FADMIN.Calisan_Select(_CalisanID);
            }

            else
            {
                return null;
            }
        }

        public static List<ECALISAN> Calisan_SelectList()
        {
            return FADMIN.Calisan_SelectList();
        }



        //CalisanKategori işlemlerini yapan metotlar.
        public static int CalisanKategori_Insert(ECALISANKATEGORI item)
        {
            if ((item.KategoriAd != null))
            {
                return FADMIN.CalisanKategori_Insert(item);
            }

            else
            {
                return -1;
            }
        }

        public static bool CalisanKategori_Update(ECALISANKATEGORI item)
        {
            if ((item.CalisanKategoriID > 0) && (item.KategoriAd != null))
            {
                return FADMIN.CalisanKategori_Update(item);
            }

            else
            {
                return false;
            }
        }

        public static bool CalisanKategori_Delete(int _CalisanKategoriID)
        {
            if (_CalisanKategoriID > 0)
            {
                return FADMIN.CalisanKategori_Delete(_CalisanKategoriID);
            }

            else
            {
                return false;
            }
        }

        public static ECALISANKATEGORI CalisanKategori_Select(int _CalisanKategoriID)
        {
            if (_CalisanKategoriID > 0)
            {
                return FADMIN.CalisanKategori_Select(_CalisanKategoriID);
            }

            else
            {
                return null;
            }
        }

        public static List<ECALISANKATEGORI> CalisanKategori_SelectList()
        {
            return FADMIN.CalisanKategori_SelectList();
        }


        //Film işlemlerini yapan metotlar.
        public static int Film_Insert(EFILM item)
        {
            if ((item.KategoriID > 0) && (item.FilmAd != null) && (item.FilmAd.Trim().Length > 0) && (item.Yapimci != null) && (item.Yapimci.Trim().Length > 0) && (item.YayinTarih != null) && (item.Sure > 0))
            {
                return FADMIN.Film_Insert(item);
            }

            else
            {
                return -1;
            }
        }

        public static bool Film_Update(EFILM item)
        {
            if ((item.FilmID > 0)&& (item.KategoriID > 0) && (item.FilmAd != null) && (item.FilmAd.Trim().Length > 0) && (item.Yapimci != null) && (item.Yapimci.Trim().Length > 0) && (item.YayinTarih != null) && (item.Sure > 0))
            {
                return FADMIN.Film_Update(item);
            }

            else
            {
                return false;
            }
        }

        public static bool Film_Delete(int _FilmID)
        {
            if (_FilmID > 0)
            {
                return FADMIN.Film_Delete(_FilmID);
            }

            else
            {
                return false;
            }
        }

        public static EFILM Film_Select(int _FilmID)
        {
            if (_FilmID > 0)
            {
                return FADMIN.Film_Select(_FilmID);
            }

            else
            {
                return null;
            }
        }

        public static List<EFILM> Film_SelectList()
        {
            return FADMIN.Film_SelectList();
        }


        //FilmKategori işlemlerini yapan metotlar.
        public static int FilmKategori_Insert(EFILMKATEGORI item)
        {
            if ((item.KategoriAd != null) && (item.KategoriAd.Trim().Length > 0))
            {
                return FADMIN.FilmKategori_Insert(item);
            }

            else
            {
                return -1;
            }
        }

        public static bool FilmKategori_Update(EFILMKATEGORI item)
        {
            if ((item.KategoriID > 0) && (item.KategoriAd != null) && (item.KategoriAd.Trim().Length > 0))
            {
                return FADMIN.FilmKategori_Update(item);
            }

            else
            {
                return false;
            }
        }

        public static bool FilmKategori_Delete(int _FilmKategoriID)
        {
            if (_FilmKategoriID > 0)
            {
                return FADMIN.FilmKategori_Delete(_FilmKategoriID);
            }

            else
            {
                return false;
            }
        }

        public static EFILMKATEGORI FilmKategori_Select(int _FilmKategoriID)
        {
            if (_FilmKategoriID > 0)
            {
                return FADMIN.FilmKategori_Select(_FilmKategoriID);
            }

            else
            {
                return null;
            }
        }

        public static List<EFILMKATEGORI> FilmKategori_SelectList()
        {
            return FADMIN.FilmKategori_SelectList();
        }


        //Salon işlemlerini yapan metotlar.
        public static int Salon_Insert(ESALON item)
        {
            if ((item.SalonAd != null) && (item.SalonAd.Trim().Length > 0) && (item.Kapasite > 0))
            {
                return FADMIN.Salon_Insert(item);
            }

            else
            {
                return -1;
            }
        }

        public static bool Salon_Update(ESALON item)
        {
            if ((item.SalonID > 0) && (item.SalonAd != null) && (item.SalonAd.Trim().Length > 0) && (item.Kapasite > 0))
            {
                return FADMIN.Salon_Update(item);
            }

            else
            {
                return false;
            }
        }

        public static bool Salon_Delete(int _SalonID)
        {
            if (_SalonID > 0)
            {
                return FADMIN.Salon_Delete(_SalonID);
            }

            else
            {
                return false;
            }
        }

        public static ESALON Salon_Select(int _SalonID)
        {
            if (_SalonID > 0)
            {
                return FADMIN.Salon_Select(_SalonID);
            }

            else
            {
                return null;
            }
        }

        public static List<ESALON> Salon_SelectList()
        {
            return FADMIN.Salon_SelectList();
        }


        //Seans işlemlerini yapan metotlar.
        public static int Senas_Insert(ESEANS item)
        {
            if ((item.SeansNo > 0) && (item.FilmID > 0) && (item.SalonID > 0) && (item.Tarih != null))
            {
                return FADMIN.Seans_Insert(item);
            }

            else
            {
                return -1;
            }
        }

        public static bool Seans_Update(ESEANS item)
        {
            if ((item.SeansID > 0) && (item.SeansNo > 0) && (item.FilmID > 0) && (item.SalonID > 0) && (item.Tarih != null))
            {
                return FADMIN.Seans_Update(item);
            }

            else
            {
                return false;
            }
        }

        public static bool Seans_Delete(int _SeansID)
        {
            if (_SeansID > 0)
            {
                return FADMIN.Seans_Delete(_SeansID);
            }

            else
            {
                return false;
            }
        }

        public static ESEANS Senas_Select(int _SeansID)
        {
            if (_SeansID > 0)
            {
                return FADMIN.Seans_Select(_SeansID);
            }

            else
            {
                return null;
            }
        }

        public static List<ESEANS> Seans_SelectList()
        {
            return FADMIN.Seans_SelectList();
        }



        //Seyirci işlemlerini yapan metotlar.
        public static int Seyirci_Insert(ESEYIRCI item)
        {
            if ((item.Isim != null) && (item.Isim.Trim().Length > 0))
            {
                return FADMIN.Seyirci_Insert(item);
            }

            else
            {
                return -1;
            }
        }

        public static bool Seyirci_Update(ESEYIRCI item)
        {
            if ((item.SeyirciID > 0) && (item.Isim != null) && (item.Isim.Trim().Length > 0))
            {
                return FADMIN.Seyirci_Update(item);
            }

            else
            {
                return false;
            }
        }

        public static bool Seyirci_Delete(int _SeyirciID)
        {
            if (_SeyirciID > 0)
            {
                return FADMIN.Seyirci_Delete(_SeyirciID);
            }

            else
            {
                return false;
            }
        }

        public static ESEYIRCI Seyirci_Select(int _SeyirciID)
        {
            if (_SeyirciID > 0)
            {
                return FADMIN.Seyirci_Select(_SeyirciID);
            }

            else
            {
                return null;
            }
        }

        public static List<ESEYIRCI> Seyirci_SelectList()
        {
            return FADMIN.Seyirci_SelectList();
        }
    }
}
