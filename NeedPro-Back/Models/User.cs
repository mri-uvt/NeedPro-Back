using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NeedPro_Back.Models
{
    public class User
    {
		[Key]
		public int Id { get; set; }

		public string FirstName { get; set; }

		public string LastName { get; set; }

		public int Type { get; set; }

        public string Adress { get; set; }

		public string Email { get; set; }

		public DateTime DateOfBirth { get; set; }

	}
}
