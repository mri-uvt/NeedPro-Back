﻿using System;
using System.Collections.Generic;

namespace NeedPro_Back.Models
{
    public partial class City
    {
        public City()
        {
            InverseCountry = new HashSet<City>();
            User = new HashSet<User>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int? CountryId { get; set; }

        public virtual City Country { get; set; }
        public virtual ICollection<City> InverseCountry { get; set; }
        public virtual ICollection<User> User { get; set; }
    }
}
