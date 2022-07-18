using System;
using DIO.src.Entities;

namespace Dio
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight hero = new Knight("Arus", 23, "Knight");
            Wizard wizard = new Wizard("Jennica", 23, "White Wizard");
            Ninja ninja = new Ninja("Wedge", 23, "Ninja");
            BlackWizard blackWizard = new BlackWizard("Seila", 32, "Black Wizard");
                    
            System.Console.WriteLine(hero.Attack());
            System.Console.WriteLine(ninja.Attack());
            System.Console.WriteLine(wizard.Attack(1));
            System.Console.WriteLine(blackWizard.Attack(7));
        }
    }
}
