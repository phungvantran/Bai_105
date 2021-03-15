using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
namespace Bai105mvvm.Models
{
	public class Contact
	{
		[PrimaryKey, AutoIncrement]
		public int Id { get; set; }

		[MaxLength(255)]
		public string FirstName { get; set; }

		[MaxLength(255)]
		public string LastName { get; set; }

		[MaxLength(255)]
		public string Phone { get; set; }

		[MaxLength(255)]
		public string Email { get; set; }

		public bool IsBlocked { get; set; }
	}
}
