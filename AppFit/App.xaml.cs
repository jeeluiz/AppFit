using AppFit.Helpers;
using System.IO;

namespace AppFit;

public partial class App : Application
{
    static SQLiteDataBaseHelper database;
    public static SQLiteDataBaseHelper DataBase
    {
        get
        {
            if (database == null)
            {
                database = new SQLiteDataBaseHelper(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "AppFit.db3"));
            }

            return database;
        }
    }

    public App()
	{
		InitializeComponent();

		//MainPage = new AppShell();
		MainPage = new MainPage();
	}
}
