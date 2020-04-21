using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio4
{
    class Recepcion:Maquinas,IMaquinas
    {
        public  void nombre()
        {
            Console.WriteLine("maquina encargada de la recepcion");
        }
        int i;
        public override void memoria(int acontador)
        {
            i = acontador;

            if (i == 10)
            {
                Console.WriteLine("la maquina encargada de la recepcion tiene la memoria llena");

            }
            else
                i += 1;
            


        }

        public override void reinicio(int acontador)
        { i = acontador;
            i= 0;
        }

        public  void encendido()
        {
           Console.WriteLine("se encendio la maquina de recepcion");
        }
        public  void apagado()
        {
            Console.WriteLine("se apago la maquina de recepcion");
        }
    }

    interface IMaquinas
    {
        void nombre();
        void encendido();
        void apagado();
    }
}
