using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace ContactsExample.Models
{
    public partial class Db : DbContext
    {
        public Db()
            : base("name=Db")
        {
        }

        public virtual DbSet<Contacts> Contacts { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
