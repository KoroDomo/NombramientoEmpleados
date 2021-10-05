using System;

namespace Nombramiento_Empleado
{
    class TiempoCompleto : Empleados
    {
        public override string tipo()
        {
            return "Tiempo Completo";
        }
        public override int horasTrabajadas()
        {
            return 8;
        }
        public override double precioPorHora()
        {
            return 500.50;
        }
        public override int numeroCuenta()
        {
            Random r = new Random();
            return r.Next(10000, 100000);
        }

        public override string  ToString()
        {
            return "Tipo: " + tipo() + " || " + "Horas Trabajadas: " + horasTrabajadas() + " || " + " Precio Por Hora: " + precioPorHora() + " || " + "No. de Cuenta: " + numeroCuenta();
        }
    }
}