﻿using System;

namespace Models.Models
{
	public class Person
	{
		public int PersonId { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public DateTime BirthDate { get; set; }
		public Address HomeAddress { get; set; }
		public bool IsActive { get; set; }
		public Role Role { get; set; }
	}
	
	public enum Role
	{
		Admin,
		User,
		Guest
	}
}