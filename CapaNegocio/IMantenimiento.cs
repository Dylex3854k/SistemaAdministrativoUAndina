using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    interface IMantenimiento
    {
        //una interfaz es una clase declarativa de metodos abstractos
        bool Agregar();
        bool Eliminar();
        bool Actualizar();
        string Listar();
        string Buscar();

    }
}
