using FinalProject.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace FInalProject
{
    public class SqlUser : IUser
    {
        DBHelper db = DBHelper.Instance;
        public bool Authenticate(string username, string password)
        {
            bool userCheck = db.Users.Select(p => p.username == username
                                          && p.password == password).FirstOrDefault();
            return userCheck;
        }
    }

}
