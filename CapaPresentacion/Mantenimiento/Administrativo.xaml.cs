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
    /// Lógica de interacción para Administrativo.xaml
    /// </summary>
    public partial class Administrativo : Window
    {
        public Administrativo()
        {
            InitializeComponent();
        }

        static readonly CapaNegocio.Administrativo administrativo = new CapaNegocio.Administrativo();

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            administrativo.Apellidos = txtApellidos.Text.Trim();
            administrativo.Nombres = txtNombres.Text.Trim();
            administrativo.Codigo = txtCodigo.Text.Trim();
            administrativo.Correo = txtCorreo.Text.Trim();
            administrativo.Domicilio = txtDomicilio.Text.Trim();
            DateTime? FechaNac = dtFechaNac.SelectedDate;
            administrativo.FechaNac = FechaNac.Value;
            administrativo.FechaNac = (DateTime)dtFechaNac.SelectedDate;
            administrativo.LugarNac = txtLugarNac.Text.Trim();
            administrativo.Departamento = txtDepartamento.Text.Trim();
            administrativo.Puesto = txtPuesto.Text.Trim();
            administrativo.Sueldo = txtSueldo.Text.Trim();

            MessageBox.Show("Se han ingresado los datos");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Apellidos: " + administrativo.Apellidos +
                "\nNombres: " + administrativo.Nombres + "\nCodigo: " + administrativo.Codigo
                + "\nCorreo: " + administrativo.Correo + "\nDomicilio: " + administrativo.Domicilio
                + "\nFecha Nacimiento: " + administrativo.FechaNac + "\nLugar Nacimineto: "
                + administrativo.LugarNac + "\nDepartamento: " + administrativo.Departamento +
                "\nPuesto: " + administrativo.Puesto + "\nSueldo:: " + administrativo.Sueldo);
        }

        private void btnActualizar_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("El metodo no ha sido implementado");
        }

        private void btnAsistir_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("El metodo no ha sido implementado");
        }

        private void btnExistir_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("El metodo no ha sido implementado");
        }
    }
}
