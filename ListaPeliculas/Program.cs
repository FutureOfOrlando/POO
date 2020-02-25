using System;
using System.Collections.Generic;
namespace ListaPeliculas
{
    class Pelicula{
        private string Titulo;
        public Pelicula (string T){
            Titulo=T;
        }
        public void Imprimir(){
            Console.WriteLine(Titulo);
        }

    }
    /*------------------------------------------------------------------*/
    class Program
    {
        static void Main(string[] args)
        {
            List<Pelicula> P = new List<Pelicula>();
            P.Add(new Pelicula("Star Wars"));
            P.Add(new Pelicula("Jurassic World"));
            P.Add(new Pelicula("Harry Potter"));
            P.Add(new Pelicula("Titanic"));
            P.Add(new Pelicula("El Hobbit"));
            
            foreach(Pelicula PL in P){
                PL.Imprimir();
            }

        }
    }
}
/*---------------------------------------------------------------------*/