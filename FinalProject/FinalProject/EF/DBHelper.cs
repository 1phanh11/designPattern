using FinalProject.EF;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FinalProject.Models
{
    public class DBHelper : DbContext
    {
        private static DBHelper instance;
        public static DBHelper Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DBHelper();
                }
                return instance;
            }
        }
        public DBHelper() : base("name=myDatabaseConnection")
        {
            Database.SetInitializer<DBHelper>(new CreateDatabaseIfNotExists<DBHelper>());
        }

        public DbSet<Book> Books { set; get; }
        public DbSet<PublishCompany> PublishCompanys { set; get; }
        public DbSet<Reader> Readers { set; get; }
        public DbSet<Report> Reports { set; get; }
        public DbSet<ReportDetail> ReportDetails { set; get; }
        public DbSet<User> Users { set; get; }
        public DbSet<Genre> Genres { set; get; }



    }
}
