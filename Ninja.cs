using System;

namespace Wizard_Ninja_Samurai
{
    public class Ninja : Human
    {
        public Ninja(string name) : base(name)
        {
            Name = name;
            Dexterity = 175;
        }

        public override int Attack(Human target)
        {
            Random r = new Random();
            int critChance = r.Next(100);
            bool isCrit = critChance >= 80 ? true : false; // 20% chance to be a critical hit (2/10 chance)

            int dmg = 0;
            if (isCrit)
            {
                Console.WriteLine("Critical hit!");
                dmg += (Dexterity * 5) + 10;
            }
            else
            {
                dmg += (Dexterity * 5);
            }

            this.health += dmg;
            target.Health -= dmg;
            return target.Health;
        }

        public virtual int Lifesteal(Human target)
        {
            target.Health -= 5;
            this.health += 5;
            return target.Health;
        }
    }
}