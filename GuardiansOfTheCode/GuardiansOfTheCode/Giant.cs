using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuardiansOfTheCode
{
    public class Giant : IEnemy
    {
        public int Health { get; set; }

        public int Level { get; }

        public int OvertimeDamage { get; set; }
        public int Armor { get; set; }
        public bool Paralyzed { get; set; }
        public int ParalyzedFor { get; set; }

        public Giant(int health, int level, int armor)
        {
            Health = health;
            Armor = armor;
            Level = level;
        }

        public void Attack(PrimaryPlayer player)
        {
            Console.WriteLine($"Giant is attacking {player.Name}");
            player.Health -= 10;
        }

        public void Defend(PrimaryPlayer player)
        {
            Console.WriteLine($"Giant is defending from {player.Name}");
            Health += 5;
        }
    }
}
