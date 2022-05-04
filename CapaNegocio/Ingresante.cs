using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CapaNegocio
{
    public class Ingresante : Alumno
    {
        private DateTime fechaIngreso;

        public DateTime FechaIngreso { get => fechaIngreso; set => fechaIngreso = value; }

        public void Actualizar()
        {
            throw new System.NotImplementedException();
        }

        public void Matricular()
        {
            throw new System.NotImplementedException();
        }
    }
}