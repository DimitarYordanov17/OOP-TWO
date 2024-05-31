using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ArenaGame.Weapons
{
    public class MagicWand : IWeapon
    {
        public string Name { get; set; }

        public double AttackDamage { get; private set; }

        public double BlockingPower { get; private set; }

        private Random random;

        public MagicWand(string name)
        {
            Name = name;
            AttackDamage = 15; // Base attack damage
            BlockingPower = 5; // Base blocking power
            random = new Random();
        }

        public double Attack()
        {
            // MagicWand has a variety of unpredictable attack effects
            double damage = AttackDamage;

            double probability = random.NextDouble();
            if (probability < 0.10)
            {
                // Double damage
                damage *= 2;
            }
            else if (probability < 0.20)
            {
                // Half damage
                damage *= 0.5;
            }
            else if (probability < 0.40)
            {
                // No damage, but blocks the next attack completely
                BlockingPower = 100;
                return 0;
            }
            else if (probability < 0.50)
            {
                // Extra attack damage
                damage += 20;
            }

            return damage;
        }
    }
}