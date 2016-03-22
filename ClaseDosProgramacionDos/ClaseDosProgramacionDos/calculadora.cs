using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseDosProgramacionDos
{
    class calculadora
    {
        /*
         * Creamos una clase "calculadora" dentro creamos metodos (funciones) de tipo publico
         * para que sea visto desde cualquier lugar.
        */


        // summary(resumen), crea un archivo xsml, el cual sirve para compartir los datos que
        // que deseemos.



        private static void sumar(double numUno, double numDos)
        {
            double rta;
            rta = numUno + numDos;
            Console.WriteLine("El resultado de la suma  entre "+numUno+" y "+numDos+" es: " + rta);
            

        }
        private static void restar(double numUno, double numDos)
        {
            double rta;
            rta=numUno-numDos;
            Console.WriteLine("El resultado de la resta  entre " + numUno + " y " + numDos + " es: " + rta);
            
        }
        private static void multiplicar(double numUno, double numDos)
        {
            double rta;
            rta = numUno * numDos;
            Console.WriteLine("El resultado de la multiplicacion  entre " + numUno + " y " + numDos + " es: " + rta);
            

        }
        private static void dividir(double numUno, double numDos)
        {
            

            if (calculadora.ValidarSiEsDistintoACero(numDos) == true)

    {
                double rta;
                rta = numUno / numDos;
                Console.WriteLine("El resultado de la division  entre " + numUno + " y " + numDos + " es: " + rta);

            }
            else
            {
                Console.WriteLine("El resultado de la division es: 0 ");
            }
            
            
            
            
        }

        private static bool ValidarSiEsDistintoACero(double Num)
        {
            bool resultado;

            if (Num != 0)
            {
                resultado = true;
            }
            else
            {
                 resultado = false;
            }

            return resultado;
        }

        public static void calcular(double numUno, double numDos, string operacion)
        {
            
            
            switch (operacion)
            { 
                case "+":
                    calculadora.sumar(numUno, numDos);
                    break;
                case "-":
                    calculadora.restar(numUno, numDos);
                    break;
                case "/":
                    calculadora.dividir(numUno, numDos);
                    break;
                case "*":
                    calculadora.multiplicar(numUno, numDos);
                    break;
  
            }

            
        }

    }
}
