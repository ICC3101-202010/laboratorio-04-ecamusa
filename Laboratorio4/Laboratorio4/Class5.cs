using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio4
{
    class Verificacion:Maquinas,IMaquinas
    {
        public  void nombre()
        {
            Console.WriteLine("Maquina encargada de la verificacion");
        }
        int i;
        public override void memoria(int acontador)
        {
            i = acontador;
            
            if (i == 9)
            {
                Console.WriteLine("la maquina encargada de la verificacion tiene la memoria llena");

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
            Console.WriteLine("se encendio la maquina de verificacion");
        }
        public  void apagado()
        {
            Console.WriteLine("se apago la maquina de verificacion");
        }
    }
}
