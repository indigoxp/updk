using System;
using SQLite;

namespace UPDK.Models
{
	[Table("Builds")]
	public class Build
	{
		[AutoIncrement, PrimaryKey]
		public int Id { get; set; }

		public string Name { get; set; }
	}
}
