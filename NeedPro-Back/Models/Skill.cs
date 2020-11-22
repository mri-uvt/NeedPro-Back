using System;
using System.Collections.Generic;

namespace NeedPro_Back.Models
{
    public partial class Skill
    {
        public Skill()
        {
            UserSkill = new HashSet<UserSkill>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? SpecialityId { get; set; }

        public virtual Speciality Speciality { get; set; }
        public virtual ICollection<UserSkill> UserSkill { get; set; }
    }
}
