using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame.Heroes
{
    public class Jester : Hero
    {
        public Jester(string name, double armor, double strength, IWeapon weapon) : 
            base(name, armor, strength, weapon)
        {
        }

        public override double Attack()
        {
            double damage = base.Attack();

            // Jesters have a completely unpredictable attack with varied outcomes
            double probability = random.NextDouble();
            if (probability < 0.05)
            {
                // Critical hit with massive damage
                damage *= 5;
            }
            else if (probability < 0.10)
            {
                // Weak attack, does only half damage
                damage *= 0.5;
            }
            else if (probability < 0.15)
            {
                // Self-inflicted damage
                this.Strength -= 10;
                return 0;
            }
            else if (probability < 0.20)
            {
                // Heals themselves slightly instead of attacking
                this.Strength += 10;
                return 0;
            }
            else if (probability < 0.25)
            {
                // No attack, just a funny move
                return 0;
            }
            // Normal attack otherwise
            return damage;
        }
    }
}