using System;
using System.Collections.Generic;

namespace NeedPro_Back.Models
{
    public partial class Domain
    {
        public Domain()
        {
            Speciality = new HashSet<Speciality>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Speciality> Speciality { get; set; }
    }
}     
