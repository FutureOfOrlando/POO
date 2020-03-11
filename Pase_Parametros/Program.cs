using System;

namespace Pase_Parametros
{ 
    class Usuario
    {
        public string Id;
        public string Contraseña;
        public Usuario()
        {
            Id = "Orlando789";
            Contraseña = "UZUMYNW789";
        }
/*--------------------------------------------------------*/
        public void Numero(in int n)
        {
            
        }
        public void viajes(int v)
        {
            v= v-5;
        }
    } 
/*--------------------------------------------------------*/
    class Ocultar
    {
           public static void OcultarContraseña(ref Usuario u)
        {
            u.Id = "Orlando789";
            u.Contraseña = "!*$)!@*#&)~";
        }

    } 

/*--------------------------------------------------------*/
    class Valores
    { 
        static public void saldo(int A, int B, out int resultado)
        {
            resultado = A-B;
        }

        static public int saldo(int a, int b)
        {
            return a-b;
        }

    }
/*--------------------------------------------------------*/
    class Program
    {
         static void Main(string[] args)
        {
            int X = 100, Y = 10, R;
		    Valores.saldo(X, Y, out R);
        
            Usuario U = new Usuario();
            
            int q = 10;
            int M = 19211603;
            U.viajes(q);
            U.Numero(in M);
            Ocultar.OcultarContraseña(ref U);
            Console.WriteLine(" Usuario:{0} \n\r Contraseña:{1} \n\r Número de id:{2} \n\r Saldo:{3} \n\r Saldo restante:{4}", U.Id, U.Contraseña, M, R, q);
            
        }  
    }
}
