using CarDealership2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarDealership2.ViewModels
{
    public class AddMakeVM
    {
        public Make make { get; set; }
        public List<Make> makes { get; set; }

        public AddMakeVM()
        {
            make = new Make();
            makes = new List<Make>();

        }
    }
}