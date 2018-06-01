﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PoliceStationWebData.Models
{
    public class Patron
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string TelephoneNumber { get; set; }

    }
}
