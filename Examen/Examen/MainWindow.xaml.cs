using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Examen
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private void RegistrarseButton_Click(object sender, RoutedEventArgs e)
        {
          Registro win2 = new Registro();
            win2.Show();
            this.Close();
        }

        private void GuardarButton_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void RegresarButton_Click(object sender, RoutedEventArgs e)
        {
           
        }

        public MainWindow()
        {
            InitializeComponent();
        }

        private void IniciarSesionButton_Click(object sender, RoutedEventArgs e)
        {
            if (Autenticacion.Autenticar(txtUsuario.Text, txtContraseña.Password))
            {
                MessageBox.Show("Bienvenido!");
                VentanaPrincipal win3 = new VentanaPrincipal();
                win3.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Tu Usuario o Contraseña es incorrecta. Vuelve a intentarlo.");
            }
        }
    }
}
