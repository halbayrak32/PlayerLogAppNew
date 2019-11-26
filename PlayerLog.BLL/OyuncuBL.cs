using PlayerLog.DAL;
using PlayerLog.MODEL;
//using PlayerLogApp;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerLog.BLL 
{
    public class OyuncuBL :IDisposable
    {
        Helper hlp = new Helper();

        
        public bool OyuncuEkle(Oyuncular oyn)
        {
           
            SqlParameter[] p = { new SqlParameter("@TAKIMID", oyn.TAKIMID), new SqlParameter("@BOLGEID", oyn.BOLGEID), new SqlParameter("@OVERALL", oyn.Overall), new SqlParameter("@AD", oyn.Ad), new SqlParameter("@SOYAD", oyn.Soyad), new SqlParameter("@NUMARA", oyn.Numara), new SqlParameter("@BOY", oyn.Boy), new SqlParameter("@DOGUMTARIHI", oyn.DogumTarihi) };
           int sonuc = hlp.ExecuteNonQuery("Insert into tbl_oyuncu values (@TAKIMID,@BOLGEID,@OVERALL,@AD,@SOYAD,@NUMARA,@BOY,@DOGUMTARIHI)", p);
           return sonuc > 0;
        }

        public bool OyuncuGuncelle(Oyuncular oyn)
        {
            int sonuc = 0;
            SqlParameter[] p = { new SqlParameter("@OYUNCUID", oyn.Oyuncu), new SqlParameter("@TAKIMID", oyn.TAKIMID), new SqlParameter("@BOLGEID", oyn.BOLGEID), new SqlParameter("@OVERALL", oyn.Overall), new SqlParameter("@AD", oyn.Ad), new SqlParameter("@SOYAD", oyn.Soyad), new SqlParameter("@NUMARA", oyn.Numara), new SqlParameter("@BOY", oyn.Boy), new SqlParameter("@DOGUMTARIHI", oyn.DogumTarihi) };

            sonuc = hlp.ExecuteNonQuery("UPDATE tbl_oyuncu SET TAKIMID=@TAKIMID,BOLGEID=@BOLGEID,overall=@OVERALL,ad=@AD,soyad=@SOYAD,numara=@NUMARA,Boy=@BOY,DOGUMTARIHI=@DOGUMTARIHI  WHERE ID=@OYUNCUID", p);

            return sonuc > 0;
        }

        public Oyuncular OyuncuBul(int numara)
        {
            Oyuncular oyn = null;

            SqlParameter[] p = { new SqlParameter("@Numara", numara) };

            SqlDataReader dr = hlp.ExecuteReader("SELECT ID,TAKIMID,BOLGEID,OVERALL,AD,SOYAD,NUMARA,BOY,DOGUMTARIHI FROM tbl_oyuncu WHERE Numara=@Numara", p);

            while (dr.Read())
            {
                oyn = new Oyuncular();
                
                oyn.Oyuncu = Convert.ToInt32(dr["ID"]);
                oyn.TAKIMID = (int)dr["TAKIMID"];
                oyn.BOLGEID = (int)dr["BOLGEID"];
                oyn.Overall = (dr["OVERALL"].ToString());
                oyn.Ad = Convert.ToString(dr["AD"]);
                oyn.Soyad = Convert.ToString(dr["SOYAD"]);
                oyn.Numara = (dr["NUMARA"]).ToString();
                oyn.Boy = (dr["BOY"]).ToString();
                oyn.DogumTarihi = Convert.ToDateTime(dr["DOGUMTARIHI"]);
            }

            dr.Close();
            //hlp.Dispose();

            return oyn;
        }


        public void Dispose()
        {
           hlp.Dispose();
        }
    }
}
