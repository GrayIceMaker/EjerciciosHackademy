using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosHackademy
{
    class Program
    {
        static void Main(string[] args)
        {
            /**Ejercicio 01
             * If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. 
             * The sum of these multiples is 23.
             * Find the sum of all the multiples of 3 or 5 below 1000.
             **/
            int aux3 = 0, aux5 = 0, sum = 0;
            for (int i = 3; i < 1000; i++)
            {
                if (i % 5 == 0)
                    aux5 += i;
                else if(i % 3 == 0)
                    aux3 += i;
            }
            sum = aux3 + aux5;
            Console.WriteLine("Ejercicio 01");
            Console.WriteLine("La suma de los numeros multiplos de 3 y 5 menores a 1000 es: " + sum);
            /**Ejercicio 02
             * By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.
             * What is the 10 001st prime number?
             **/
            //num inicia en 13 porque es el ultimo numero primo conocido
            int ultprimo = 0, num = 13;
            //cont inicia en 6 porque ya tenemos que 2, 3, 5, 7, 11 y 13 son primos 
            int cont = 6;
            while (cont < 10001)
            {
                num++;
                if (primo(num))
                {
                    cont++;
                    ultprimo = num;
                }
            }
            Console.WriteLine("Ejercicio 02 "+cont);
            Console.WriteLine("El numero primo 10001 es: " + ultprimo);
            Console.ReadKey();
        }

        public static bool primo(int num)
        {
            if (num <= 2 || num % 2 == 0)
                return false;
            /**
             * División por tentativa: consiste en dividir sucesivamente ese número entre los números primos menores o iguales a su raíz cuadrada. 
             * Si alguna de las divisiones es exacta, entonces el número no es primo; en caso contrario, es primo
             **/
            int auxdiv = (int)Math.Floor(Math.Sqrt(num));
            for (int i = 3; i <= auxdiv; i += 2)
            {
                if (num % i == 0)
                    return false; 
            }
            return true;
        }
    }
}
