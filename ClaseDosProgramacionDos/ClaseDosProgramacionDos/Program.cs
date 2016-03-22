using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseDosProgramacionDos
{
    class Program
    {
        static void Main(string[] args)
        {
            // Como notar un metodo estatico_
            // si tengo el nombre de la clase y luego sigue el punto, los metodos son estaticos ya
            // que pertenece a la clase.

           
            double numUno=10;
            double numDos=20;
            double numTres = 30;
            double max;
            string operacion;
            

            Console.WriteLine("Calculadora.\nIngrese la operacion a realizar: + to suma || - to resta || * to multiplica || / to dividir ");
            operacion = Console.ReadLine();
            calculadora.calcular(numUno, numDos, operacion);

            Console.ReadLine();
            
            /*
            calculadora.sumar(numUno, numDos);
            calculadora.restar(numUno, numDos);
            calculadora.multiplicar(numUno, numDos);
            calculadora.dividir(numUno, numDos);
            */
            

            
            
            
        }
    }
}
