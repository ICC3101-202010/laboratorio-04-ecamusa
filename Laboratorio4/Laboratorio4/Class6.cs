using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio4
{
    class Empaque:Maquinas,IMaquinas
    {
        public  void nombre()
        {
            Console.WriteLine("Maquina encargada del empaque");
        }

        int i;
        
        public override void memoria(int acontador)
        {
            i = acontador;
            
            if(i==6)
            {
                Console.WriteLine("la maquina encargada del empaque tiene la memoria llena");
            }
            else
            {
                 
            }
       

        }

        public override void reinicio(int acontador)
        {
            i = acontador;
            i= 0;
        }
        public  void encendido()
        {
            Console.WriteLine("se encendio la maquina de empaque");
        }
        public  void apagado()
        {
            Console.WriteLine("se apago la maquina de empaque");
        }
    }
}
