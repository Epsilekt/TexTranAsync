// This file is auto generated. Changes to this file will be lost!
using System;
using System.Collections.Generic;
	
namespace TexTranAsync.Data.Abstractions.Entities
{
	/// <summary>
	/// Description goes here
	/// </summary>
	public class User : Entity
	{
			
		public string FirstName  { get; set; }
		
		public string LastName  { get; set; }
		
		public string EmailAddress  { get; set; }
		
		public DateTimeOffset DateOfBirth  { get; set; }
		
		public Group Group  { get; set; }
		
		public int? NullableNumber  { get; set; }
	}
}

