using System;

namespace Nombramiento_Empleado
{
    public abstract class Empleados
    {
        
        public int HorasTrabajadas {get; set;}
        public double PrecioPorHora {get; set;}
        public int NumeroCuenta {get; set;}

        public Empleados(int horas, double precio, int nCuenta)
        {
            HorasTrabajadas = horas;
            PrecioPorHora = precio;
            NumeroCuenta = nCuenta;
        }
        public Empleados(int horas, double precio)
        {
            HorasTrabajadas = horas;
            PrecioPorHora = precio;
        }
    }
}