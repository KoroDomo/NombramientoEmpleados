using System;

namespace Nombramiento_Empleado
{
    class Program
    {        
        static void Main(string[] args)
        {
            Empleados empleado = Creador.CreadorEmpleado(Creador.TC);
            Console.WriteLine(empleado.ToString());
        }
    }
}
