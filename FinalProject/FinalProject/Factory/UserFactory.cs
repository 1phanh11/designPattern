using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FInalProject
{
    public class UserFactory
    {
        public static IUser CreateUser(string userType)
        {
            switch (userType)
            {
                case "sql":
                    return new SqlUser();
                default:
                    throw new ArgumentException("Invalid userType");
            }
        }
    }

}
