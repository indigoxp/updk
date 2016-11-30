using System;
using SQLite;

namespace UPDK.Models
{
	[Table("Regions")]
	public class Region
	{
		[AutoIncrement, PrimaryKey]
		public int Id { get; set; }

		public string Name { get; set; }
	}
}
