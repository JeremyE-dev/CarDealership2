using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarDealership2.Models
{
    public class Make
    {
        public int MakeId { get; set; }
        public string MakeName { get; set; }
        public string DateAdded { get; set; }

        //the user who added the vehicle
        public int UserId { get; set; }

        //doing this, can do things like Make.User.Email
        public virtual User User { get; set; }
    }
}