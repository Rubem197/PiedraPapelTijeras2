namespace _07_Pages_Maui;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new NavigationPage(new PaginaNavegacion());
	}
}
