namespace _06_Botones_MAUI;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
		
	}
	/// <summary>
	/// este metodo, crea un boton pulsando con el click del boton1
	/// 
	/// </summary>
	/// <param name="sender"></param>
	/// <param name="e"></param>
	public void boton3(object sender, EventArgs e) { 
	
		Button btn3 = sender as Button;

		btn3.Text = "boton 3";
	}


}

