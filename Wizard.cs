using System;

namespace Wizard_Ninja_Samurai
{
    public class Wizard : Human
    {
        public Wizard(string name) : base(name)
        {
            Name = name;
            Intelligence = 25;
            health = 50;
        }

        public override int Attack(Human target)
        {
            int dmg = Intelligence * 5;
            this.health += dmg;
            target.Health -= dmg;
            return target.Health;
        }

        public virtual int Heal(Human target)
        {
            int heal = Intelligence * 10;
            target.Health += heal;
            return target.Health;
        }
    }
}