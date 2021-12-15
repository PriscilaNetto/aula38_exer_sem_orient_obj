using System;
using System.Globalization;

namespace aula38_exer_sem_orient_obj
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo x, y; //variaveis do tipo Triangulo (classe)

            x = new Triangulo();
            y = new Triangulo(); //instanciação da variavel 
            
            Console.WriteLine("Entre com as medidas do triângulo X:");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); // dessa forma cada atributo será alocado na memória
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do triângulo Y:");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //vai receber o resultado de acordo com a chamada do método dentro do obj X.
            double areaX = x.CalculateTrianguleArea(); 

            double areaY = y.CalculateTrianguleArea();

            Console.WriteLine("Área de X = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Área de Y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            if(areaX > areaY)
            {
                Console.WriteLine("Maior área é X");
            }
            else
            {
                Console.WriteLine("Maior área é Y");
            }

        }
    }
}
