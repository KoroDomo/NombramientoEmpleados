using System;

namespace Nombramiento_Empleado
{
    public class Creador
    {
        public const int TC = 1;
        public const int MT = 2;
        public const int T = 3;

        public static Empleados CreadorEmpleado(int tipo)
        {
            switch(tipo)
            {
                case TC:
                    return new TiempoCompleto();
                case MT:
                    return new MedioTiempo();
                case T:
                    return new Temporero();
                default:
                    return null;
            }
        }
    }
}