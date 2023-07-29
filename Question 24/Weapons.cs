using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_24
{
    using System;

    public class Weapon
    {
        public string Name { get; }
        public double BaseDamage { get; }

        public Weapon(string name, double baseDamage)
        {
            Name = name;
            BaseDamage = baseDamage;
        }

        public double CalculateDamage(int playerLevel, int diceRoll)
        {
            double damage = BaseDamage;
            double damageIncreasePercentage = 0;

            if ((Name == "Sword" || Name == "Staff" || Name == "Dagger") && playerLevel >= 2)
            {
                if (playerLevel == 2)
                    damageIncreasePercentage += 0.4;
                else if (playerLevel == 3)
                    damageIncreasePercentage += 0.6;
                else if (playerLevel == 4)
                    damageIncreasePercentage += 0.8;
                else if (playerLevel >= 5)
                    damageIncreasePercentage += 1.0;
            }

            switch (diceRoll)
            {
                case 2:
                    damageIncreasePercentage += 0.2;
                    break;
                case 3:
                    damageIncreasePercentage += 0.3;
                    break;
                case 4:
                    damageIncreasePercentage += 0.4;
                    break;
                case 5:
                    damageIncreasePercentage += 0.5;
                    break;
                case 6:
                    damageIncreasePercentage += 0.6;
                    break;
                default:
                    break;
            }

            damage *= (1 + damageIncreasePercentage);

            return damage;
        }
    }

}
