using System;
using SQLite;

namespace UPDK.Models
{
	[Table("RemoteServices")]
	public class RemoteService
	{
		[AutoIncrement, PrimaryKey]
		public int Id { get; set; }

		public string Name { get; set; }
		public string URL { get; set; }
		public string Login { get; set; }
		public string Password { get; set; }

	}
}
