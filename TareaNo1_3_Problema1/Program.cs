//    1. Una empresa tiene dos turnos(mañana y tarde) en los que trabajan 8 empleados(4 por
//       la mañana y 4 por la tarde)
//       Desarrollar un programa que permita almacenar los sueldos de los empleados agrupados
//       por turno.Imprimir los gastos en sueldos de cada turno.




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaNo1_3_Problema1
{
    class ProgramTurnos
    {
        // SueldosTurnos es una Matriz [t,n]; donde 
        //   t corresponde al numero de turnos que es fijo 2
        //   n numero de empleados en cada turno en este caso 4.
        private decimal[,] SueldosTurnos;
        private string[] Turno = new string[2] { "Mañana", "Tarde" };
        public void RegistrarSueldos()
        {
            // Registro de Sueldos de Turnos

            SueldosTurnos = new decimal[2, 4];

            decimal Sueldo = 0.0M;
            
            Console.Clear();
            Console.WriteLine("Registro de Empleados");
            Console.WriteLine("=====================");

            Console.WriteLine("Turno de la Mañana:");
            for (int t=0;t<2; t++)
            {
                int i = 0;
                while (i < 4)
                {
                    Console.WriteLine($"Digite el Sueldo del Empleado No.{i+1}, de la {Turno[t]}:");
                    if (decimal.TryParse(Console.ReadLine(), out Sueldo) == true)
                    {
                        SueldosTurnos[t, i] = Sueldo;
                        i++;
                    } else
                    {
                        Console.WriteLine("Error de Digitación, Vuelva a intentar.");
                    }
                }
            }

            Console.WriteLine("\n\nFin de Entrada de Datos. Presione Cualquier Tecla para Volver al Menú");
            Console.ReadKey();

        }

        public void Impresion()
        {
            // Relacion de Gastos Por Turno
            decimal[] TotalGastos = new decimal[2] { 0.00m, 0.00m };
            int intTurno=0;
            Console.Clear();
            Console.WriteLine("Resumen de Gastos en Sueldos x Turnos");
            Console.WriteLine("=====================================");

            for (intTurno = 0; intTurno<2; intTurno++)
            {
                for(int intEmpleado=0;intEmpleado<4;intEmpleado++)
                {
                    TotalGastos[intTurno] += SueldosTurnos[intTurno, intEmpleado]; 
                }
                Console.WriteLine($"El Total de Gastos del Turno de la {Turno[intTurno]} es {TotalGastos[intTurno].ToString("C")}");
            }
            Console.WriteLine("\n\nFin del Resumen de Gastos. Presione Cualquier Tecla para Volver al Menú");
            Console.ReadKey();

        }

        static void Main(string[] args)
        {
            ProgramTurnos ProgTurnos = new ProgramTurnos();

            int intOpcion = 0;

            while (intOpcion!=99)
            {
                Console.Clear();
                Console.WriteLine("****************************************************");
                Console.WriteLine("**   MENU DE REG. SUELDOS DE EMPLEADOS X TURNOS   **");
                Console.WriteLine("****************************************************");
                Console.WriteLine("1 - Registrar Sueldos Empleados x Turnos            ");
                Console.WriteLine("2 - Imprimir el Reporte de Gastos en Sueldo x Turnos");
                Console.WriteLine("99 - Para Salir                                     ");
                Console.WriteLine("****************************************************");
                if (int.TryParse(Console.ReadLine(),out intOpcion)==false)
                {
                    intOpcion = 0;
                }
                if (intOpcion==1)
                {
                    ProgTurnos.RegistrarSueldos();
                }
                if (intOpcion==2)
                {
                    ProgTurnos.Impresion();
                }

            }
        }
    }
}
