using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio4
{
    class Program
    {
        static void Main(string[] args)
        {
            Maquinacentral maquinacentral = new Maquinacentral();
            string anuncio;
            Console.WriteLine("escoja metodo:");
            Console.WriteLine("1) automatico");
            Console.WriteLine("2) manual");
            anuncio = Console.ReadLine();
            if (anuncio == "1")
            {
                maquinacentral.funcion();

            }
            if (anuncio == "2")
            {
                maquinacentral.manual();
            }
            if(anuncio!="1" || anuncio!="2")
            {
                Console.WriteLine("el valor ingresado es invalido");
            }


           
            Console.ReadLine();



        }
    }
}
