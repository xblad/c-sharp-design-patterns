using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuardiansOfTheCode
{
    public class Zombie : IEnemy
    {
        public int Health { get; set; }

        public int Level { get; }

        public int OvertimeDamage { get; set; }
        public int Armor { get; set; }
        public bool Paralyzed { get; set; }
        public int ParalyzedFor { get; set; }

        public Zombie(int health, int level, int armor)
        {
            Health = health;
            Armor = armor;
            Level = level;
        }

        public void Attack(PrimaryPlayer player)
        {
            Console.WriteLine($"Zombie attacks {player.Name}");
            player.Health -= 5;
        }

        public void Defend(PrimaryPlayer player)
        {
            Console.WriteLine($"Zombie tries to defend from {player.Name}");
            Health += 3;
        }
    }
}
