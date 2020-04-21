using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio4
{
    class Maquinacentral
    {
        Recepcion recepcion = new Recepcion();
        Almacenamiento almacenamiento = new Almacenamiento();
        Ensamblaje ensamblaje = new Ensamblaje();
        Verificacion verificacion = new Verificacion();
        Empaque empaque = new Empaque();
        public void funcion()
        {
            int i, x, y, z, w, m;
            i = 0;
            x = 0;
            y = 0;
            z = 0;
            w = 0;
            m = 0;
            recepcion.encendido();
            almacenamiento.encendido();
            ensamblaje.encendido();
            verificacion.encendido();
            empaque.encendido();

            while (i <= 20)
            {
                Console.WriteLine(i + ":00");
                recepcion.memoria(x);
                almacenamiento.memoria(y);
                ensamblaje.memoria(z);
                verificacion.memoria(w);
                empaque.memoria(m);
                
                if (x == 10)
                {
                    x = 0;
                }
                if (y == 7)
                {
                    y = 0;
                    if (w == 9)
                    {
                        w = 0;
                    }
                    if (z == 8)
                    {
                        z = 0;
                    }
                }
                if (m == 6)
                {
                    m = 0;
                }
                i += 1;
                x += 1;
                y += 1;
                z += 1;
                w += 1;
                m += 1;


            }
            recepcion.apagado();
            almacenamiento.apagado();
            ensamblaje.apagado();
            verificacion.apagado();
            empaque.apagado();
            



        }
        string criterio;
        public void manual()
        {

            int i, x, y, z, w, m;
            i = 0;
            x = 0;
            y = 0;
            z = 0;
            w = 0;
            m = 0;
            recepcion.encendido();
            almacenamiento.encendido();
            ensamblaje.encendido();
            verificacion.encendido();
            empaque.encendido();

            while (i <= 20)
            {
                Console.WriteLine(i + ":00");
                recepcion.memoria(x);
                almacenamiento.memoria(y);
                ensamblaje.memoria(z);
                verificacion.memoria(w);
                empaque.memoria(m);

                if (x == 10)
                {
                    Console.WriteLine("elige la consola quiere reiniciar:");
                    Console.WriteLine("1)recepcion");
                    Console.WriteLine("2)almacenamiento");
                    Console.WriteLine("3)ensamblaje");
                    Console.WriteLine("4)verificacion");
                    Console.WriteLine("5)empaque");
                    criterio = Console.ReadLine();

                    switch (criterio)
                    {
                        case "1":
                            x = 0;
                            
                            break;

                        case "2":
                            y = 0;

                            break;

                        case "3":
                            z = 0;
                            break;

                        case "4":
                            w = 0;
                            break;

                        case "5":
                            m = 0;
                            break;
                    }
                   
                        
                }
                if (y == 7)
                {
                    Console.WriteLine("elige la consola quiere reiniciar:");
                    Console.WriteLine("1)recepcion");
                    Console.WriteLine("2)almacenamiento");
                    Console.WriteLine("3)ensamblaje");
                    Console.WriteLine("4)verificacion");
                    Console.WriteLine("5)empaque");
                    criterio = Console.ReadLine();

                    switch (criterio)
                    {
                        case "1":
                            x = 0;

                            break;

                        case "2":
                            y = 0;

                            break;

                        case "3":
                            z = 0;
                            break;

                        case "4":
                            w = 0;
                            break;

                        case "5":
                            m = 0;
                            break;
                    }
                    
                }
                if (z == 9)
                {
                    Console.WriteLine("elige la consola quiere reiniciar:");
                    Console.WriteLine("1)recepcion");
                    Console.WriteLine("2)almacenamiento");
                    Console.WriteLine("3)ensamblaje");
                    Console.WriteLine("4)verificacion");
                    Console.WriteLine("5)empaque");
                    criterio = Console.ReadLine();

                    switch (criterio)
                    {
                        case "1":
                            x = 0;

                            break;

                        case "2":
                            y = 0;

                            break;

                        case "3":
                            z = 0;
                            break;

                        case "4":
                            w = 0;
                            break;

                        case "5":
                            m = 0;
                            break;
                    }
                   

                }
                if (w == 8)
                {
                    Console.WriteLine("elige la consola quiere reiniciar:");
                    Console.WriteLine("1)recepcion");
                    Console.WriteLine("2)almacenamiento");
                    Console.WriteLine("3)ensamblaje");
                    Console.WriteLine("4)verificacion");
                    Console.WriteLine("5)empaque");
                    criterio = Console.ReadLine();

                    switch (criterio)
                    {
                        case "1":
                            x = 0;

                            break;

                        case "2":
                            y = 0;

                            break;

                        case "3":
                            z = 0;
                            break;

                        case "4":
                            w = 0;
                            break;

                        case "5":
                            m = 0;
                            break;
                    }
                    
                }
                if (m == 6)
                {
                    Console.WriteLine("elige la consola quiere reiniciar:");
                    Console.WriteLine("1)recepcion");
                    Console.WriteLine("2)almacenamiento");
                    Console.WriteLine("3)ensamblaje");
                    Console.WriteLine("4)verificacion");
                    Console.WriteLine("5)empaque");
                    criterio = Console.ReadLine();

                    switch (criterio)
                    {
                        case "1":
                            x = 0;

                            break;

                        case "2":
                            y = 0;

                            break;

                        case "3":
                            z = 0;
                            break;

                        case "4":
                            w = 0;
                            break;

                        case "5":
                            m = 0;
                            break;
                    }
                   
                }
                i += 1;
                x += 1;
                y += 1;
                z += 1;
                w += 1;
                m += 1;

            }
            recepcion.apagado();
            almacenamiento.apagado();
            ensamblaje.apagado();
            verificacion.apagado();
            empaque.apagado();
            







        }




    }

}







    

