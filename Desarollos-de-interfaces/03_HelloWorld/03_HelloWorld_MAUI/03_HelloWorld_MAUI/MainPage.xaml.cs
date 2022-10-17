using _03_HelloWorld_EntidadesEstandar;

namespace _03_HelloWorld_MAUI;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		persona1.Nombre = tbNombre.Text;
		clsPersonas persona1;
		persona1 = new clsPersonas();
        tSaludo.Text = "Hello "+ persona1.Nombre;

    }
}

