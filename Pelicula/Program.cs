using System;

namespace Pelicula
{
    class Program
    {
        public class Peliculas{
            public string Titulo;
            public string getTitulo()=> Titulo;
            public void setTitulo(string T)=> Titulo = T; 
            public int Año;
            public string getAño()=> Año;
            public void setAño(string A)=> Año =A;
            public string Pais;
            public string getPais()=> Pais;
            public void setPais(int P)=>  Pais = P;
            public string Director;
            public string getDirector()=> Director;
            public void set(string D)=> Director = D;
        }



        static void Main(string[] args)
        {
            Peliculas P1 = new Peliculas();
            Peliculas P2 = new Peliculas();
            
            P1.setTitulo("Pelicula 1");
            P1.setAño(2020);
            Console.WriteLine("{0}({1})", P1.GetTitulo(), P1.GetAño());

        }
    }
}
