using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CapaNegocio
{
    public class Alumno : Persona, IMantenimiento
    {
        private string escuela;
        private string seguro;
        private string sexo;

        public string Escuela { get => escuela; set => escuela = value; }
        public string Seguro { get => seguro; set => seguro = value; }
        public string Sexo { get => sexo; set => sexo = value; }

        public bool Actualizar()
        {
            throw new NotImplementedException();
        }

        public bool Agregar()
        {
            throw new NotImplementedException();
        }

        public string Buscar()
        {
            throw new NotImplementedException();
        }

        public bool Eliminar()
        {
            throw new NotImplementedException();
        }

        public string Estudiar()
        {
            throw new NotImplementedException();
        }

        public string Listar()
        {
            throw new NotImplementedException();
        }
    }
}