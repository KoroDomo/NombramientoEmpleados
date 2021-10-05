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
                    return new TiempoCompleto(8, 400, 12346789);
                case MT:
                    return new MedioTiempo(4, 350, 9999999);
                case T:
                    return new Temporero(8, 450);
                default:
                    return null;
            }
        }
    }
}