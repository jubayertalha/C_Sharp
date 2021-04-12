using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DB_Demo
{
    class DatabaseHelper
    {
        public static SqlConnection connectDB()
        {
            return new SqlConnection(@"Server=DESKTOP-BJDQM5C; Database=demo; Integrated Security=true;");
        }
    }
}
