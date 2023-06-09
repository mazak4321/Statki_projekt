﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

using System.Linq.Expressions;

using System.Text;
using System.Threading.Tasks;

namespace Statki_projekt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {

                Tablica t = new Tablica();


                List<Uzytkownicy> gracze = new List<Uzytkownicy>() { new Uzytkownicy(1, new int[5, 5], new int[5, 5], new List<Statki>(), new int[] { 0, 0, 0 }), new Uzytkownicy(2, new int[5, 5], new int[5, 5], new List<Statki>(), new int[] { 0, 0, 0 }) };


                int i = 1;
                int j = 0;
                bool wygrana = false;


                t.Start(gracze);
                while (!wygrana)
                {
                    if (i == 1)
                    {
                        i = 0;
                        j = 1;
                    }
                    else
                    {
                        i = 1;
                        j = 0;
                    }
                    Console.ReadKey();
                    Console.Clear();
                    t.Strzal(gracze[i], gracze[j]);
                    wygrana = t.Wygrana(gracze[i]);

                }
                t.Pokaz(gracze[i].Strzaly);
                Console.WriteLine("\nWygrał gracz: " + gracze[i].ID);
                Console.ReadKey();

            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
        }
    }
}
