﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GeniesShop.Models
{
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Password { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string Choice { get; set; }
    }
}