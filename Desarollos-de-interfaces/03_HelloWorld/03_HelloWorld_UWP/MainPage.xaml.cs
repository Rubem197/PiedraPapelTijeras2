using _03_HelloWorld_EntidadesEstandar;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.ServiceModel.Channels;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0xc0a

namespace _03_HelloWorld_UWP
{
    /// <summary>
    /// Página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSaludar_Click(object sender, RoutedEventArgs e)
        {
            clsPersonas persona1;
            MessageDialog message;

            if (tbNombre.Text != "")
            {
                persona1 = new clsPersonas();
                persona1.Nombre = tbNombre.Text;
                message = new MessageDialog("Saludos: " + persona1.Nombre);
                message.ShowAsync();
            }
            else {
                message = new MessageDialog("Tienes que introducir un nombre");
            }
           

        }
    }
}
