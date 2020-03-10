using System;
using System.Collections.Generic;
namespace Actores
{
    class Pelicula{
        private string Titulo;
        private int Año;
        

        public Pelicula(string Titulo,int Año){
            this.Titulo=Titulo;
            this.Año=Año;
        }
        
        List<Actores> Actor = new List<Actores>();
        public void AgregarActor(Actores Nombre)
        {
            Actor.Add(Nombre);
            
            
            
            
        }
        public void ImprimeActores()
       {
           foreach(Actores a in Actor){
           Console.WriteLine(a.Nombre + " " + a.Date);
           }
           
       }

        public void Imprime(){
            Console.WriteLine("Película: {0} Año: {1}.", Titulo, Año);
        }        
    }
/*------------------------------------------------------------------------*/
    class Actores {
        public string Nombre; public int Date;

        public Actores(string N,int D){
            Nombre=N;
            Date=D;

        }




    }

/*------------------------------------------------------------------------*/
    class Program
    {
        static void Main(string[] args)
        {
            
            Pelicula P1 = new Pelicula("Titanic", 1997);
            //Imprimir el nombre y año de la pelicula
            P1.Imprime();
            /*---------------------------------------*/
            P1.AgregarActor(new Actores("Leonardo Dicaprio", 1976));
            P1.AgregarActor(new Actores("Kate Winslet", 1975));

            P1.ImprimeActores();

        }
    }
}
