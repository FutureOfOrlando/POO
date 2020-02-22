using System;
using System.Collections.Generic;
namespace Pelicula
{
    class Program
    {
        public class Peliculas{
            private string Titulo;
            private int Año;
            private string Pais;
            private string Director;
                public Peliculas(){
            }
                public Peliculas(string Titulo,int Año){
                    this.Titulo=Titulo;
                    this.Año=Año;
                }
                public void Imprime(){
                    Console.WriteLine("Película: {0} Año: {1}.", Titulo, Año);
                }
        }
        


        static void Main(string[] args)
        {
            Peliculas P1 = new Peliculas("Titanic", 1997);
            /*-----------------------------------------------------------*/
            Peliculas P2 = new Peliculas("Ben-Hur", 2003);
            /*-----------------------------------------------------------*/
            P1.Imprime();
            /*-----------------------------------------------------------*/
            P2.Imprime();

        }
    }
}