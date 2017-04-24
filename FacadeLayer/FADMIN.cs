using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using ENTITY_LAYER;


namespace FacadeLayer
{
   public class FADMIN
    {
        //Login metodu.
        public static bool SINEMA_Login(String KullaniciAd,String Parola)
        {
            bool sonuc;

            try
            {
                SqlCommand com = new SqlCommand("SINEMA_Login", FBAGLANTI.Baglan);
                com.CommandType = CommandType.StoredProcedure;
                if (com.Connection.State != ConnectionState.Open)
                {
                    com.Connection.Open();
                }
                com.Parameters.AddWithValue("KullaniciAd", KullaniciAd);
                com.Parameters.AddWithValue("Parola", Parola);
                SqlDataAdapter adapter = new SqlDataAdapter(com);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                sonuc = ds.Tables[0].Rows.Count > 0;
                com.Dispose();
                adapter.Dispose();
                ds.Dispose();
                FBAGLANTI.Baglan.Close();
                FBAGLANTI.Baglan.Dispose();
               
            }
            catch
            {
                sonuc = false;
            }

            return sonuc;
        }

        //Calisan işlemlerini yapan metotlar.
        public static int Calisan_Insert(ECALISAN item)
        {
            int sonuc;

            try
            {
                SqlCommand com = new SqlCommand("Calisan_Insert", FBAGLANTI.Baglan);
                com.CommandType = CommandType.StoredProcedure;
                if (com.Connection.State != ConnectionState.Open)
                {
                    com.Connection.Open();
                }
                com.Parameters.AddWithValue("KullaniciAd", item.KullaniciAd);
                com.Parameters.AddWithValue("Parola", item.Parola);
                com.Parameters.AddWithValue("Ad", item.Ad);
                com.Parameters.AddWithValue("Soyad", item.Soyad);
                com.Parameters.AddWithValue("DogumTarih", item.DogumTarih);
                com.Parameters.AddWithValue("IseGiris", item.IseGiris);
                com.Parameters.AddWithValue("TCNO", item.TCNO);
                com.Parameters.AddWithValue("CalisanKategoriID", item.CalisanKategoriID);

                sonuc = com.ExecuteNonQuery();
                com.Dispose();
                FBAGLANTI.Baglan.Close();
                FBAGLANTI.Baglan.Dispose();
            }
            catch
            {
                sonuc = -1;
            }

            return sonuc;
        }

        public static bool Calisan_Update(ECALISAN item)
        {
            bool sonuc = false;

            try
            {
                SqlCommand com = new SqlCommand("Calisan_Update", FBAGLANTI.Baglan);
                com.CommandType = CommandType.StoredProcedure;
                if (com.Connection.State != ConnectionState.Open)
                {
                    com.Connection.Open();
                }

                com.Parameters.AddWithValue("CalisanID", item.CalisanID);
                com.Parameters.AddWithValue("KullaniciAd", item.KullaniciAd);
                com.Parameters.AddWithValue("Parola", item.Parola);
                com.Parameters.AddWithValue("Ad", item.Ad);
                com.Parameters.AddWithValue("Soyad", item.Soyad);
                com.Parameters.AddWithValue("DogumTarih", item.DogumTarih);
                com.Parameters.AddWithValue("IseGiris", item.IseGiris);
                com.Parameters.AddWithValue("TCNO", item.TCNO);
                com.Parameters.AddWithValue("CalisanKategoriID", item.CalisanKategoriID);

                sonuc = com.ExecuteNonQuery() > 0;
                com.Dispose();
                FBAGLANTI.Baglan.Close();
                FBAGLANTI.Baglan.Dispose();
            }
            catch 
            {
                sonuc = false;
            }

            return sonuc;
        }

        public static bool Calisan_Delete(int _CalisanID)
        {
            bool sonuc = false;

            try
            {
                SqlCommand com = new SqlCommand("Calisan_Delete", FBAGLANTI.Baglan);
                com.CommandType = CommandType.StoredProcedure;
                if (com.Connection.State != ConnectionState.Open)
                {
                    com.Connection.Open();
                }

                com.Parameters.AddWithValue("CalisanID", _CalisanID);
                sonuc = com.ExecuteNonQuery() > 0;
                com.Dispose();
                FBAGLANTI.Baglan.Close();
                FBAGLANTI.Baglan.Dispose();
            }
            catch 
            {
                sonuc = false;
            }

            return sonuc;
        }

