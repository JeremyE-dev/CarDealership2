using CarDealership2.Interfaces;
using CarDealership2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarDealership2.Repositories
{
    public class MakeRepositoryQA : IMakeRepository
    {
        public void Add(string makename)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Make> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}