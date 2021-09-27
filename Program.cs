using System;

namespace Wizard_Ninja_Samurai
{
    class Program
    {
        static void Main(string[] args)
        {
            Wizard Gandalf = new Wizard("Gandalf");

            Ninja Gaiden = new Ninja("Gaiden");

            Samurai Jack = new Samurai("Jack");

            Gandalf.Attack(Gaiden);
            Gaiden.Attack(Jack);
            Jack.Meditate();
            Gandalf.GetInfo();
            Gaiden.GetInfo();
            Jack.GetInfo();
        }
    }
}
