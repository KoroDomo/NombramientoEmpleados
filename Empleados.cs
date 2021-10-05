using System;

namespace Nombramiento_Empleado
{
    public abstract class Empleados
    {
        public abstract string tipo();
        public abstract int horasTrabajadas();
        public abstract double precioPorHora();
        public abstract int numeroCuenta();
    }
}