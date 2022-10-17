using _05_Entidades;
using System.Diagnostics;

namespace _05_HelloWorld_MAUI;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

    private async void OnCounterClicked(object sender, EventArgs e)
	{
        clsPersonas persona1;
        persona1 = new clsPersonas();
        persona1.Nombre = tbNombre.Text;


        string result = await DisplayPromptAsync("Responde", "Cual es tu apellido");

        persona1.Apellidos = result;

        tSaludo.Text = "Hello " + persona1.Nombre +" "+ persona1.Apellidos;
    }

}

