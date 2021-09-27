using System;

namespace Wizard_Ninja_Samurai
{
    public class Samurai : Human
    {
        private int startingHealth;
        public int StartingHealth
        {
            get { return startingHealth; }
        }
        public Samurai(string name) : base(name)
        {
            Name = name;
            health = 200;
            startingHealth = health;
        }

        public override int Attack(Human target)
        {
            int targetHealthCheck = base.Attack(target);
            if (targetHealthCheck <= 50)
                target.Health = 0;
            return target.Health;
        }

        public virtual int Meditate()
        {
            health += Intelligence * 10;
            return Health;
        }
    }
}