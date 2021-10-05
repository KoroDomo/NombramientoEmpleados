using System;

namespace Nombramiento_Empleado
{
    class MedioTiempo : Empleados
    {
        public override string tipo()
        {
            return "Medio Tiempo";
        }
        public override int horasTrabajadas()
        {
            return 4;
        }
        public override double precioPorHora()
        {
            return 200.00;
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