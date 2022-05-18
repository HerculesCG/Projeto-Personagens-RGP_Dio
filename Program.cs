using System;
using projeto.src.Entities;

namespace projeto
{
    class Program
    {
        static void Main(string[] args)
        {

            Wizard wizard = new Wizard("Jennica ", 23, "White Wizard");
            Knight arus = new Knight("Arus ", 23, "Knight");

            Console.WriteLine(wizard.Attack(1));
            Console.WriteLine(wizard.Attack(7));
        }
    }
}
