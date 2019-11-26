using PlayerLog.DAL;
using PlayerLog.MODEL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerLog.BLL
{
    public class TakimBL : IDisposable
    {
        Helper hlp = new Helper();

        public List<Takimlar> TakimListesi()
        {
            SqlDataReader dr = hlp.ExecuteReader("SELECT ID,TAKIMADI FROM tbl_takimlar", null);
            List<Takimlar> lst = new List<Takimlar>();
            while (dr.Read())
            {
                lst.Add(new Takimlar { ID = Convert.ToInt32(dr["ID"]), TAKIMADI = dr["TAKIMADI"].ToString() });
            }
            dr.Close();

            lst.Insert(0, new Takimlar { TAKIMADI = "Seciniz" });
            return lst;
        }    
        
        
            
                      
                
                
        public void Dispose()
        {
            ((IDisposable)hlp).Dispose();
        }
    }
}
