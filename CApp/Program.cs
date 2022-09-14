using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            /*
            ClsAgen Agenda = new ClsAgen();
            Agenda.guardar("Fernando", "Angulo", "79153675", "10 de Nov", "fernando23@gmail.com");
            Agenda.guardar("Diana", "Princs", "79153432", "Ramada", "Diana26@gmail.com");
            Console.WriteLine(Agenda.mostrar());
            */

            /*ClsHora H = new ClsHora();
            ///llamada de un prodecimiento
           
            H.cargar(1, 36, 09);
            Console.WriteLine(H.Descargar());
            //Llamada de una funcion
            Console.WriteLine(H.HoraValida(72, 67, 76));
            Console.WriteLine(H.horaActual().Descargar());
            */
            //--------------------------------------------
            ClsNatu N = new ClsNatu();
            N.cargar(34);
            //Suma
            ClsNatu M = new ClsNatu();
            M.cargar(66);
            ClsNatu P = new ClsNatu();
            //Natu.Suma(Num1,Num2).n
            Console.WriteLine(P.suma(N,M).Mostrar());
            //Console.WriteLine(P.Mostrar());




            Console.ReadKey();

        }
    }
}
