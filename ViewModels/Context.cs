using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using System.Data.Entity;


namespace ViewModels
{
    class Context : DbContext
    {
        public Context() : base("ContactsConnectionString")
        {
        }
        public DbSet<Phong> Phong { get; set; }
        public DbSet<Nguoi> Nguoi { get; set; }
        public DbSet<Tien> Tien { get; set; }
    }
}
