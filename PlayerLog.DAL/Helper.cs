using PlayerLog.MODEL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace PlayerLog.DAL
{
    public class Helper : IDisposable
    {
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["cstr"].ConnectionString);
        SqlCommand cmd = null;

        public int ExecuteNonQuery(string cmdtext, SqlParameter[] p)
        {

            cmd = new SqlCommand(cmdtext, cn);
            if (p != null)
            {
                cmd.Parameters.AddRange(p);
            }
            ConnectionOpen();
            int sonuc = cmd.ExecuteNonQuery();
            ConnectionClose();
            return sonuc;
        }
        public SqlDataReader ExecuteReader(string cmdtext, SqlParameter[] p)
        {
            cmd = new SqlCommand(cmdtext, cn);
            if (p != null)
            {
                cmd.Parameters.AddRange(p);
            }
            ConnectionOpen();
            return cmd.ExecuteReader(CommandBehavior.CloseConnection);

        }
        void ConnectionOpen()
        {
            try
            {
                if (cn != null && cn.State != ConnectionState.Open)
                {
                    cn.Open();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        void ConnectionClose()
        {
            try
            {
                if (cn != null && cn.State != ConnectionState.Closed)
                {
                    cn.Close();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Dispose()
        {
            if (cn != null && cmd != null)
            {
                cn.Dispose();
                cmd.Dispose();

            }


        }
    }
}




