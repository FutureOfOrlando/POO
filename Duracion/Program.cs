using System;
namespace Duracion          /*Callejas Valdez jesús Orlando*/
{
    class Duracion{
        private int horas, minutos, segundos;

        public Duracion(int horas, int minutos, int segundos){
            this.horas = horas;
            this.minutos = minutos;
            this.segundos = segundos;
        }

        public override string ToString()
        {
            return String.Format("{0}:{1}:{2}", horas, minutos, segundos); 
        }

        public static Duracion operator +(Duracion A, Duracion B)
        {
            int horas = A.horas + B.horas;
            int minutos = A.minutos + B.minutos;
            int segundos = A.segundos + B.segundos;

            /*Código que arregla el formato del tiempo*/
            int S = segundos/60;
            int M = minutos/60;
            if (S>=1){
                minutos = minutos + S;
                segundos = segundos%60;
            }
            if (M>=1){
                horas = horas + M;
                minutos = minutos%60;
            }
            /*-----------------------------------------*/
            return new Duracion(horas, minutos, segundos);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Duracion A = new Duracion(2, 50, 80);/*+*/
            Duracion B = new Duracion(2, 10, 40);
                                    /*5:  2:  0*/
            
            Console.WriteLine(A+B);//5:2:20
        }
    }
}
