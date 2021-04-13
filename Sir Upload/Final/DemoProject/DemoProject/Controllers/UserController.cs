using DemoProject.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject.Controllers
{
    public class UserController
    {
        static Database db = new Database();
        public static User AuthenticateUser(string username, string password)
        {
            return db.Users.AutheticateUser(username,password);
        }
        public static bool AddUser(dynamic user) {
            User u = new User();
            u.Name = user.Name;
            u.Password = user.Password;
            u.Username = user.Username;
          
            return db.Users.AddUser(u);
        }

        public static User GetUser(string username) {
            return db.Users.GetUser(username);
        }
        public static bool UpdateUser(dynamic user) {
            User u = new User();
            u.Username = user.Username;
            u.Name = user.Name;
            return db.Users.UpdateUser(u);
        }
        public static bool DeleteUser(string username) {
            return db.Users.DeleteUser(username);
        }
        public static ArrayList GetAllUsers() {
            return db.Users.GetAllUsers();
        }
    }
}
