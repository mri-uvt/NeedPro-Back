using System;
using System.Collections.Generic;

namespace NeedPro_Back.Models
{
    public partial class User
    {
        public User()
        {
            UserSkill = new HashSet<UserSkill>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int? Type { get; set; }
        public string Adress { get; set; }
        public string Email { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string Pseudo { get; set; }
        public string Sexe { get; set; }
        public int? YearsOfExperience { get; set; }
        public string Biography { get; set; }
        public int? CityId { get; set; }
        public int? SpecialityId { get; set; }

        public virtual City City { get; set; }
        public virtual Speciality Speciality { get; set; }
        public virtual ICollection<UserSkill> UserSkill { get; set; }
    }
}