        public static ECALISAN Calisan_Select(int _CalisanID)
        {
            ECALISAN item = new ECALISAN();

            try
            {
                SqlCommand com = new SqlCommand("Calisan_Select", FBAGLANTI.Baglan);
                com.CommandType = CommandType.StoredProcedure;
                if (com.Connection.State != ConnectionState.Open)
                {
                    com.Connection.Open();
                }
                com.Parameters.AddWithValue("CalisanID", _CalisanID);
                SqlDataReader dr = com.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        item.CalisanID = Convert.ToInt32(dr["CalisanID"]);
                        item.KullaniciAd = dr["KullaniciAd"].ToString();
                        item.Parola = dr["Parola"].ToString();
                        item.Ad = dr["Ad"].ToString();
                        item.Soyad = dr["Soyad"].ToString();
                        item.DogumTarih = Convert.ToDateTime(dr["DogumTarih"]);
                        item.IseGiris = Convert.ToDateTime(dr["IseGiris"]);
                        item.CalisanKategoriID = Convert.ToInt32(dr["CalisanKategoriID"]);
                        item.TCNO = dr["TCNO"].ToString();
                    }
                }
                com.Dispose();
                dr.Close();
                FBAGLANTI.Baglan.Close();
                FBAGLANTI.Baglan.Dispose();
            }
            catch
            {
                item = null;
            }

