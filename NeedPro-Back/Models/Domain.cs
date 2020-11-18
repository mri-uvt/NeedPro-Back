using System;
using System.Collections.Generic;

namespace NeedPro_Back.Models
{
    public partial class Domain
    {
        public Domain()
        {
            Skill = new HashSet<Skill>();
            Speciality = new HashSet<Speciality>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Skill> Skill { get; set; }
        public virtual ICollection<Speciality> Speciality { get; set; }
    }
}
