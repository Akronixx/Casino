﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int GXN = 0, GXC = 0, GXD = 0, an = 0, ac = 0, ad = 0, apuesta, aciertoN = 0, acierto = 0, pd = 0, sd = 0, td = 0, ele = -1, docena = 0, num = rnd.Next(1, 37);
            string[] colores = { "ROJO", "NEGRO" };
            string op,DA;
            Random random = new Random();
            int indiceAleatorio = random.Next(0, colores.Length);
            string colorele, colorAleatorio = colores[indiceAleatorio];
            Console.WriteLine("[================================RULETA GANADORA================================]");
            Console.WriteLine(num);
            Console.WriteLine(colorAleatorio);
            Console.WriteLine("¿Desea apostar $$ ?");
            DA = Console.ReadLine().ToUpper() ;
            while(DA=="S")
            {

            }
            //NEW
            Console.Write("Ingrese la cantidad que desea apostar: ");
            apuesta = int.Parse(Console.ReadLine());
            while (apuesta <= 0 && apuesta > 0)
            {
                Console.Write("Ingrese una cantidad valida que desea apostar: ");
                apuesta = int.Parse(Console.ReadLine());
            }
            //Intento 1
            Console.WriteLine("¿Desea elegir un número?(S/N)");
            op = Console.ReadLine().ToUpper();
            while (op != "S" && op != "N")
            {
                Console.WriteLine("Ingresé una opción valida (S/N)");
                op = Console.ReadLine().ToUpper();
            }
            if (op == "S")
            {
                aciertoN = aciertoN + 1;
                Console.WriteLine("Elija un número (1-36):");
                ele = int.Parse(Console.ReadLine());
                while (ele < 0 || ele > 36)
                {
                    Console.WriteLine("Ingresé una opción del 1 al 36");
                    ele = int.Parse(Console.ReadLine());
                }
                if (ele == num)
                {
                    acierto = acierto + 1;

                }
                an = an + 1;
            }
            else
            {
                Console.WriteLine("Le tienes miedo al exito");
            }
            //numero
            Console.WriteLine("¿Desea elegir un color?(S/N)");
            op = Console.ReadLine().ToUpper();
            while (op != "S" && op != "N")
            {
                Console.WriteLine("Ingresé una opción valida (S/N)");
                op = Console.ReadLine().ToUpper();
            }
            if (op == "S")
            {
                aciertoN = aciertoN + 1;
                Console.WriteLine("Elija un color (Rojo-Negro):");
                colorele = Console.ReadLine().ToUpper(); ;
                while (colorele != "ROJO" && colorele != "NEGRO")
                {
                    Console.WriteLine("Elija un color valido (Rojo-Negro):");
                    colorele = Console.ReadLine().ToUpper(); ;
                }
                if (colorele == colorAleatorio)
                {
                    acierto = acierto + 1;
                    GXC = apuesta * 2;
                }
                ac = ac + 1;
            }
            else
            {
                Console.WriteLine("Estas perdiendo plata crack");
            }
            //color
            Console.WriteLine("¿Desea elegir incluir la docena?(S/N)");
            op = Console.ReadLine().ToUpper();
            while (op != "S" && op != "N")
            {
                Console.WriteLine("Ingresé una opción valida (S/N)");
                op = Console.ReadLine().ToUpper();
            }
            if (op == "S")
            {
                aciertoN = aciertoN + 1;
                Console.WriteLine("Elija una docena (1-2-3):");
                docena = int.Parse(Console.ReadLine());
                while (docena != 1 && docena != 2 && docena != 3)
                {
                    Console.WriteLine("Elija una docena valida (1-2-3):");
                    docena = int.Parse(Console.ReadLine());
                }
                if (num >= 0 && num < 13)
                {
                    pd = pd + 1;
                }
                else if (num > 12 && num < 25)
                {
                    sd = sd + 1;
                }
                else if (num > 24 && num < 37)
                {
                    td = td + 1;
                }
                switch (docena)
                {
                    case 1:
                        if (num >= 0 && num < 13)
                        {

                            pd = pd + 1;
                        }
                        break;
                    case 2:
                        if (num > 12 && num < 25)
                        {

                            sd = sd + 1;
                        }
                        break;
                    case 3:
                        if (num > 24 && num < 37)
                        {

                            td = td + 1;
                        }
                        break;
                }
                if (pd == 2 || sd == 2 || td == 2)
                {
                    acierto = acierto + 1;
                    GXD = apuesta * 3;
                }
                ad = ad + 1;
            }
            Console.WriteLine("[================================RESULTADOS================================]");
            if (num >= 0 && num < 13)
            {
                Console.WriteLine("Salio la primera docena.");
                pd = pd + 1;
            }
            if (num > 12 && num < 25)
            {
                Console.WriteLine("Salio la segunda docena.");
                sd = sd + 1;
            }
            if (num > 24 && num < 37)
            {
                Console.WriteLine("Salio la tercera docena.");
                td = td + 1;
            }
            Console.WriteLine($"Salio el número {num}.");
            Console.WriteLine($"Salio el color {colorAleatorio}.");
             if (acierto < aciertoN)
            {
                Console.WriteLine($"Acertaste {acierto} de {aciertoN}.");
                Console.WriteLine($"Perdiste :(");
            }
            //1
            else if (an == 1 && ac == 0 && ad == 0 && acierto == aciertoN)
            {
                GXN = apuesta * 36;
                Console.WriteLine($"Acertaste {acierto} de {aciertoN}.");
                Console.WriteLine($"Felicidades Ganaste!!!!!!!!!!!!!!");
                Console.WriteLine($"Tus Ganancias son de {GXN}");
            }
            else if (an == 0 && ac == 1 && ad == 0 && acierto == aciertoN)
            {
                GXC = apuesta * 2;
                Console.WriteLine($"Acertaste {acierto} de {aciertoN}.");
                Console.WriteLine($"Felicidades Ganaste!!!!!!!!!!!!!!");
                Console.WriteLine($"Tus Ganancias son de {GXC}");
            }
            else if (an == 0 && ac == 0 && ad == 1 && acierto == aciertoN)
            {
                GXC = apuesta * 3;
                Console.WriteLine($"Acertaste {acierto} de {aciertoN}.");
                Console.WriteLine($"Felicidades Ganaste!!!!!!!!!!!!!!");
                Console.WriteLine($"Tus Ganancias son de {GXD}");
            }
            //2
            else if (an == 1 && ac == 1 && ad == 0 && acierto == aciertoN)
            {
                GXN = (apuesta * 36) * 2;
                Console.WriteLine($"Acertaste {acierto} de {aciertoN}.");
                Console.WriteLine($"Felicidades Ganaste!!!!!!!!!!!!!!");
                Console.WriteLine($"Tus Ganancias son de {GXN}");
            }
            else if (an == 1 && ac == 0 && ad == 1 && acierto == aciertoN)
            {
                GXN = (apuesta * 36) * 3;
                Console.WriteLine($"Acertaste {acierto} de {aciertoN}.");
                Console.WriteLine($"Felicidades Ganaste!!!!!!!!!!!!!!");
                Console.WriteLine($"Tus Ganancias son de {GXN}");
            }
            //Color
            else if (an == 0 && ac == 1 && ad == 1 && acierto == aciertoN)
            {
                GXC = (apuesta * 2) * 3;
                Console.WriteLine($"Acertaste {acierto} de {aciertoN}.");
                Console.WriteLine($"Felicidades Ganaste!!!!!!!!!!!!!!");
                Console.WriteLine($"Tus Ganancias son de {GXC}");
            }
            //Docena
            else if (an == 1 && ac == 0 && ad == 1 && acierto == aciertoN)
            {
                GXD = (apuesta * 36) * 3;
                Console.WriteLine($"Acertaste {acierto} de {aciertoN}.");
                Console.WriteLine($"Felicidades Ganaste!!!!!!!!!!!!!!");
                Console.WriteLine($"Tus Ganancias son de {GXD}");
            }
            else if (an == 1 && ac == 1 && ad == 1&& acierto == aciertoN)
            {
                GXD = ((apuesta * 36) * 2) * 3;
                Console.WriteLine($"Acertaste {acierto} de {aciertoN}.");
                Console.WriteLine($"Felicidades Ganaste!!!!!!!!!!!!!!");
                Console.WriteLine($"Tus Ganancias son de {GXD}");
            }


        }
    }
}
