using System;
using System.Collections.Generic;
namespace Pelicula
{
    class Program
    {
        public class Peliculas{
            public string Titulo;
            public string getTitulo()=> Titulo;
            public void setTitulo(string T)=> Titulo = T; 
            public int Año;
            public int getAño()=> Año;
            public void setAño(int A)=> Año =A;
            public string Pais;
            public string getPais()=> Pais;
            public void setPais(string P)=>  Pais = P;
            public string Director;
            public string getDirector()=> Director;
            public void setDirector(string D)=> Director = D;
        }



        static void Main(string[] args)
        {
            Peliculas P1 = new Peliculas();
            Peliculas P2 = new Peliculas();
            
            P1.setTitulo("Titanic");
            P1.setAño(1997);
            Console.WriteLine("{0}({1})", P1.getTitulo(), P1.getAño());
            P2.setTitulo("Ben-Hur");
            P2.setAño(2003);
            Console.WriteLine("{0}({1})", P2.getTitulo(), P2.getAño());
            
        }
    }
}
