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


        public List<Bolge> BolgeListesi()
        {
            SqlDataReader dr = hlp.ExecuteReader("SELECT ID,BOLGE FROM tbl_bolgeler", null);
            List<Bolge> lst = new List<Bolge>();
            while (dr.Read())
            {
                lst.Add(new Bolge { ID = Convert.ToInt32(dr["ID"]), BOLGE = dr["BOLGE"].ToString() });
            }
            dr.Close();

            lst.Insert(0, new Bolge { BOLGE = "Seciniz" });
            return lst;
        }


        public void Dispose()
        {
            ((IDisposable)hlp).Dispose();
        }

    }
}
