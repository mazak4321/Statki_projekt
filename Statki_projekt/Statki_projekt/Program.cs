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

            Tablica t = new Tablica();
            Uzytkownicy u = new Uzytkownicy();

            t.Dodaj(u.plansza, 3, 1, 3, 0);
            t.pokaz(u.plansza);
            //t.strzal(u.strzaly, u.plansza, 0, 0);
            Console.ReadKey();


           

            //for (int i = 0; i < 2; i++) 
            //{
            //    Console.Write(statki.statekwsp[0,i] + ", ");
            //}
            //Console.WriteLine();
            //for (int i = 0; i < 4; i++)
            //{
            //    Console.Write(statki.statekwsp[1, i] + ", ");
            //}
            //Console.WriteLine();
            //for (int i = 0; i < 6; i++)
            //{
            //    Console.Write(statki.statekwsp[2, i] + ", ");
            //}
            Console.WriteLine();

            Console.ReadKey();

        }
        
    }
}
