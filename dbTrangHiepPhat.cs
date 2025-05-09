using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DatabaseTHP
{
    public partial class dbTrangHiepPhat : DbContext
    {
        public dbTrangHiepPhat(string connectionString) : base(connectionString)
        {
        }
       

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
           
        }
    }
}
