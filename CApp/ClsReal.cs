using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CApp
{
    public class ClsReal
    {   //Atributos
        private double n;
        //Constructor
        public ClsReal()
        {
            n = 0;
        }

        public void cargar(double ele)
        {
            this.n = ele;
        }
        public bool esCero(double x)
        {
            //return x == 0;
            if (x == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double Sucesor(double x)
        {
            x = x + 1;
            return x;
        }
        public double suma(double a, double b)
        {
            double s = 0;
            s = a + b;
            return s;
        }

        public double Resta(double a, double b)
        {
            double r = 0;
            r = a - b;
            return r;
        }
        public double multiplicacion(double a, double b)
        {
            double s = 0;
           
            s = a * b;
            
            return s;
        }

        public int parteEntera(String x)
        {
            String cad = "";
            for(int i = 0; i < x.Length; i++)
            {
                if (x[i] != ',')
                {
                    cad = cad + x[i];
                }
                else
                {
                    i = x.Length + 1;
                }
                
            }
            return int.Parse(cad);

        }

        public bool EsFraccion(ClsReal x)
        {
            int aux = 0;
            aux = ParteEntera(x);
            x.n = x.n - aux;
            if (x.n == 0)
            {
                return false;
            }else { 
                return true; 
            }

        }
        public int ParteEntera(ClsReal x)
        {
            x.n = x.n / 1;
            return Convert.ToInt32(x.n);
        }


    }
}
