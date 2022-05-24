using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApplication3
{
    public class DbConnection
    {
        // public String ConString = "Data Source=DESKTOP-TLCBGHU;Initial Catalog=MyTruck;Integrated Security=True";
        public SqlConnection Conn = new SqlConnection("Data Source=HELLOXYT;Initial Catalog=myApp;Integrated Security=True");
        public SqlDataAdapter Adapter;
        public DataSet ds;

        public void Query(String sql)
        {

            if (Conn.State == ConnectionState.Open)
            {
                Conn.Close();
            }
            Conn.Open();
            try
            {
                Adapter = new SqlDataAdapter(sql, Conn);
                ds = new DataSet();
                Adapter.Fill(ds, "emp");
                Conn.Close();
            }
            catch (Exception)
            {
            }
        }

    }
}