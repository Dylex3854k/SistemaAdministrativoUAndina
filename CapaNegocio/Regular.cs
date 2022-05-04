using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CapaNegocio
{
    public class Regular : Alumno, IMantenimiento
    {
        private DateTime FechaIng;

        public DateTime FechaIng1 { get => FechaIng; set => FechaIng = value; }

        public string Actualizar()
        {
            throw new System.NotImplementedException();
        }

        public string Convalidar()
        {
            throw new System.NotImplementedException();
        }

        public string Matricular()
        {
            throw new System.NotImplementedException();
        }

        public string Dispensar()
        {
            throw new System.NotImplementedException();
        }

        public string ReinicioEstudios()
        {
            throw new System.NotImplementedException();
        }
    }
}