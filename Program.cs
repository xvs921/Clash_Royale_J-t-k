using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppszornyharcos
{
    class Program
    {
        static void Main(string[] args)
        {
            int szornyhp = 100;
            int harcoshp = 100;
            int kockadobas;
            int szornysebzes;
            int harcossebzes;
            char c; //akar-e még játszani
            Random r = new Random();
            do
            {
                szornysebzes = 0;
                harcossebzes = 0;
                for (int i = 0; i < 3; i++)
                {
                    kockadobas = r.Next(1, 7);
                    szornysebzes += kockadobas;
                }
                Console.WriteLine("A szörny összesen {0} hp-val sebez", szornysebzes);
                harcoshp -= szornysebzes;
                Console.WriteLine("A harcosnak ennyi élete maradt: {0}", harcoshp);
                Console.ReadKey();
                Console.Clear();
                do
                {
                    kockadobas = r.Next(1, 7);
                    Console.WriteLine("A dobása: {0}", kockadobas);
                    if (kockadobas==1)
                    {
                        harcossebzes = 0;
                        Console.WriteLine("Ebben a körben a harcos nem tudott sebezni.");
                        c = 'n';
                        Console.ReadKey();
                    }
                    else
                    {
                        harcossebzes += kockadobas;
                        Console.WriteLine("{0} hp-val tud sebezni", harcossebzes);
                        Console.WriteLine("Szeretne még egyet dobni? i/n");
                        c = Convert.ToChar(Console.ReadLine());
                    }
                }
                while (c=='i');
                Console.Clear();
                szornyhp -= harcossebzes;
                Console.WriteLine("A szörny hp-ja {0}\nA harcos hp-ja {1}", szornyhp, harcoshp);
                Console.ReadKey();
                Console.Clear();
            }
            while (!(szornyhp<=0 || harcoshp<=0));
            if (harcoshp>0 && szornyhp<=0)
            {
                Console.WriteLine("A harcos győzött");
            }
            else if (szornyhp>0 &&harcoshp<=0)
            {
                Console.WriteLine("A szörny győzött");
            }
            else
            {
                Console.WriteLine("Döntetlen");
            }


        }
    }
}
