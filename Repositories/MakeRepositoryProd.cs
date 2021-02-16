using CarDealership2.Interfaces;
using CarDealership2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarDealership2.Repositories
{
    public class MakeRepositoryProd : IMakeRepository
    {
        public void Add(string makename)
        {
            var repository = new CarDealership2Entities();
            Make make = new Make();
            make.MakeName = makename;
            make.MakeId = repository.Makes.Max(m => m.MakeId) + 1;
            make.DateAdded = DateTime.Today.ToShortDateString();
            //The INSERT statement conflicted with the FOREIGN KEY constraint "FK_dbo.Makes_dbo.Users_UserId". The conflict occurred in database "CarDealership2EF", table "dbo.Users", column 'UserId'.
            //The statement has been terminated.
            //I think this is happening because I did not set userid
            make.UserId = 1;//will change this when I know how to get the current user
            make.User = repository.Users.First(m => m.UserId == make.UserId);

            repository.Makes.Add(make);
            repository.SaveChanges();
        }

        public IEnumerable<Make> GetAll()
        {
            var repository = new CarDealership2Entities();

            var m = from make in repository.Makes
                    select make;

            return m;
        }
    }
}