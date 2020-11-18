using System;
using System.Collections.Generic;

namespace NeedPro_Back.Models
{
    public partial class Speciality
    {
        public Speciality()
        {
            User = new HashSet<User>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int? DomainId { get; set; }

        public virtual Domain Domain { get; set; }
        public virtual ICollection<User> User { get; set; }
    }
}
