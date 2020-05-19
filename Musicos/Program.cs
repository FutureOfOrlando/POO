using System;
using System.Collections.Generic;

namespace Musicos           //Callejas Valdez Jesús Orlando
{
    abstract class Musicos{ //Clase abstracta
        protected string Nombre;

        public Musicos(string Nombre){
            this.Nombre = Nombre;
        }
        //Metodos abtractos, (todas las clases que hereden de Musicos los tendran que implementar) 
        public abstract void Saluda();
        public abstract void Afina();
        public abstract void Toca();
        /*--------------------------------------------------------------------------------------*/
    }
/*----------------------------------------------------------*/
    class Baterista : Musicos{
        protected string Bateria;
        public Baterista(string Nombre, string Bateria) : base(Nombre){
            this.Bateria = Bateria;
        }
        public override void Saluda(){   
            Console.WriteLine("Hola soy {0} y toco la batería", Nombre);
        }
        public override void Afina(){
            Console.WriteLine("{0} preparó su batería {1}", Nombre, Bateria);
        }
        public override void Toca(){
            Console.WriteLine("{0} empezó a tocar la batería", Nombre);
        }        
    }
/*----------------------------------------------------------*/
    class Bajista : Musicos{
        protected string Bateria;

        public Bajista(string Nombre, string Bateria) : base(Nombre){
            this.Bateria = Bateria;
        }
        public override void Saluda(){   
            Console.WriteLine("Hola soy {0} y toco el bajo", Nombre);
        }
        public override void Afina(){
            Console.WriteLine("{0} afinó su Bajo {1}", Nombre, Bateria);
        }
        public override void Toca(){
            Console.WriteLine("{0} empezó a tocar el bajo", Nombre);
        }        
    }
/*----------------------------------------------------------*/
    class Guitarrista : Musicos{
        protected string Bateria;

        public Guitarrista(string Nombre, string Bateria) : base(Nombre){
            this.Bateria = Bateria;
        }
        public override void Saluda(){   
            Console.WriteLine("Hola soy {0} y toco la guitarra", Nombre);
        }
        public override void Afina(){
            Console.WriteLine("{0} afinó su guitarra {1}", Nombre, Bateria);
        }
        public override void Toca(){
            Console.WriteLine("{0} empezó a tocar la guitarra", Nombre);
        }        
    }
/*----------------------------------------------------------*//*Main*//*----------------------------------------------------------*/
    class Program
    {
        static void Main(string[] args)
        {
            Bajista Paul = new Bajista("Paul McCartney", "Höfner");
            Guitarrista George = new Guitarrista("George Harrison", "Höfner President");
            Baterista Ringo = new Baterista("Ringo Starr", "Ludwig Oyster Black Pearl");


           List<Musicos> Beatles = new List<Musicos>();
            Beatles.Add(Paul);
            Beatles.Add(George);
            Beatles.Add(Ringo);

            foreach (Musicos B in Beatles)
            {
                B.Saluda();
                B.Afina();
                B.Toca();
                Console.WriteLine("");
            }


        }
        
    }
}