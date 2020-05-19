using System;
namespace Alumnos           //Callejas Valdez Jesús Orlando
{
    class Alumnos{
        protected string Nombre;
        public Alumnos(string Nombre){
            this.Nombre = Nombre;
        }
        public void Saluda(){   
            Console.WriteLine("Hola soy {0}", Nombre);
        }
    }
/*-----------------------------------------------*/
    class Licenciatura:Alumnos {
        protected string Ocupacion;
        public Licenciatura (string Nombre, string Ocupacion):base(Nombre){
            this.Ocupacion = Ocupacion;
        }
 
        public new void Saluda(){
            Console.WriteLine("Hola soy alumno de licenciatura, mi nombre es {0}, y mi ocupación es {1}", Nombre, Ocupacion);
 
        }
    }
/*-----------------------------------------------*/
    class Posgrado:Alumnos {
 
        protected string Ocupacion;
 
        public Posgrado (string Nombre, string Ocupacion):base(Nombre){
            this.Ocupacion = Ocupacion;
 
        }
 
        public new void Saluda(){
            
            Console.WriteLine("Hola soy alumno de posgrado, mi nombre es {0}, y mi ocupación es {1}", Nombre, Ocupacion);
 
        }
    }
/*-----------------------------------------------*/
    
    class Program
    {
        static void Main(string[] args)
        {
            
            Alumnos Juan = new Alumnos ("Juan");
            Juan.Saluda();
 
            Licenciatura Pedro = new Licenciatura("Pedro", "hacer Servicio social y residencia");
            Pedro.Saluda();
 
            Posgrado Paquito = new Posgrado("Paquito", "hacer una invetigación de un tema");
            Paquito.Saluda();
        }   
    }    
}
