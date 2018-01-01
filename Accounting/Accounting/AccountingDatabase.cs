namespace Accounting
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Collections.Generic;
    using System.Linq;
    using System.ComponentModel.DataAnnotations;

    public partial class AccountingDatabase : DbContext
    {
        public AccountingDatabase()
            : base("name=AccountingDatabase")
        { }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Income> Incomes { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Expanse> Expanses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }

        /// <summary>
        /// Customer Tabel to list all customer from his company with foregen key to the
        /// income table 
        /// </summary>
        public class Customer
        {
            public int ID { get; set; }
            public DateTime Date { get; set; }
            public string FullName { get; set; }
            //Colume is added because of the ADD-Migration tool
            public string EMail { get; set; }
            public ulong Phone { get; set; }
            //added 3 new Columes 
            public bool CSA { get; set; }
            public bool Neighborhood { get; set; }
            public bool Horse_Barn { get; set; }
            public List<Income> Incomes { get; set; }
            public Customer()
            {
                this.Incomes = new List<Income>();
            }
        }
        /// <summary>
        /// income Table to document all incomes. This has two foregen keys. One for
        /// Producta and the one for the Customer
        /// </summary>
        public class Income
        {
            public int ID { get; set; }

            public DateTime Date { get; set; }

            public string Payment { get; set; }
            public double Price { get; set; }
            public string Product { get; set; }
            //public Product Products { get; set; }
            public Customer Customer { get; set; }
        }
        /// <summary>
        /// Product table list all poducsed products and one foregen key to the 
        /// Icome table
        /// </summary>
        public class Product
        {
            public int ID { get; set; }
            public DateTime Date { get; set; }
            public string ProductName { get; set; }
        }

        /// <summary>
        /// Expanses Table to list all expense 
        /// </summary>
        [Table("Expanse")]
        public class Expanse
        { 
            public int ID { get; set; }
            public DateTime Date { get; set; }
            public string payment { get; set; }
            public double Price { get; set; }
            public string recipient { get; set; }
        }
    }
}