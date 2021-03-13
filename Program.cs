using System;

namespace examen_programacion_I
{
    class Program
    {
        static int año;
        static void Main(string[] args)
        {
            Console.WriteLine("INGRESE AÑO");
            año = int.Parse(Console.ReadLine());
            funcionalidad();

        }
        
        static void funcionalidad(){
            if(año % 4 == 0 && año % 100 !=0 || año % 400==0){
                Console.WriteLine(año + " ES BISIESTO");
            }
            else
            {
                Console.WriteLine(año + " NO ES BISIESTO");
            }

        }
    }
}
