using CarDealership2.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CarDealership2
{
    public class CarDealership2Entities : DbContext
    {
        //the param in base refers to the name of the connection string
        public CarDealership2Entities() : base("CarDealership2")
        {

        }

        public DbSet<Make> Makes { get; set; }
        public DbSet<User> Users { get; set; }
    }
}