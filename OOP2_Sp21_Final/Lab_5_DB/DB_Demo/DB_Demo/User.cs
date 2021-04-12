using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DB_Demo
{
    class User
    {
        public int userID { get; private set; }
        public string userName { get; private set; }
        public string userType { get; private set; }

        public User() { }
        public User(string userName, string userType)
        {
            this.userName = userName;
            this.userType = userType;
        }
        public User(int userID, string userName, string userType)
        {
            this.userID = userID;
            this.userName = userName;
            this.userType = userType;
        }
        public bool add()
        {
            string query = @"insert into users values('"+userName+"','"+userType+"')";
            SqlConnection conn = DatabaseHelper.connectDB();
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            int r = cmd.ExecuteNonQuery();
            conn.Close();
            return r==1 ? true:false;
        }
        public bool update()
        {
            string query = string.Format("update users set name = '{0}', type = '{1}' where id = {2}", userName, userType, userID);
            SqlConnection conn = DatabaseHelper.connectDB();
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            int r = cmd.ExecuteNonQuery();
            conn.Close();
            return (r == 1);
        }
        public static List<User> load()
        {
            List<User> users = new List<User>();
            string query = @"select * from users";
            SqlConnection conn = DatabaseHelper.connectDB();
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                User user = new User();
                user.userID = (int)reader.GetValue(reader.GetOrdinal("id"));
                user.userName = (string)reader.GetValue(reader.GetOrdinal("name"));
                user.userType = (string)reader.GetValue(reader.GetOrdinal("type"));
                users.Add(user);
            }
            conn.Close();
            return users;
        }
        public static User search(int id)
        {
            User user = new User();
            string query = @"select * from users where id = " + id;
            SqlConnection conn = DatabaseHelper.connectDB();
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                user.userID = (int)reader.GetValue(reader.GetOrdinal("id"));
                user.userName = (string)reader.GetValue(reader.GetOrdinal("name"));
                user.userType = (string)reader.GetValue(reader.GetOrdinal("type"));
            }
            conn.Close();
            return user;
        }
        public static bool delete(int id)
        {
            string query = @"delete from users where id = " + id;
            SqlConnection conn = DatabaseHelper.connectDB();
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            int r = cmd.ExecuteNonQuery();
            conn.Close();
            return (r == 1);
        }
    }
}
