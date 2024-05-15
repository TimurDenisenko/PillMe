namespace MePill;

public partial class App : Application
{
	public App()
	{
		MainPage = new Shell
		{
			CurrentItem = new DBListPage()
		};
	}
}
