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
    public class BolgeBL : IDisposable
    {
        Helper hlp = new Helper();


        public List<Bolgeler> BolgeListesi()
        {
            SqlDataReader dr = hlp.ExecuteReader("SELECT ID,BOLGE FROM tbl_bolgeler", null);
            List<Bolgeler> lst = new List<Bolgeler>();
            while (dr.Read())
            {
                lst.Add(new Bolgeler { ID = Convert.ToInt32(dr["ID"]), BOLGE = dr["BOLGE"].ToString() });
            }
            dr.Close();

            lst.Insert(0, new Bolgeler { BOLGE = "Seciniz" });
            return lst;
        }


        public void Dispose()
        {
            ((IDisposable)hlp).Dispose();
        }

    }
}
