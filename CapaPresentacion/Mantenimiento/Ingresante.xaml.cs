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
    /// Lógica de interacción para Ingresante.xaml
    /// </summary>
    public partial class Ingresante : Window
    {
        public Ingresante()
        {
            InitializeComponent();
        }

        static CapaNegocio.Ingresante ingresante = new CapaNegocio.Ingresante();

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ingresante.Apellidos = txtApellidos.Text.Trim();
            ingresante.Nombres = txtNombres.Text.Trim();
            ingresante.Codigo = txtCodigo.Text.Trim();
            ingresante.Correo = txtCorreo.Text.Trim();
            ingresante.Domicilio = txtDomicilio.Text.Trim();
            ingresante.LugarNac = txtLugarNac.Text.Trim();
            DateTime? FechaNac = dtFechaNac.SelectedDate;
            ingresante.FechaNac = FechaNac.Value;
            ingresante.Escuela = txtEscuela.Text.Trim();
            ingresante.Seguro = txtSeguro.Text.Trim();
            ingresante.Sexo = txtSexo.Text.Trim();
            DateTime? FechaIngreso = dtFechaIng.SelectedDate;
            ingresante.FechaIngreso = FechaIngreso.Value;

            MessageBox.Show("Se han ingresado los datos");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Apellidos: " + ingresante.Apellidos +
                "\nNombres: " + ingresante.Nombres + "\nCodigo: " + ingresante.Codigo
                + "\nCorreo: " + ingresante.Correo + "\nDomicilio: " + ingresante.Domicilio
                + "\nFecha Nacimiento: " + ingresante.FechaNac + "\nLugar Nacimineto: "
                + ingresante.LugarNac + "\nEscuela: " + ingresante.Escuela +
                "\nSeguro: " + ingresante.Seguro + "\nSexo: " + ingresante.Sexo +
                "\nSemestre: " + ingresante.FechaIngreso);
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

        private void btnMatricular_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("El metodo no ha sido implementado");
        }
    }
}
