using System;

namespace Nombramiento_Empleado
{
    class Temporero : Empleados
    {
        public override string tipo()
        {
            return "Temporero";
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
            return 0;
        }
        public override string  ToString()
        {
            return "Tipo: " + tipo() + " || " + "Horas Trabajadas: " + horasTrabajadas() + " || " + " Precio Por Hora: " + precioPorHora() + " || " + "No. de Cuenta: " + numeroCuenta();
        }
    }
}