using System;
using System.Linq;
using System.Collections.Generic;
using Xamarin.Forms;
using SQLite;

namespace UPDK
{
	public class DemoDB : Database
	{
		public DemoDB() : base("demo.db") { }

		public void Generate()
		{
		}
	}
	
	public abstract class Database
	{
		protected static SQLiteConnection database; 

		protected string databasePath;

		public Database(string filename) 
		{
			databasePath = DependencyService.Get<Interfaces.ISQLite>().GetDatabasePath(filename);
			database = new SQLiteConnection(databasePath);
		}

		public static class Regions
		{
			public static IEnumerable<Models.Region> GetItems()
			{
				return (from i in database.Table<Models.Region>() select i).ToList();
			}

			public static Models.Region GetItem(int id)
			{
				return database.Get<Models.Region>(id);
			}

			public static int DeleteItem(int id)
			{
				return database.Delete<Models.Region>(id);
			}

			public static int SaveItem(Models.Region item)
			{
				if (item.Id != 0)
				{
					database.Update(item);
					return item.Id;
				}
				else
				{
					return database.Insert(item);
				}
			}
		}
	}
}
