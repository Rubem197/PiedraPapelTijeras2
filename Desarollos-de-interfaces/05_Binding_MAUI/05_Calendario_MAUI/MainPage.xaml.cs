namespace _05_Calendario_MAUI
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
            dtpFechaEntrada.MinimumDate = DateTime.Now;
            if (dtpFechaSalida.Date <= dtpFechaEntrada.Date)
            {
                dtpFechaSalida.MinimumDate = dtpFechaEntrada.Date.AddDays(1);
            }
        }

    }
}