namespace ExamenEntityFramework
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class PizzeriaContext : DbContext
    {
        public DbSet<Pizza> Pizza { get; set; }
        public DbSet<Ingrediente> Ingrediente { get; set; }

        public PizzeriaContext()
            : base("name=Context")
        {

        }

    }
}