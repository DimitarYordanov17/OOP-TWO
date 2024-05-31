using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame.Heroes
{
    public class Mage : Hero
    {
        public Mage(string name, double armor, double strength, IWeapon weapon) : 
            base(name, armor, strength, weapon)
        {
        }

        public override double Attack()
        {
            double damage = base.Attack();

            // Mages have a chance to cast a powerful spell that adds extra damage
            double probability = random.NextDouble();
            if (probability < 0.15)
            {
                damage += 30;
            }
            return damage;
        }
    }
}