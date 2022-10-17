namespace _07_Pages_Maui.Views;

public partial class Pagina3 : ContentPage
{
	public Pagina3()
	{
		InitializeComponent();
	}

     async void CambiarPaginaP(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new PaginaNavegacion());
    }
}