using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


using System.Data.Entity;

namespace farm.Models
{
    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }

    public class CompanyDBContext: DbContext
    {
        public DbSet<Customer> Customers { get; set; }
    }
}