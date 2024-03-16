using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using vlad_demo;

namespace vlad_demo
{
   
    internal class coon
    {
        public static DataSet ds = new DataSet();
        public static DataTable dt = new DataTable();
        public static NpgsqlConnection connection = new NpgsqlConnection("Host=localhost; Port=5432 ; Database=R7-571 ; Username=postgres; Password=780213;");

        public static void sqlToDb(string command)
        {
            try
            {
                connection.Open();
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(command, connection);
                ds = new DataSet();
                ds.Reset();
                da.Fill(ds);
                dt = ds.Tables[0];
                connection.Close();
            }
            catch
            {
                connection.Close();
            }

        }

        public static void sqlToDbWithChanges(string command)
        {
            try
            {
                connection.Open();
                NpgsqlCommand cmd = new NpgsqlCommand(command, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch
            {
                connection.Close();
            }
        }


        public static List<product> getSelectedProduct(string str)
        {
            List<product> lst = new List<product>();

            sqlToDb(str);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                product temp = new product();
                temp.id = Convert.ToInt32(dt.Rows[i][0]);
                temp.title = dt.Rows[i][1].ToString();
                temp.producttypeid = Convert.ToInt32(dt.Rows[i][2]);
                temp.articlenumber = dt.Rows[i][3].ToString();
                temp.description = dt.Rows[i][4].ToString();
                temp.image = dt.Rows[i][5].ToString();
                temp.productionpersoncount = Convert.ToInt32(dt.Rows[i][6]);
                temp.productionworkshopnumber = Convert.ToInt32(dt.Rows[i][7]);
                temp.mincostforagent = Convert.ToDouble(dt.Rows[i][8]);

                lst.Add(temp);
            }

            return lst;
        }
    }
}
