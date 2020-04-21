using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio4
{
    class Ensamblaje:Maquinas,IMaquinas
    {
        public  void nombre()
        {
            Console.WriteLine("Maquina encargada del ensamblaje");
        }
        int i;
        public override void memoria(int acontador)
        {
            i = acontador;
            

            if (i==8)
            {
                Console.WriteLine("la maquina encargada del ensamblaje tiene la memoria llena");
            }
            else
            {
                i += 1;
            }
    


        }

        public override void reinicio(int acontador)
        {
            i = acontador;
            i = 0;
        }
        public  void encendido()
        {
            Console.WriteLine("se encendio la maquina de ensamblaje");
        }
        public  void apagado()
        {
            Console.WriteLine("se apago la maquina de ensamblaje");
        }



    }
}
