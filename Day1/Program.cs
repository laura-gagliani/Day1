using System;

namespace Day1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Mi chiamo Laura");

            //commento
            /*commento
            su più righe */

            int a = 1;
            int b = 2;
            a = b;
            Console.WriteLine("the variable a equals " + a);
            Console.WriteLine("the variable b equals " + b);

           
            string parola1 = "sole";  //alloco in memoria "sole" e assegno a parola1 il rel. indirizzo
            string parola2 = "luna";  //alloco in memoria "luna" e assegno a parola2 il rel. indirizzo

            parola2 = parola1; //adesso l'"indirizzo" mi conduce a "sole", secondo l'indirizzo parola1

            Console.WriteLine("parola1 è " + parola1);
            Console.WriteLine("parola2 è " + parola2);



        }
    }
}
