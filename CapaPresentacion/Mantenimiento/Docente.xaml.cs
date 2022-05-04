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
    /// Lógica de interacción para Docente.xaml
    /// </summary>
    public partial class Docente : Window
    {
        public Docente()
        {
            InitializeComponent();
        }

        static readonly CapaNegocio.Docente docente = new CapaNegocio.Docente();

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            docente.Apellidos = txtApellidos.Text.Trim();
            docente.Nombres = txtNombres.Text.Trim();
            docente.Codigo = txtCodigo.Text.Trim();
            docente.Correo = txtCorreo.Text.Trim();
            docente.Domicilio = txtDomicilio.Text.Trim();
            DateTime? FechaNac = dtFechaNac.SelectedDate;
            docente.FechaNac = FechaNac.Value;
            docente.LugarNac = txtLugarNac.Text.Trim();
            docente.Asignatura = txtAsignatura.Text.Trim();
            docente.Facultad = txtFacultad.Text.Trim();
            docente.Profesion = txtProfesion.Text.Trim();

            MessageBox.Show("Se han ingresado los datos");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Apellidos: " + docente.Apellidos +
                "\nNombres: " + docente.Nombres + "\nCodigo: " + docente.Codigo
                + "\nCorreo: " + docente.Correo + "\nDomicilio: " + docente.Domicilio
                + "\nFecha Nacimiento: " + docente.FechaNac + "\nLugar Nacimineto: "
                + docente.LugarNac + "\nAsignatura: " + docente.Asignatura +
                "\nFacultad: " + docente.Facultad + "\nProfesion:: " + docente.Profesion);
        }

        private void btnAsistir_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("El metodo no ha sido implementado");
        }

        private void btnExistir_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("El metodo no ha sido implementado");
        }

        private void btnActualizar_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("El metodo no ha sido implementado");
        }
    }
}
