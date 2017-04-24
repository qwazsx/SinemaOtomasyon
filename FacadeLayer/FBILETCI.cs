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
   public class FBILETCI
    {
        //Login metodu.
        public static bool SINEMA_Login(String KullaniciAd, String Parola)
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
                sonuc = ds.Tables[0].Rows.Count > 1;
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

        public static int Bilet_Insert(EBILET item)
        {
            int sonuc;

            try
            {
                SqlCommand com = new SqlCommand("Bilet_Insert", FBAGLANTI.Baglan);
                com.CommandType = CommandType.StoredProcedure;
                if (com.Connection.State != ConnectionState.Open)
                {
                    com.Connection.Open();
                }
                com.Parameters.AddWithValue("SeyirciID", item.SeyirciID);
                com.Parameters.AddWithValue("SeansID", item.SeansID);
                com.Parameters.AddWithValue("Ucret", item.Ucret);
                com.Parameters.AddWithValue("BiletAdedi", item.BiletAdedi);
                com.Parameters.AddWithValue("SalonID", item.SalonID);
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

        public static bool Bilet_Update(EBILET item)
        {
            bool sonuc = false;

            try
            {
                SqlCommand com = new SqlCommand("Bilet_Update", FBAGLANTI.Baglan);
                com.CommandType = CommandType.StoredProcedure;
                if (com.Connection.State != ConnectionState.Open)
                {
                    com.Connection.Open();
                }
                com.Parameters.AddWithValue("BiletID", item.BiletID);
                com.Parameters.AddWithValue("SeyirciID", item.SeyirciID);
                com.Parameters.AddWithValue("SeansID", item.SeansID);
                com.Parameters.AddWithValue("Ucret", item.Ucret);
                com.Parameters.AddWithValue("BiletAdedi", item.BiletAdedi);
                com.Parameters.AddWithValue("SalonID", item.SalonID);
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

        public static bool Bilet_Delete(int _BiletID)
        {
            bool sonuc = false;

            try
            {
                SqlCommand com = new SqlCommand("Bilet_Delete", FBAGLANTI.Baglan);
                com.CommandType = CommandType.StoredProcedure;
                if (com.Connection.State != ConnectionState.Open)
                {
                    com.Connection.Open();
                }
                com.Parameters.AddWithValue("BiletID", _BiletID);
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

        public static EBILET Bilet_Select(int _BiletID)
        {
            EBILET item = new EBILET();

            try
            {
                SqlCommand com = new SqlCommand("Bilet_Select", FBAGLANTI.Baglan);
                com.CommandType = CommandType.StoredProcedure;
                if (com.Connection.State != ConnectionState.Open)
                {
                    com.Connection.Open();
                }
                com.Parameters.AddWithValue("BiletID", _BiletID);
                SqlDataReader dr = com.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        item.BiletID = Convert.ToInt32(dr["BiletID"]);
                        item.SeyirciID = Convert.ToInt32(dr["SeyirciID"]);
                        item.SeansID = Convert.ToInt32(dr["SeansID"]);
                        item.Ucret = Convert.ToDecimal(dr["Ucret"]);
                        item.BiletAdedi = Convert.ToInt32(dr["BiletAdedi"]);
                        item.SalonID = Convert.ToInt32(dr["SalonID"]);
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

        public static List<EBILET> Bilet_SelectList()
        {
            List<EBILET> itemlist = new List<EBILET>();

            try
            {
                SqlCommand com = new SqlCommand("Bilet_SelectList", FBAGLANTI.Baglan);
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
                        EBILET item = new EBILET();
                        item.BiletID = Convert.ToInt32(dr["BiletID"]);
                        item.SeyirciID = Convert.ToInt32(dr["SeyirciID"]);
                        item.SeansID = Convert.ToInt32(dr["SeansID"]);
                        item.Ucret = Convert.ToDecimal(dr["Ucret"]);
                        item.BiletAdedi = Convert.ToInt32(dr["BiletAdedi"]);
                        item.SalonID = Convert.ToInt32(dr["SalonID"]);
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
