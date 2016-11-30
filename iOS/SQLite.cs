using System;
using System.IO;
using Xamarin.Forms;
using UPDK.iOS;

[assembly: Dependency(typeof(SQLite_iOS))]
namespace UPDK.iOS
{
	public class SQLite_iOS : Interfaces.ISQLite
	{
		public SQLite_iOS() { }
		public string GetDatabasePath(string sqliteFilename)
		{
			string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
			string libraryPath = Path.Combine(documentsPath, "..", "Library"); // папка библиотеки
			var path = Path.Combine(libraryPath, sqliteFilename);

			return path;
		}
	}
}