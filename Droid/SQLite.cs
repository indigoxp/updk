using System;
using System.IO;
using Xamarin.Forms;
using UPDK.Droid;
 
[assembly: Dependency(typeof(SQLite_Android))]
namespace UPDK.Droid
{
	public class SQLite_Android : Interfaces.ISQLite
	{
		public SQLite_Android() { }
		public string GetDatabasePath(string sqliteFilename)
		{
			string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
			var path = Path.Combine(documentsPath, sqliteFilename);
			return path;
		}
	}
}