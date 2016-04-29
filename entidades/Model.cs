using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entidades
{
    public class Model : DbContext
    {
        public Model() : base("name=Sinco")
        {
            Database.CreateIfNotExists();
        }

        //dbsets d
        public DbSet<Estudio> estudio { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}

