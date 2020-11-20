using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
namespace Stock_management
{
    class Class1
    {
        SqlTransaction tran;
        SqlConnection con;
        SqlCommand com;
        public static string usr;

        public Class1()
        {
            con = new SqlConnection("database=stock;server=.;uid=sa;password=1234");

        }


        public void query(string s)
        {
            con.Open();
            com = new SqlCommand(s, con);
            com.ExecuteNonQuery();
            con.Close();



        }

        public DataTable show(string c)
        {
            con.Open();
            com = new SqlCommand(c, con);
            SqlDataReader dr = com.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
             con.Close();
            return dt;
        }
        public void transact(string t, string t1)
        {

            con.Open();
            try
            {
                tran = con.BeginTransaction();
                com = new SqlCommand(t, con, tran);
                com.ExecuteNonQuery();
                com = new SqlCommand(t1, con, tran);
                com.ExecuteNonQuery();
                tran.Commit();
                

            }

            catch (Exception ex)
            {
                tran.Rollback();        // agar ek command chal gayi hai to  usko bhi undo kr dega

            }
            con.Close();


        }
    }
}
    