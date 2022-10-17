using _03_HelloWorld_EntidadesEstandar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _02_HelloWorld_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        /// <summary>
        /// comentarios: Evento asociado el clcik btsaludar. Mostrara por pantalla el nombre de la persona.
        /// precondiciones:
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btNombre_Click(object sender, RoutedEventArgs e)
        {
           
            if(tbNombre.Text != "")
            {
                clsPersonas persona1 = new clsPersonas();
                persona1.Nombre = tbNombre.Text;
                MessageBox.Show("Saludos: " + persona1.Nombre);
            }
            else
            {
                MessageBox.Show("Tienes que introducir el nombre");
            }
        }
    }
}
