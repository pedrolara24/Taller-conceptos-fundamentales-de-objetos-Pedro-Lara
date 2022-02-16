using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller_conceptos_fundamentales_de_objetos_Pedro_Lara
{
    class Program
    {
        static void Main(string[] args)
        {
            //primero se obtiene los datos para poder evaluar algunas consideraciones a la quincena como el bono profesional y obtener los dias que la persona trabaja
            
            Console.WriteLine("Ingrese el numero de dias que trabaja: ");
            Double DiasLaborados = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Tiene usted un titulo profesional?(Digite Y o N): ");
            String RespuestaTitulo = Convert.ToString(Console.ReadLine());

            //aqui declaro las variables iniciales y les indico el valor que me plantea el problema dado

            Double Quincena = 1050000;
            Double BonoTransporte = 120000;
            Double BonoAlimentacion = DiasLaborados * 25000;
            Double BonoProfesional = 0;

            //con este ciclo decido si se le aplicara el bono profesional o no

            if (RespuestaTitulo == "Y")
            {
                BonoProfesional = Quincena / 100 * 10;
                Console.WriteLine("Felicidades, le ha sido otorgado un bono del 10% por contar con un titulo de profesional");

            }
            else if (RespuestaTitulo == "N")
            {
                Console.WriteLine("No ha sido posible darle el beneficio del 10% adicional a su sueldo, ya que no cuenta con un titulo universitario");
            }


            Double Pago_Parcial = Quincena + BonoTransporte + BonoAlimentacion + BonoProfesional;

            //ahora se aplican las deducciones respectivas

            Double SeguroColectivo = Pago_Parcial / 100 * 2;
            Double ParoForzoso = Pago_Parcial / 100 * 1;
            Double EPS = Pago_Parcial / 100 * 2;
            Double CajaCompensacion = Pago_Parcial / 100 * 2;

            //Ahora se calcula el sueldo total

            Double QuincenaFinal = Pago_Parcial - SeguroColectivo - ParoForzoso - EPS - CajaCompensacion;
            Console.WriteLine("Su sueldo quincenal tras aplicarle los beneficios y deducciones necesarias es: " + QuincenaFinal);
            Console.ReadKey();


        }
    }
}