            return item;
        }

        public static List<ECALISAN> Calisan_SelectList()
        {
            List<ECALISAN> itemlist = new List<ECALISAN>();

            try
            {
                SqlCommand com = new SqlCommand("Calisan_SelectList", FBAGLANTI.Baglan);
                com.CommandType = CommandType.StoredProcedure;
                if (com.Connection.State != ConnectionState.Open)
                {
                    com.Connection.Open();
                }
                SqlDataReader dr = com.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        ECALISAN item = new ECALISAN();

                        item.CalisanID = Convert.ToInt32(dr["CalisanID"]);
                        item.KullaniciAd = dr["KullaniciAd"].ToString();
                        item.Parola = dr["Parola"].ToString();
                        item.Ad = dr["Ad"].ToString();
                        item.Soyad = dr["Soyad"].ToString();
                        item.DogumTarih = Convert.ToDateTime(dr["DogumTarih"]);
                        item.IseGiris = Convert.ToDateTime(dr["IseGiris"]);
                        item.CalisanKategoriID = Convert.ToInt32(dr["CalisanKategoriID"]);
                        item.TCNO = dr["TCNO"].ToString();
                        itemlist.Add(item);
                    }
                }

                com.Dispose();
                dr.Close();
                FBAGLANTI.Baglan.Close();
                FBAGLANTI.Baglan.Dispose();
            }
            catch 
            {
                itemlist = null;
            }

            return itemlist;
        }

        //CalisanKategori işlemlerini yapan metotlar.
        public static int CalisanKategori_Insert(ECALISANKATEGORI item)
        {
            int sonuc;

            try
            {
                SqlCommand com = new SqlCommand("CalisanKategori_Insert", FBAGLANTI.Baglan);
                com.CommandType = CommandType.StoredProcedure;
                if (com.Connection.State != ConnectionState.Open)
                {
                    com.Connection.Open();
                }
                com.Parameters.AddWithValue("KategoriAd", item.KategoriAd);
                com.Parameters.AddWithValue("BiletYetki", item.BiletYetki);
                com.Parameters.AddWithValue("AdminYetki", item.AdminYetki);
                sonuc = com.ExecuteNonQuery();
                com.Dispose();
                FBAGLANTI.Baglan.Close();
                FBAGLANTI.Baglan.Dispose();
            }
            catch
            {
                sonuc = -1;
            }

            return sonuc;
        }

        public static bool CalisanKategori_Update(ECALISANKATEGORI item)
        {
            bool sonuc = false;

            try
            {
                SqlCommand com = new SqlCommand("CalisanKategori_Update", FBAGLANTI.Baglan);
                com.CommandType = CommandType.StoredProcedure;
                if (com.Connection.State != ConnectionState.Open)
                {
                    com.Connection.Open();
                }
                com.Parameters.AddWithValue("CalisanKategoriID", item.CalisanKategoriID);
                com.Parameters.AddWithValue("KategoriAd", item.KategoriAd);
                com.Parameters.AddWithValue("BiletYetki", item.BiletYetki);
                com.Parameters.AddWithValue("AdminYetki", item.AdminYetki);
                sonuc = com.ExecuteNonQuery() > 0;
                com.Dispose();
                FBAGLANTI.Baglan.Close();
                FBAGLANTI.Baglan.Dispose();
            }
            catch
            {
                sonuc = false;
            }

            return sonuc;
        }

        public static bool CalisanKategori_Delete(int _CalisanKategoriID)
        {
            bool sonuc = false;

            try
            {
                SqlCommand com = new SqlCommand("CalisanKategori_Delete", FBAGLANTI.Baglan);
                com.CommandType = CommandType.StoredProcedure;
                if (com.Connection.State != ConnectionState.Open)
                {
                    com.Connection.Open();
                }

                com.Parameters.AddWithValue("CalisanKategoriID", _CalisanKategoriID);
                sonuc = com.ExecuteNonQuery() > 0;
                com.Dispose();
                FBAGLANTI.Baglan.Close();
                FBAGLANTI.Baglan.Dispose();
            }
            catch
            {
                sonuc = false;
            }

            return sonuc;
        }

        public static ECALISANKATEGORI CalisanKategori_Select(int _CalisanKategoriID)
        {
            ECALISANKATEGORI item = new ECALISANKATEGORI();

            try
            {
                SqlCommand com = new SqlCommand("CalisanKategori_Select", FBAGLANTI.Baglan);
                com.CommandType = CommandType.StoredProcedure;
                if (com.Connection.State != ConnectionState.Open)
                {
                    com.Connection.Open();
                }
                com.Parameters.AddWithValue("CalisanKategoriID", _CalisanKategoriID);
                SqlDataReader dr = com.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        item.CalisanKategoriID = Convert.ToInt32(dr["CalisanKategoriID"]);
                        item.KategoriAd = dr["KategoriAd"].ToString();
                        item.BiletYetki = Convert.ToBoolean(dr["BiletYetki"]);
                        item.AdminYetki = Convert.ToBoolean(dr["AdminYetki"]);
                    }
                }
                com.Dispose();
                dr.Close();
                FBAGLANTI.Baglan.Close();
                FBAGLANTI.Baglan.Dispose();
            }
            catch
            {
                item = null;
            }

            return item;
        }

        public static List<ECALISANKATEGORI> CalisanKategori_SelectList()
        {
            List<ECALISANKATEGORI> itemlist = new List<ECALISANKATEGORI>();

            try
            {
                SqlCommand com = new SqlCommand("CalisanKategori_SelectList", FBAGLANTI.Baglan);
                com.CommandType = CommandType.StoredProcedure;
                if (com.Connection.State != ConnectionState.Open)
                {
                    com.Connection.Open();
                }
                SqlDataReader dr = com.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        ECALISANKATEGORI item = new ECALISANKATEGORI();

                        item.CalisanKategoriID = Convert.ToInt32(dr["CalisanKategoriID"]);
                        item.KategoriAd = dr["KategoriAd"].ToString();
                        item.BiletYetki = Convert.ToBoolean(dr["BiletYetki"]);
                        item.AdminYetki = Convert.ToBoolean(dr["AdminYetki"]);
                        itemlist.Add(item);
                    }
                }
                com.Dispose();
                dr.Close();
                FBAGLANTI.Baglan.Close();
                FBAGLANTI.Baglan.Dispose();
            }
            catch
            {
                itemlist = null;
            }

            return itemlist;
        }


        //Film işlemlerini yapan metotlar.
        public static int Film_Insert(EFILM item)
        {
            int sonuc;

            try
            {
                SqlCommand com = new SqlCommand("Film_Insert", FBAGLANTI.Baglan);
                com.CommandType = CommandType.StoredProcedure;
                if (com.Connection.State != ConnectionState.Open)
                {
                    com.Connection.Open();
                }
                com.Parameters.AddWithValue("KategoriID", item.KategoriID);
                com.Parameters.AddWithValue("FilmAd", item.FilmAd);
                com.Parameters.AddWithValue("Yapimci", item.Yapimci);
                com.Parameters.AddWithValue("YayinTarih", item.YayinTarih);
                com.Parameters.AddWithValue("Sure", item.Sure);
                com.Parameters.AddWithValue("Active", item.Active);
                sonuc = com.ExecuteNonQuery();
                com.Dispose();
                FBAGLANTI.Baglan.Close();
                FBAGLANTI.Baglan.Dispose();
            }
            catch
            {
                sonuc = -1;
            }

            return sonuc;
        }

        public static bool Film_Update(EFILM item)
        {
            bool sonuc = false;

            try
            {
                SqlCommand com = new SqlCommand("Film_Update", FBAGLANTI.Baglan);
                com.CommandType = CommandType.StoredProcedure;
                if (com.Connection.State != ConnectionState.Open)
                {
                    com.Connection.Open();
                }
                com.Parameters.AddWithValue("FilmID", item.FilmID);
                com.Parameters.AddWithValue("KategoriID", item.KategoriID);
                com.Parameters.AddWithValue("FilmAd", item.FilmAd);
                com.Parameters.AddWithValue("Yapimci", item.Yapimci);
                com.Parameters.AddWithValue("YayinTarih", item.YayinTarih);
                com.Parameters.AddWithValue("Sure", item.Sure);
                com.Parameters.AddWithValue("Active", item.Active);
                sonuc = com.ExecuteNonQuery() > 0;
                com.Dispose();
                FBAGLANTI.Baglan.Close();
                FBAGLANTI.Baglan.Dispose();
            }
            catch
            {
                sonuc = false;
            }

            return sonuc;
        }

        public static bool Film_Delete(int _FilmID)
        {
            bool sonuc = false;

            try
            {
                SqlCommand com = new SqlCommand("Film_Delete", FBAGLANTI.Baglan);
                com.CommandType = CommandType.StoredProcedure;
                if (com.Connection.State != ConnectionState.Open)
                {
                    com.Connection.Open();
                }

                com.Parameters.AddWithValue("FilmID", _FilmID);
                sonuc = com.ExecuteNonQuery() > 0;
                com.Dispose();
                FBAGLANTI.Baglan.Close();
                FBAGLANTI.Baglan.Dispose();
            }
            catch
            {
                sonuc = false;
            }

            return sonuc;
        }

        public static EFILM Film_Select(int _FilmID)
        {
            EFILM item = new EFILM();

            try
            {
                SqlCommand com = new SqlCommand("Film_Select", FBAGLANTI.Baglan);
                com.CommandType = CommandType.StoredProcedure;
                if (com.Connection.State != ConnectionState.Open)
                {
                    com.Connection.Open();
                }
                com.Parameters.AddWithValue("FilmID", _FilmID);
                SqlDataReader dr = com.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        item.FilmID = Convert.ToInt32(dr["FilmID"]);
                        item.KategoriID = Convert.ToInt32(dr["KategoriID"]);
                        item.FilmAd = dr["FilmAd"].ToString();
                        item.Yapimci = dr["Yapimci"].ToString();
                        item.YayinTarih = Convert.ToDateTime(dr["YAyinTarih"]);
                        item.Sure = Convert.ToInt32(dr["Sure"]);
                        item.Active = Convert.ToBoolean(dr["Active"]);
                    }
                }
                dr.Close();
                com.Dispose();
                FBAGLANTI.Baglan.Close();
                FBAGLANTI.Baglan.Dispose();
            }
            catch
            {
                item = null;
            }

            return item;
        }

        public static List<EFILM> Film_SelectList()
        {
            List<EFILM> itemlist = new List<EFILM>();

            try
            {
                SqlCommand com = new SqlCommand("Film_SelectList", FBAGLANTI.Baglan);
                com.CommandType = CommandType.StoredProcedure;
                if (com.Connection.State != ConnectionState.Open)
                {
                    com.Connection.Open();
                }
                SqlDataReader dr = com.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        EFILM item = new EFILM();

                        item.FilmID = Convert.ToInt32(dr["FilmID"]);
                        item.KategoriID = Convert.ToInt32(dr["KategoriID"]);
                        item.FilmAd = dr["FilmAd"].ToString();
                        item.Yapimci = dr["Yapimci"].ToString();
                        item.YayinTarih = Convert.ToDateTime(dr["YAyinTarih"]);
                        item.Sure = Convert.ToInt32(dr["Sure"]);
                        item.Active = Convert.ToBoolean(dr["Active"]);
                        itemlist.Add(item);
                    }
                }
                dr.Close();
                com.Dispose();
                FBAGLANTI.Baglan.Close();
                FBAGLANTI.Baglan.Dispose();
            }
            catch
            {
                itemlist = null;
            }

            return itemlist;
        }


        //FilmKategori işlemlerini yapan metotlar.
        public static int FilmKategori_Insert(EFILMKATEGORI item)
        {
            int sonuc;

            try
            {
                SqlCommand com = new SqlCommand("FilmKategori_Insert", FBAGLANTI.Baglan);
                com.CommandType = CommandType.StoredProcedure;
                if (com.Connection.State != ConnectionState.Open)
                {
                    com.Connection.Open();
                }
                com.Parameters.AddWithValue("KategoriAd", item.KategoriAd);
                com.Parameters.AddWithValue("GenelIzleyici", item.GenelIzleyici);
                sonuc = com.ExecuteNonQuery();
                com.Dispose();
                FBAGLANTI.Baglan.Close();
                FBAGLANTI.Baglan.Dispose();
            }
            catch
            {
                sonuc = -1;
            }

            return sonuc;
        }

        public static bool FilmKategori_Update(EFILMKATEGORI item)
        {
            bool sonuc = false;

            try
            {
                SqlCommand com = new SqlCommand("FilmKategori_Update", FBAGLANTI.Baglan);
                com.CommandType = CommandType.StoredProcedure;
                if (com.Connection.State != ConnectionState.Open)
                {
                    com.Connection.Open();
                }
                com.Parameters.AddWithValue("KategoriID", item.KategoriID);
                com.Parameters.AddWithValue("KategoriAd", item.KategoriAd);
                com.Parameters.AddWithValue("GenelIzleyici", item.GenelIzleyici);
                sonuc = com.ExecuteNonQuery() > 0;
                com.Dispose();
                FBAGLANTI.Baglan.Close();
                FBAGLANTI.Baglan.Dispose();
            }
            catch
            {
                sonuc = false;
            }

            return sonuc;
        }

        public static bool FilmKategori_Delete(int _FilmKategoriID)
        {
            bool sonuc = false;

            try
            {
                SqlCommand com = new SqlCommand("FilmKategori_Delete", FBAGLANTI.Baglan);
                com.CommandType = CommandType.StoredProcedure;
                if (com.Connection.State != ConnectionState.Open)
                {
                    com.Connection.Open();
                }

                com.Parameters.AddWithValue("KategoriID", _FilmKategoriID);
                sonuc = com.ExecuteNonQuery() > 0;
                com.Dispose();
                FBAGLANTI.Baglan.Close();
                FBAGLANTI.Baglan.Dispose();
            }
            catch
            {
                sonuc = false;
            }

            return sonuc;
        }

        public static EFILMKATEGORI FilmKategori_Select(int _FilmKategoriID)
        {
            EFILMKATEGORI item = new EFILMKATEGORI();

            try
            {
                SqlCommand com = new SqlCommand("FilmKategori_Select", FBAGLANTI.Baglan);
                com.CommandType = CommandType.StoredProcedure;
                if (com.Connection.State != ConnectionState.Open)
                {
                    com.Connection.Open();
                }
                com.Parameters.AddWithValue("KategoriID", _FilmKategoriID);
                SqlDataReader dr = com.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        item.KategoriID = Convert.ToInt32(dr["KategoriID"]);
                        item.KategoriAd = dr["KategoriAd"].ToString();
                        item.GenelIzleyici = Convert.ToBoolean("GenelIzleyici");
                    }
                }
                dr.Close();
                com.Dispose();
                FBAGLANTI.Baglan.Close();
                FBAGLANTI.Baglan.Dispose();
            }
            catch
            {
                item = null;
            }

            return item;
        }

        public static List<EFILMKATEGORI> FilmKategori_SelectList()
        {
            List<EFILMKATEGORI> itemlist = new List<EFILMKATEGORI>();

            try
            {
                SqlCommand com = new SqlCommand("FilmKategori_SelectList", FBAGLANTI.Baglan);
                com.CommandType = CommandType.StoredProcedure;
                if (com.Connection.State != ConnectionState.Open)
                {
                    com.Connection.Open();
                }
                SqlDataReader dr = com.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        EFILMKATEGORI item = new EFILMKATEGORI();

                        item.KategoriID = Convert.ToInt32(dr["KategoriID"]);
                        item.KategoriAd = dr["KategoriAd"].ToString();
                        item.GenelIzleyici = Convert.ToBoolean("GenelIzleyici");
                        itemlist.Add(item);
                    }
                }
                dr.Close();
                com.Dispose();
                FBAGLANTI.Baglan.Close();
                FBAGLANTI.Baglan.Dispose();
            }
            catch
            {
                itemlist = null;
            }

            return itemlist;
        }


        //Salon işlemlerini yapan metotlar.
        public static int Salon_Insert(ESALON item)
        {
            int sonuc;

            try
            {
                SqlCommand com = new SqlCommand("Salon_Insert", FBAGLANTI.Baglan);
                com.CommandType = CommandType.StoredProcedure;
                if (com.Connection.State != ConnectionState.Open)
                {
                    com.Connection.Open();
                }
                com.Parameters.AddWithValue("Kapasite", item.Kapasite);
                com.Parameters.AddWithValue("SalonAd", item.SalonAd);
                sonuc = com.ExecuteNonQuery();
                com.Dispose();
                FBAGLANTI.Baglan.Close();
                FBAGLANTI.Baglan.Dispose();
            }
            catch
            {
                sonuc = -1;
            }

            return sonuc;
        }

        public static bool Salon_Update(ESALON item)
        {
            bool sonuc = false;

            try
            {
                SqlCommand com = new SqlCommand("Salon_Update", FBAGLANTI.Baglan);
                com.CommandType = CommandType.StoredProcedure;
                if (com.Connection.State != ConnectionState.Open)
                {
                    com.Connection.Open();
                }
                com.Parameters.AddWithValue("SalonID", item.SalonID);
                com.Parameters.AddWithValue("Kapasite", item.Kapasite);
                com.Parameters.AddWithValue("SalonAd", item.SalonAd);
                sonuc = com.ExecuteNonQuery() > 0;
                com.Dispose();
                FBAGLANTI.Baglan.Close();
                FBAGLANTI.Baglan.Dispose();
            }
            catch
            {
                sonuc = false;
            }

            return sonuc;
        }

        public static bool Salon_Delete(int _SalonID)
        {
            bool sonuc = false;

            try
            {
                SqlCommand com = new SqlCommand("Salon_Delete", FBAGLANTI.Baglan);
                com.CommandType = CommandType.StoredProcedure;
                if (com.Connection.State != ConnectionState.Open)
                {
                    com.Connection.Open();
                }

                com.Parameters.AddWithValue("SalonID", _SalonID);
                sonuc = com.ExecuteNonQuery() > 0;
                com.Dispose();
                FBAGLANTI.Baglan.Close();
                FBAGLANTI.Baglan.Dispose();
            }
            catch
            {
                sonuc = false;
            }

            return sonuc;
        }

        public static ESALON Salon_Select(int _SalonID)
        {
            ESALON item = new ESALON();

            try
            {
                SqlCommand com = new SqlCommand("Salon_Select", FBAGLANTI.Baglan);
                com.CommandType = CommandType.StoredProcedure;
                if (com.Connection.State != ConnectionState.Open)
                {
                    com.Connection.Open();
                }
                com.Parameters.AddWithValue("SalonID", _SalonID);
                SqlDataReader dr = com.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        item.SalonID = Convert.ToInt32(dr["SalonID"]);
                        item.Kapasite = Convert.ToInt32(dr["Kapasite"]);
                        item.SalonAd = dr["SalonAd"].ToString();
                    }
                }
                dr.Close();
                com.Dispose();
                FBAGLANTI.Baglan.Close();
                FBAGLANTI.Baglan.Dispose();
            }
            catch
            {
                item = null;
            }

            return item;
        }

        public static List<ESALON> Salon_SelectList()
        {
            List<ESALON> itemlist = new List<ESALON>();

            try
            {
                SqlCommand com = new SqlCommand("Salon_SelectList", FBAGLANTI.Baglan);
                com.CommandType = CommandType.StoredProcedure;
                if (com.Connection.State != ConnectionState.Open)
                {
                    com.Connection.Open();
                }
                SqlDataReader dr = com.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        ESALON item = new ESALON();

                        item.SalonID = Convert.ToInt32(dr["SalonID"]);
                        item.Kapasite = Convert.ToInt32(dr["Kapasite"]);
                        item.SalonAd = dr["SalonAd"].ToString();
                        itemlist.Add(item);
                    }
                }
                dr.Close();
                com.Dispose();
                FBAGLANTI.Baglan.Close();
                FBAGLANTI.Baglan.Dispose();
            }
            catch
            {
                itemlist = null;
            }

            return itemlist;
        }


        //Seans işlemlerini yapan metotlar.
        public static int Seans_Insert(ESEANS item)
        {
            int sonuc;

            try
            {
                SqlCommand com = new SqlCommand("Seans_Insert", FBAGLANTI.Baglan);
                com.CommandType = CommandType.StoredProcedure;
                if (com.Connection.State != ConnectionState.Open)
                {
                    com.Connection.Open();
                }
                com.Parameters.AddWithValue("SeansNo",item.SeansNo);
                com.Parameters.AddWithValue("FilmID", item.FilmID);
                com.Parameters.AddWithValue("SalonID", item.SalonID);
                com.Parameters.AddWithValue("Tarih", item.Tarih);
                com.Parameters.AddWithValue("Active", item.Active);
                sonuc = com.ExecuteNonQuery();
                com.Dispose();
                FBAGLANTI.Baglan.Close();
                FBAGLANTI.Baglan.Dispose();
            }
            catch
            {
                sonuc = -1;
            }

            return sonuc;
        }

        public static bool Seans_Update(ESEANS item)
        {
            bool sonuc = false;

            try
            {
                SqlCommand com = new SqlCommand("Seans_Update", FBAGLANTI.Baglan);
                com.CommandType = CommandType.StoredProcedure;
                if (com.Connection.State != ConnectionState.Open)
                {
                    com.Connection.Open();
                }
                com.Parameters.AddWithValue("SeansID", item.SeansID);
                com.Parameters.AddWithValue("SeansNo", item.SeansNo);
                com.Parameters.AddWithValue("FilmID", item.FilmID);
                com.Parameters.AddWithValue("SalonID", item.SalonID);
                com.Parameters.AddWithValue("Tarih", item.Tarih);
                com.Parameters.AddWithValue("Active", item.Active);
                sonuc = com.ExecuteNonQuery() > 0;
                com.Dispose();
                FBAGLANTI.Baglan.Close();
                FBAGLANTI.Baglan.Dispose();
            }
            catch
            {
                sonuc = false;
            }

            return sonuc;
        }

        public static bool Seans_Delete(int _SeansID)
        {
            bool sonuc = false;

            try
            {
                SqlCommand com = new SqlCommand("Seans_Delete", FBAGLANTI.Baglan);
                com.CommandType = CommandType.StoredProcedure;
                if (com.Connection.State != ConnectionState.Open)
                {
                    com.Connection.Open();
                }

                com.Parameters.AddWithValue("SeansID", _SeansID);
                sonuc = com.ExecuteNonQuery() > 0;
                com.Dispose();
                FBAGLANTI.Baglan.Close();
                FBAGLANTI.Baglan.Dispose();
            }
            catch
            {
                sonuc = false;
            }

            return sonuc;
        }

        public static ESEANS Seans_Select(int _SeansID)
        {
            ESEANS item = new ESEANS();

            try
            {
                SqlCommand com = new SqlCommand("Seans_Select", FBAGLANTI.Baglan);
                com.CommandType = CommandType.StoredProcedure;
                if (com.Connection.State != ConnectionState.Open)
                {
                    com.Connection.Open();
                }
                com.Parameters.AddWithValue("SeansID", _SeansID);
                SqlDataReader dr = com.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        item.SeansID = Convert.ToInt32(dr["SeansID"]);
                        item.SeansNo = Convert.ToInt32(dr["SeansNo"]);
                        item.FilmID = Convert.ToInt32(dr["FilmID"]);
                        item.SalonID = Convert.ToInt32(dr["SalonID"]);
                        item.Tarih = Convert.ToDateTime(dr["Tarih"]);
                        item.Active = Convert.ToBoolean(dr["Active"]);
                    }
                }
                dr.Close();
                com.Dispose();
                FBAGLANTI.Baglan.Close();
                FBAGLANTI.Baglan.Dispose();
            }
            catch
            {
                item = null;
            }

            return item;
        }

        public static List<ESEANS> Seans_SelectList()
        {
            List<ESEANS> itemlist = new List<ESEANS>();

            try
            {
                SqlCommand com = new SqlCommand("Seans_SelectList", FBAGLANTI.Baglan);
                com.CommandType = CommandType.StoredProcedure;
                if (com.Connection.State != ConnectionState.Open)
                {
                    com.Connection.Open();
                }
                SqlDataReader dr = com.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        ESEANS item = new ESEANS();

                        item.SeansID = Convert.ToInt32(dr["SeansID"]);
                        item.SeansNo = Convert.ToInt32(dr["SeansNo"]);
                        item.FilmID = Convert.ToInt32(dr["FilmID"]);
                        item.SalonID = Convert.ToInt32(dr["SalonID"]);
                        item.Tarih = Convert.ToDateTime(dr["Tarih"]);
                        item.Active = Convert.ToBoolean(dr["Active"]);
                        itemlist.Add(item);
                    }
                }
                dr.Close();
                com.Dispose();
                FBAGLANTI.Baglan.Close();
                FBAGLANTI.Baglan.Dispose();
            }
            catch
            {
                itemlist = null;
            }

            return itemlist;
        }


        //Seyirci işlemlerini yapan metotlar.
        public static int Seyirci_Insert(ESEYIRCI item)
        {
            int sonuc;

            try
            {
                SqlCommand com = new SqlCommand("Seyirci_Insert", FBAGLANTI.Baglan);
                com.CommandType = CommandType.StoredProcedure;
                if (com.Connection.State != ConnectionState.Open)
                {
                    com.Connection.Open();
                }
                com.Parameters.AddWithValue("Isim", item.Isim);
                com.Parameters.AddWithValue("Ogrenci", item.Ogrenci);
                sonuc = com.ExecuteNonQuery();
                com.Dispose();
                FBAGLANTI.Baglan.Close();
                FBAGLANTI.Baglan.Dispose();
            }
            catch
            {
                sonuc = -1;
            }

            return sonuc;
        }

        public static bool Seyirci_Update(ESEYIRCI item)
        {
            bool sonuc = false;

            try
            {
                SqlCommand com = new SqlCommand("Seyirci_Update", FBAGLANTI.Baglan);
                com.CommandType = CommandType.StoredProcedure;
                if (com.Connection.State != ConnectionState.Open)
                {
                    com.Connection.Open();
                }
                com.Parameters.AddWithValue("SeyirciID", item.SeyirciID);
                com.Parameters.AddWithValue("Isim", item.Isim);
                com.Parameters.AddWithValue("Ogrenci", item.Ogrenci);
                sonuc = com.ExecuteNonQuery() > 0;
                com.Dispose();
                FBAGLANTI.Baglan.Close();
                FBAGLANTI.Baglan.Dispose();
            }
            catch
            {
                sonuc = false;
            }

            return sonuc;
        }

        public static bool Seyirci_Delete(int _SeyirciID)
        {
            bool sonuc = false;

            try
            {
                SqlCommand com = new SqlCommand("Seyirci_Delete", FBAGLANTI.Baglan);
                com.CommandType = CommandType.StoredProcedure;
                if (com.Connection.State != ConnectionState.Open)
                {
                    com.Connection.Open();
                }

                com.Parameters.AddWithValue("SeyirciID", _SeyirciID);
                sonuc = com.ExecuteNonQuery() > 0;
                com.Dispose();
                FBAGLANTI.Baglan.Close();
                FBAGLANTI.Baglan.Dispose();
            }
            catch
            {
                sonuc = false;
            }

            return sonuc;
        }

        public static ESEYIRCI Seyirci_Select(int _SeyirciID)
        {
            ESEYIRCI item = new ESEYIRCI();

            try
            {
                SqlCommand com = new SqlCommand("Seyirci_Select", FBAGLANTI.Baglan);
                com.CommandType = CommandType.StoredProcedure;
                if (com.Connection.State != ConnectionState.Open)
                {
                    com.Connection.Open();
                }
                com.Parameters.AddWithValue("SeyirciID", _SeyirciID);
                SqlDataReader dr = com.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        item.SeyirciID = Convert.ToInt32(dr["SeyirciID"]);
                        item.Isim = dr["Isim"].ToString();
                        item.Ogrenci = Convert.ToBoolean(dr["Ogrenci"]);
                    }
                }
                dr.Close();
                com.Dispose();
                FBAGLANTI.Baglan.Close();
                FBAGLANTI.Baglan.Dispose();
            }
            catch
            {
                item = null;
            }

            return item;
        }

        public static List<ESEYIRCI> Seyirci_SelectList()
        {
            List<ESEYIRCI> itemlist = new List<ESEYIRCI>();

            try
            {
                SqlCommand com = new SqlCommand("Seyirci_SelectList", FBAGLANTI.Baglan);
                com.CommandType = CommandType.StoredProcedure;
                if (com.Connection.State != ConnectionState.Open)
                {
                    com.Connection.Open();
                }
                SqlDataReader dr = com.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        ESEYIRCI item = new ESEYIRCI();

                        item.SeyirciID = Convert.ToInt32(dr["SeyirciID"]);
                        item.Isim = dr["Isim"].ToString();
                        item.Ogrenci = Convert.ToBoolean(dr["Ogrenci"]);
                        itemlist.Add(item);
                    }
                }
                dr.Close();
                com.Dispose();
                FBAGLANTI.Baglan.Close();
                FBAGLANTI.Baglan.Dispose();
            }
            catch
            {
                itemlist = null;
            }

            return itemlist;
        }
    }
}
