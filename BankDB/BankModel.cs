namespace BankDB
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class BankModel : DbContext
    {
        public BankModel()
            : base("name=BankModel")
        {
        }
        
        public DbSet<Cards> Cards { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<BankOperations> BankOperations { get; set; }
        public DbSet<Info> Infos { get; set; }
    }
}