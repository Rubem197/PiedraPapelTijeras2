using _03_HelloWorld_EntidadesEstandar;
using _07_Pages_Maui.Views;
using Microsoft.Maui.ApplicationModel.Communication;

namespace _07_Pages_Maui;

public partial class PaginaNavegacion : ContentPage
{
	public PaginaNavegacion()
	{
		InitializeComponent();
	}
     clsPersonas persona1  = new clsPersonas()
    {

        Nombre = "",
        Apellido = "",


       
    };

    private async void OnCounterClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Views.PaginaTabbed());
        persona1.Nombre = eNombre.Text;
    }
}