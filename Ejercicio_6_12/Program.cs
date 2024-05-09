using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using MathNet.Numerics.Distributions;

namespace Ejercicio_6_12
{
    internal class Prpgram
    {
        static void Main()
        {
            Console.WriteLine("Ejercicio 6.12. En una investigación sobre los efectos teratogénicos del tabaquismo se estudió una muestra\r\nde embarazadas de la cual el 40% fumaba y el 60%, no. Cuando nacieron los niños se encontró que 20\r\nde ellos tenían algún tipo de tara de nacimiento. Sea z el número de niños cuya madre fumaba durante el\r\nembarazo. Si no hay relación entre el hecho de que la madre fumara y los defectos de nacimiento, entonces\r\nz es una binomial con n = 20 y p = 0.4. ¿Cuál es la probabilidad de que 12 ó más niños afectados tengan\r\nmadres que fumaban?");
            Console.WriteLine("");
            Console.WriteLine("Escriba la cantidad de niños que se utilizaron para la muestra");
            int cantNiños = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("Escriba el porcentaje en su forma decimal");
            Console.WriteLine("");
            Console.WriteLine("Escriba el porcemtaje de que la madre fumara durante el embarazo");
            double porct = double.Parse(Console.ReadLine());
            Console.WriteLine("");

            double media = cantNiños * porct;
            double desNorEst1 = Math.Sqrt(cantNiños * porct * (1 - porct));

            double corcContd = 11.5; 
            double desNorEst = (corcContd - media) / desNorEst1;
            double acumula = Normal.CDF(0, 1, desNorEst); 

            double proBusc = 1 - acumula; 

            Console.WriteLine("La probabilidad de que 12 ó más niños afectados tengan madres que fumaban es de "+proBusc);
        }
    }
}