using System;
namespace Domino
{
    /*--------------------------------------*//*Callejas Valdez Jesús Orlando*/
    class Domino{
        private int Espacio1;
        private int Espacio2;
        /*--------------------------------------*/
        public Domino(int Espacio1, int Espacio2)
        {
            this.Espacio1 = Espacio1;
            this.Espacio2 = Espacio2;
            

        }
        /*--------------------------------------*/
        public static int operator + (Domino A, Domino B)
        {
            return(A.Espacio1 + A.Espacio2 + B.Espacio1 +B.Espacio2);
        }
        /*--------------------------------------*/
    }
    /*--------------------------------------*/
    class Program
    {
        static void Main(string[] args)
        {

            /*Captura de Espacio1 y Escpacio2 de la primer ficha*/
            Console.WriteLine("Introduzca la primer valor de la ficha 1");
            int FA1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduzca la segundo valor de la ficha 1");
            int FA2 = int.Parse(Console.ReadLine());
            Domino A= new Domino(FA1,FA2);

            /*Captura de Espacio1 y Escpacio2 de la segunda ficha*/
            Console.WriteLine("Introduzca la primer valor de la ficha 2");
            int FB1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduzca la segundo valor de la ficha 2");
            int FB2 = int.Parse(Console.ReadLine());
            Domino B= new Domino(FB1,FB2);


            /*--------------------------------------*/
            Console.WriteLine("La suma es igual a:");
            Console.WriteLine(A+B);
            /*--------------------------------------*/
            
        }
    }
}
