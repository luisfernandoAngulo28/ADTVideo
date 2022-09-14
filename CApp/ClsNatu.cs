
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CApp
{
    public class ClsNatu
    {
        //Atributo
        private int n;
        //Constructor
        public ClsNatu()
        {
            n = 0;
        }

        public void cargar(int ele)
        {
            this.n = ele;
        }
        public bool esCero(ClsNatu x)
        {
            //return x.n == 0;
            if (x.n== 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public ClsNatu Sucesor(ClsNatu x)
        {
            x.n = x.n + 1;
            return x;
        }
        public ClsNatu suma(ClsNatu a,ClsNatu b)
        {
            ClsNatu s = new ClsNatu();
            if(a.n<0 || b.n < 0)
            {
                throw new Exception("Error de numero Invalido");
            }
            else
            {
                s.n = a.n + b.n;
            }
            //Console.WriteLine(s.n);
            return s;
        }

        public ClsNatu Resta(ClsNatu a, ClsNatu b)
        {
            ClsNatu r = new ClsNatu();
            if (a.n < 0 || b.n < 0)
            {
                throw new Exception("Error de numero Invalido");
            }
            else
            {
                if (a.n> b.n)
                {
                    r.n = a.n - b.n;
                }
                else
                {
                    r.n = b.n - a.n;
                }
            }
            return r;
        }
        public ClsNatu multiplicacion(ClsNatu a, ClsNatu b)
        {
            ClsNatu s = new ClsNatu();
            if (a.n < 0 || b.n < 0)
            {
                throw new Exception("Error de numero Invalido");
            }
            else
            {
                s.n = a.n * b.n;
            }
            return s;
        }

        public String Mostrar()
        {
            return "N " + this.n;
        }
    }
}
