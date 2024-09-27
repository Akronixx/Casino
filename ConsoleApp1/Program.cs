using System;
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
            int aciertoN=0,acierto=0,pd=0,sd=0,td=0,ele=-1,docena=0, num = rnd.Next(1, 37);
            string[] colores = { "ROJO", "NEGRO" };
            string op;
            Random random = new Random();
            int indiceAleatorio = random.Next(0, colores.Length);
            string colorele, colorAleatorio = colores[indiceAleatorio];
            Console.WriteLine("[================================RULETA GANADORA================================]");
            Console.WriteLine(num);
            Console.WriteLine(colorAleatorio);
            //Intento 1
            Console.WriteLine("¿Desea elegir un número?(S/N)");
            op=Console.ReadLine().ToUpper();
            while(op!="S" && op!="N")
            {
                Console.WriteLine("Ingresé una opción valida (S/N)");
                op = Console.ReadLine().ToUpper();
            }    
            if(op=="S")
            {
                aciertoN = aciertoN+1;
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
                }
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
                while (docena !=1 && docena != 2 && docena!=3)
                {
                    Console.WriteLine("Elija una docena valida (1-2-3):");
                    docena = int.Parse(Console.ReadLine());
                }
                if (num  >= 0 && num < 13)
                {
                    Console.WriteLine("Primera docena");
                    pd = pd + 1;
                }
                else if (num > 12 && num < 25)
                {
                    Console.WriteLine("Segunda docena");
                    sd = sd + 1;
                }
                else if (num > 24 && num < 37)
                {
                    Console.WriteLine("Tercera docena");
                    td = td + 1;
                }
                switch(docena)
                {
                    case 1:
                        if (num >= 0 && num < 13)
                        {
                            Console.WriteLine("Primera docena");
                            pd = pd + 1;
                        }
                        break;
                    case 2:
                        if (num > 12 && num < 25)
                        {
                            Console.WriteLine("Segunda docena");
                            sd = sd + 1;
                        }
                        break;
                    case 3:
                        if (num > 24 && num < 37)
                        {
                            Console.WriteLine("Tercera docena");
                            td = td + 1;
                        }
                        break;
                }
                if (pd == 2 || sd == 2 || td == 2)
                {
                    acierto = acierto + 1;
                }
            }
            else
            {
                Console.WriteLine("Estas perdiendo plata crack");
            }

            //docena
            Console.WriteLine(num);
            Console.WriteLine(colorAleatorio);
            if (acierto == aciertoN)
            {
                Console.WriteLine("Ganaste");
            }
            else if (acierto < aciertoN)
            {
                Console.WriteLine("Perdiste");
            }
        }
    }
}
