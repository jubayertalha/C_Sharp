using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject.Models
{
    public class Database
    {
        public Users Users { get; set; }
        public Products Products { get; set; }
        public Categories Categories { get; set; }
        public Database() {
            string connString = "Server=DESKTOP-1HKAK02;Integrated Security=true;Database=inventory_l";
            SqlConnection conn = new SqlConnection(connString);
            Users = new Users(conn);
            Products = new Products();
            Categories = new Categories();
        }
    }
}
