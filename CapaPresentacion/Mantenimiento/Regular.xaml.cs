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

namespace CapaPresentacion.Mantenimiento
{
    /// <summary>
    /// Lógica de interacción para Regular.xaml
    /// </summary>
    public partial class Regular : Window
    {
        public Regular()
        {
            InitializeComponent();
        }

        static readonly CapaNegocio.Regular regular = new CapaNegocio.Regular();

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            regular.Apellidos = txtApellidos.Text.Trim();
            regular.Nombres = txtNombres.Text.Trim();
            regular.Codigo = txtCodigo.Text.Trim();
            regular.Correo = txtCorreo.Text.Trim();
            regular.Domicilio = txtDomicilio.Text.Trim();
            regular.FechaNac = dtFechaNac.SelectedDate;
            regular.LugarNac = txtLugarNac.Text.Trim();
            regular.Escuela = txtEscuela.Text.Trim();
            regular.Seguro = txtSeguro.Text.Trim();
            regular.Sexo = txtSexo.Text.Trim();
            regular.Semestre = txtSemestre.Text.Trim();

            MessageBox.Show("Se han ingresado los datos");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Apellidos: " + regular.Apellidos +
                "\nNombres: " + regular.Nombres + "\nCodigo: " + regular.Codigo
                + "\nCorreo: " + regular.Correo + "\nDomicilio: " + regular.Domicilio
                + "\nFecha Nacimiento: " + regular.FechaNac + "\nLugar Nacimineto: "
                + regular.LugarNac + "\nEscuela: " + regular.Escuela +
                "\nSeguro: " + regular.Seguro + "\nSexo: " + regular.Sexo +
                "\nSemestre: " + regular.Semestre);
        }

        private void btnAsistir_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("El metodo no ha sido implementado");
        }

        private void btnExistir_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("El metodo no ha sido implementado");
        }

        private void btnEstudiar_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("El metodo no ha sido implementado");
        }

        private void btnActualizar_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("El metodo no ha sido implementado");
        }

        private void btnConvalidar_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("El metodo no ha sido implementado");
        }

        private void btnDispensar_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("El metodo no ha sido implementado");
        }

        private void btnMatricular_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("El metodo no ha sido implementado");
        }

        private void btnReinicioEst_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("El metodo no ha sido implementado");
        }

       
    }
}
