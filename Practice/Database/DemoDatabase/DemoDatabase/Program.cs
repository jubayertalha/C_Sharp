using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;

namespace DemoDatabase
{
    class Program
    {
        static void Main(string[] args)
        {

            //connection to database
            //.
            //.
            string connString = @"Server=DESKTOP-BJDQM5C; Database=demo; Integrated Security=true;";  //for windows authentication
            //string connString = @"Server=DESKTOP-BJDQM5C; Database=demo; User Id=sa; Password=tiger;";
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();

            /*//insertion to database
            //.
            //.
            string query = "insert into users values ('jubayer','user')";
            SqlCommand cmd = new SqlCommand(query,conn);

            int r = cmd.ExecuteNonQuery();   //rumber of rows affected
            Console.WriteLine("{0} rows affected", r);

            cmd.Dispose();
            conn.Close();*/

            //selection from database
            //.
            //.
            string query = "select * from users";
            SqlCommand cmd = new SqlCommand(query, conn);
            
            SqlDataReader reader = cmd.ExecuteReader();
            string result = "";

            while (reader.Read())
            {
                result += "id: " + reader.GetValue(0) + "\t\tname: " + reader.GetValue(1) + "\ttype: " + reader.GetValue(reader.GetOrdinal("type")) + "\n";
            }

            Console.Write(result);

            reader.Close();
            cmd.Dispose();
            conn.Close();
            
            //END
            //.
            //.
            Console.ReadLine();
        }
    }
}
