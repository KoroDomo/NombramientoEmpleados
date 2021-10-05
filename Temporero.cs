using System;

namespace Nombramiento_Empleado
{
    class Temporero : Empleados, IEmpleados
    {
        public string dateTime;
        public string nombre;
        public string departamento;
        public string cargo;
        public double salario;
        public string tipo;

        public Temporero(int horas, double precio) : base(horas, precio)
        {
            this.dateTime = "10/5/2021 5:36 PM";
            this.nombre = "Fulano De Tal";
            this.departamento = "IT";
            this.cargo = "Supervisor";
            this.salario = 20000.00;
            this.tipo = "Tiempo Completo";            
        }

        public void hacerLog()
        {
            Console.WriteLine("Fecha y hora de creacion: " + dateTime);
            Console.WriteLine("Nombre del empleado: " + nombre);
            Console.WriteLine("Departamento: " + departamento);
            Console.WriteLine("Cargo: " + cargo);
            Console.WriteLine("Salario: " + salario);
        }
        
        /*public override int numeroCuenta()
        {
            return 0;
        }*/
        /*public override string  ToString()
        {
            return "Tipo: " + tipo() + " || " + "Horas Trabajadas: " + horasTrabajadas() + " || " + " Precio Por Hora: " + precioPorHora() + " || " + "No. de Cuenta: " + numeroCuenta();
        }*/
    }
}