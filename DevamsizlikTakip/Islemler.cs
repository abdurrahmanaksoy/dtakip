using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevamsizlikTakip
{
    static class Islemler
    {
        static SqlConnection conn = new SqlConnection();
        static SqlCommand cmd = new SqlCommand();
        static SqlDataAdapter adp = new SqlDataAdapter();

        public static void Olustur()
        {
            if (conn.State != ConnectionState.Closed)
                conn.Close();
            conn.ConnectionString = "Data Source=HP\\SQLEXPRESS;Initial Catalog=DevamsizlikTakip1;Integrated Security=True";
            conn.Open();
            cmd.Connection = conn;
            adp.SelectCommand = cmd;
        }

        public static bool OgrenciGirisYap(string tc, int ogrNo)
        {
            string sql = "select * from tblOgrenci where TcNo=@TcNo and OgrenciId=@OgrNo";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@TcNo", SqlDbType.VarChar).Value = tc;
            cmd.Parameters.Add("@OgrNo", SqlDbType.Int).Value = ogrNo;
            cmd.CommandText = sql;
            DataTable dt = new DataTable();
            adp.Fill(dt);
            if (dt.Rows.Count > 0) return true;
            else return false;
        }


        internal static void SinifKaydet(string sinifAdi)
        {
            string sql = "INSERT INTO tblSinif(Adi) Values(@Ad)";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@Ad", SqlDbType.VarChar).Value = sinifAdi;
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
        }

        internal static DataTable GetSinif()
        {
            string sql = "select * from tblSinif";
            cmd.Parameters.Clear();
            cmd.CommandText = sql;
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }

        internal static void SilSinif(int SinifID)
        {
            string sql = "Delete From tblSinif Where SinifID=@SinifID";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@SinifID", SqlDbType.Int).Value = SinifID;
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
        }

        internal static bool PersonelGirisYap(string KullaniciAdi, string KullaniciSifre)
        {
            string sql = "select * from tblPersonel where PersonelKullaniciAdi=@PersonelKullaniciAdi and PersonelSifre=@PersonelSifre";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@PersonelKullaniciAdi", SqlDbType.VarChar).Value = KullaniciAdi;
            cmd.Parameters.Add("@PersonelSifre", SqlDbType.VarChar).Value = KullaniciSifre;
            cmd.CommandText = sql;
            DataTable dt = new DataTable();
            adp.Fill(dt);
            if (dt.Rows.Count > 0) return true;
            else return false;


        }
        internal static DataTable GetDersGetir()
        {
            string sql = "SELECT * from tblDers";
            cmd.Parameters.Clear();
            cmd.CommandText = sql;
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }
        internal static void DersEkle(string dersAdi)
        {
            string sql = "INSERT INTO tblDers(dersAdi) Values(@DersAdi)";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@dersAdi", SqlDbType.VarChar).Value = dersAdi;
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
        }
        internal static void DersSil(int dersId)
        {
            string sql = "Delete From tblDers Where dersId=@DersId";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@dersId", SqlDbType.Int).Value = dersId;
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
        }



        internal static DataTable GetDevamsizlikGetir()
        {
            string sql = "SELECT *from tblDevamsizlik";
            cmd.Parameters.Clear();
            cmd.CommandText = sql;
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }
        internal static void DevamsizlikEkle(int ogrenciId, DateTime dateTime)
        {
            string sql = "INSERT INTO tblDevamsizlik(OgrenciId,OgrenciDevamsizlikTarihi) Values(@ogrenciId,@dateTime)";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@ogrenciId", SqlDbType.Int).Value = ogrenciId;
            cmd.Parameters.Add("@dateTime", SqlDbType.DateTime).Value = dateTime;
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
        }
        internal static void DevamsizlikSil(int ogrenciId)
        {
            string sql = "Delete From tblDevamsizlik Where OgrenciId=@ogrenciId";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@ogrenciId", SqlDbType.Int).Value = ogrenciId;
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
        }
        internal static DataTable DevamsizlikBilgisiGetir(int ogrenciId)
        {
            string sql = "SELECT tblOgrenci.Ad,tblOgrenci.Soyad,tblDevamsizlik.OgrenciDevamsizlikTarihi FROM tblDevamsizlik"
            + " RIGHT OUTER JOIN tblOgrenci ON tblOgrenci.OgrenciId=tblDevamsizlik.OgrenciId WHERE tblDevamsizlik.OgrenciId=@ogrenciId";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@ogrenciId", SqlDbType.Int).Value = ogrenciId;
            cmd.CommandText = sql;
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }
        internal static DataTable GetOgrenciGetir()
        {
            string sql = "SELECT *from tblOgrenci";
            cmd.Parameters.Clear();
            cmd.CommandText = sql;
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }
        internal static void OgrenciEkle(string ad, string soyad, int sinifId)
        {
            string sql = "INSERT INTO tblOgrenci(ad,soyad,sinifId) Values(@ad,@soyad,@sinifId)";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@ad", SqlDbType.VarChar).Value = ad;
            cmd.Parameters.Add("@soyad", SqlDbType.VarChar).Value = soyad;
            cmd.Parameters.Add("@sinifId", SqlDbType.Int).Value = sinifId;
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
        } 
        internal static void OgrenciSil(int ogrenciId)
        {
            string sql = "Delete From tblOgrenci Where ogrenciId=@ogrenciId";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@ogrenciId", SqlDbType.Int).Value = ogrenciId;
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();

        }
        internal static DataTable GetSinifListesi()
        {
            int ogrNo = FrmAnaOgrenci.OgrenciId;
            string sql = "SELECT * FROM tblOgrenci WHERE SinifID IN(SELECT SinifID FROM tblOgrenci WHERE OgrenciId=@ogrNo)";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@ogrNo", SqlDbType.Int).Value = ogrNo;
            cmd.CommandText = sql;
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }
        internal static DataTable GetOgretmenGetir()
        {
            string sql = "SELECT *from tblOgretmen";
            cmd.Parameters.Clear();
            cmd.CommandText = sql;
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
        } 

        internal static DataTable GetAlinanDersler()
        {
            string sql = "SELECT *from tblOgrenci";
            cmd.Parameters.Clear();
            cmd.CommandText = sql;
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }

        internal static DataTable GetDevamsizlikBilgisi()
        {
            string sql = "SELECT *from tblDevamsizlik";
            cmd.Parameters.Clear();
            cmd.CommandText = sql;
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }
        internal static DataTable GetDersProgrami()
        {
            string sql = "SELECT *from tblAlinanDersler";
            cmd.Parameters.Clear();
            cmd.CommandText = sql;
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }

      
        internal static void DevamsizlikSil(string dersId)
        {
            string sql = "Delete From tblDersProgrami Where dersId=@dersId";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@dersId", SqlDbType.Int).Value = dersId;
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery(); 
        } 

        internal static void OgretmenEkle(string p1, int p2)
        {
            string sql = "INSERT INTO tblOgretmen(isim, sinifID) Values(@isim, @sinifID)";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@isim", SqlDbType.VarChar).Value = p1;
            cmd.Parameters.Add("@sinifID", SqlDbType.Int).Value = p2;
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
        }

        /*internal static void DevamsizlikEkle(int p, DateTime dateTime)
        {
            string sql = "INSERT INTO tblDersProgrami(sinifId) Values(@sinifId)";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@sinifId", SqlDbType.VarChar).Value = p;
            cmd.Parameters.Add("@sinifId", SqlDbType.VarChar).Value = p;
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
        }*/
       

        internal static void OgretmenSil(int sinifId)
        {
            string sql = "Delete From tblOgretmen Where sinifId=@sinifId";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@sinifId", SqlDbType.Int).Value = sinifId;
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
        }
    }
}