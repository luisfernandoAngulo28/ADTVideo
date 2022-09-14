using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CApp
{    /*ClsAgen, TAD Agenda (Conjunto de Elemento compuesto por:
      * Nombre,
      * Apellido
      * Teléfono, 
      * Dirección
      * Mail         */
    public class ClsAgen
    {
        //Atributos
        String[] Nombre;//
        String[] Apellido;
        String[] Telefono;
        String[] Dir;
        String[] Correo;
        int N;//Contar la Cantidad de Contactos en mi agenda
        //Constructor
        public ClsAgen()
        {
            this.Nombre = new String[100];
            this.Apellido = new String[100];
            this.Telefono = new String[100];
            this.Dir = new String[100];
            this.Correo = new String[100];
            this.N = 0;
        }
        //









        public void guardar(String n , String a , String t , String d , String c)
        {
            Nombre[N] = n;
            Apellido[N] = a;
            Telefono[N] = t;
            Dir[N] = d;
            Correo[N] = c;
            N++;
        }

        public String getNombre(int pos)
        {
            return Nombre[pos];
        }

        public int CantidadContacto()
        {
            return N;
        }

        public String mostrar()
        {
            String S = "";
            for(int i = 0; i < N; i++)
            {
                S = S + Nombre[i] + " " + Apellido[i] + " " + Telefono[i] + " " + Dir[i] + " " + Correo[i];
                S = S + "\r\n";
            }
            return S;
        }



    }
}
