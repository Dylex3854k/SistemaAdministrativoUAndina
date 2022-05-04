using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CapaNegocio
{
    public class Docente : Persona, IMantenimiento
    {
        private string asignatura;
        private string profesion;
        private string facultad;
        private DateTime FechaNac;

        public string Asignatura { get => asignatura; set => asignatura = value; }
        public string Profesion { get => profesion; set => profesion = value; }
        public string Facultad { get => facultad; set => facultad = value; }
        public DateTime FechaNac1 { get => FechaNac; set => FechaNac = value; }

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

        public string Listar()
        {
            throw new NotImplementedException();
        }
    }
}