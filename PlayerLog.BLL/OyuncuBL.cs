using PlayerLog.DAL;
using PlayerLog.MODEL;
//using PlayerLogApp;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerLog.BLL 
{
    public class OyuncuBL :IDisposable
    {
        Helper hlp = new Helper();

        
        public bool OyuncuEkle(Oyuncu oyn)
        {
           
            SqlParameter[] p = { new SqlParameter("@TAKIMID", oyn.TAKIMID), new SqlParameter("@BOLGEID", oyn.BOLGEID), new SqlParameter("@OVERALL", oyn.Overall), new SqlParameter("@AD", oyn.Ad), new SqlParameter("@SOYAD", oyn.Soyad), new SqlParameter("@NUMARA", oyn.Numara), new SqlParameter("@BOY", oyn.Boy), new SqlParameter("@DOGUMTARIHI", oyn.DogumTarihi), new SqlParameter("@RESIM", oyn.Resim) };
           int sonuc = hlp.ExecuteNonQuery("Insert into tbl_oyuncu values (@TAKIMID,@BOLGEID,@OVERALL,@AD,@SOYAD,@NUMARA,@BOY,@DOGUMTARIHI,@RESIM)", p);
           return sonuc > 0;
        }

        public bool OyuncuGuncelle(Oyuncu oyn)
        {
            int sonuc = 0;
            SqlParameter[] p = { new SqlParameter("@OYUNCUID", oyn.Oyun), new SqlParameter("@TAKIMID", oyn.TAKIMID), new SqlParameter("@BOLGEID", oyn.BOLGEID), new SqlParameter("@OVERALL", oyn.Overall), new SqlParameter("@AD", oyn.Ad), new SqlParameter("@SOYAD", oyn.Soyad), new SqlParameter("@NUMARA", oyn.Numara), new SqlParameter("@BOY", oyn.Boy), new SqlParameter("@DOGUMTARIHI", oyn.DogumTarihi), new SqlParameter("@RESIM",oyn.Resim) };

            sonuc = hlp.ExecuteNonQuery("UPDATE tbl_oyuncu SET TAKIMID=@TAKIMID,BOLGEID=@BOLGEID,overall=@OVERALL,ad=@AD,soyad=@SOYAD,numara=@NUMARA,Boy=@BOY,DOGUMTARIHI=@DOGUMTARIHI, RESIM=@RESIM  WHERE ID=@OYUNCUID", p);

            return sonuc > 0;
        }

        public Oyuncu OyuncuBul(int numara, int takımId)
        {
            Oyuncu oyn = null;

            SqlParameter[] p = { new SqlParameter("@Numara", numara), new SqlParameter("@TAKIMID", takımId) };

            SqlDataReader dr = hlp.ExecuteReader("SELECT ID,TAKIMID,BOLGEID,OVERALL,AD,SOYAD,NUMARA,BOY,DOGUMTARIHI,RESIM FROM tbl_oyuncu WHERE Numara=@Numara AND TAKIMID=@TAKIMID",p);

            while (dr.Read())
            {
                oyn = new Oyuncu();
                
                oyn.Oyun = Convert.ToInt32(dr["ID"]);
                oyn.TAKIMID = (int)dr["TAKIMID"];
                oyn.BOLGEID = (int)dr["BOLGEID"];
                oyn.Overall = (dr["OVERALL"].ToString());
                oyn.Ad = Convert.ToString(dr["AD"]);
                oyn.Soyad = Convert.ToString(dr["SOYAD"]);
                oyn.Numara = (dr["NUMARA"]).ToString();
                oyn.Boy = (dr["BOY"]).ToString();
                oyn.DogumTarihi = Convert.ToDateTime(dr["DOGUMTARIHI"]);
                oyn.Resim = Convert.ToString(dr["RESIM"]);
                
            }

            dr.Close();
            //hlp.Dispose();

            return oyn;
        }
        public bool OyuncuSil(int ID)
        {
            SqlParameter[] p = { new SqlParameter("@OYUNCUID", ID) };
            return hlp.ExecuteNonQuery("Delete from tbl_oyuncu where ID=@OYUNCUID", p) > 0;
        }

        public DataTable OyuncuTablosu() => hlp.MyDataTable("Select  o.ID,o.AD,O.SOYAD,o.NUMARA,o.BOY,o.OVERALL,o.DOGUMTARIHI,o.TAKIMID,o.BOLGEID,o.RESIM,t.TAKIMADI,b.BOLGE from tbl_oyuncu o Inner Join tbl_takimlar t On o.TAKIMID=t.ID Inner Join tbl_bolgeler b On o.BOLGEID= b.ID");
                       

        public void Dispose()
        {
           hlp.Dispose();
        }
    }
}
