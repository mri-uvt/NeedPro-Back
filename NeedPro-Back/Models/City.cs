using System;
using System.Collections.Generic;

namespace NeedPro_Back.Models
{
    public partial class City
    {
        public City()
        {
            User = new HashSet<User>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int? CountryId { get; set; }

        public virtual Country Country { get; set; }
        public virtual ICollection<User> User { get; set; }
    }
}
