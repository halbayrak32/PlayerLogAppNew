using PlayerLog.DAL;
using PlayerLog.MODEL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerLog.BLL
{
    public class TakimBL : IDisposable
    {
        Helper hlp = new Helper();

        public bool TakimEkle(Takim tkm)
        {

            SqlParameter[] p = { new SqlParameter("@TAKIMID", tkm.TAKIMID), new SqlParameter("@TAKIMADI", tkm.TAKIMADI), new SqlParameter("@EYALETADI", tkm.EYALETADI), new SqlParameter("@RESIM", tkm.Resim) };
            int sonuc = hlp.ExecuteNonQuery("Insert into tbl_takimlar values (@TAKIMADI,@EYALETADI,@RESIM)", p);
            return sonuc > 0;
        }

        public bool TakimGuncelle(Takim tkm)
        {
            int sonuc = 0;
            SqlParameter[] p = { new SqlParameter("@TAKIMID", tkm.TAKIMID), new SqlParameter("@TAKIMADI", tkm.TAKIMADI), new SqlParameter("@EYALETADI", tkm.EYALETADI), new SqlParameter("@RESIM", tkm.Resim) };

            sonuc = hlp.ExecuteNonQuery("UPDATE tbl_takimlar SET TAKIMADI=@TAKIMADI,EYALETADI=@EYALETADI,RESIM=@RESIM WHERE ID=@TAKIMID", p);

            return sonuc > 0;
        }

        public Takim TakimBul( string takımAdi,string eyaletAdi)
        {
            Takim tkm  = null;

            SqlParameter[] p = {  new SqlParameter("@TAKIMADI", takımAdi) , new SqlParameter("@EYALETADI", eyaletAdi) };

            SqlDataReader dr = hlp.ExecuteReader("SELECT ID,TAKIMADI,EYALETADI,RESIM FROM tbl_takimlar WHERE TAKIMADI=@TAKIMADI AND EYALETADI=@EYALETADI", p);

            while (dr.Read())
            {
                tkm = new Takim();

                tkm.ID = Convert.ToInt32(dr["ID"]);
                //tkm.TAKIMID = (int)dr["TAKIMID"];            
                tkm.TAKIMADI = Convert.ToString(dr["TAKIMADI"]);
                tkm.EYALETADI =Convert.ToString(dr["EYALETADI"]);
                tkm.Resim = Convert.ToString(dr["RESIM"]);
              
            }

            dr.Close();
            

            return tkm;
        }
        public bool TakimSil(int TAKIMID)
        {
            SqlParameter[] p = { new SqlParameter("@TAKIMID", TAKIMID) };
            return hlp.ExecuteNonQuery("Delete from tbl_takimlar where ID=@TAKIMID", p) > 0;
        }

        public DataTable TakimTablosu() => hlp.MyDataTable("Select * from tbl_takimlar");






        public List<Takim> TakimListesi()
        {
            SqlDataReader dr = hlp.ExecuteReader("SELECT ID,TAKIMADI,EYALETADI,RESIM FROM tbl_takimlar", null);
            List<Takim> lst = new List<Takim>();
            while (dr.Read())
            {
                lst.Add(new Takim { ID = Convert.ToInt32(dr["ID"]), TAKIMADI = dr["TAKIMADI"].ToString(), EYALETADI = dr["EYALETADI"].ToString(), Resim = dr["RESIM"].ToString() });
            }
            dr.Close();

            lst.Insert(0, new Takim { TAKIMADI = "Seciniz" });
            return lst;
        }    
        
        
            
                      
                
                
        public void Dispose()
        {
            ((IDisposable)hlp).Dispose();
        }
    }
}
