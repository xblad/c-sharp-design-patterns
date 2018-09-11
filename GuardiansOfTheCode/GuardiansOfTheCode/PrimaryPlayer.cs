using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuardiansOfTheCode
{
    public sealed class PrimaryPlayer
    {
        public string Name { get; set; }
        public int Level { get; set; }

        public IWeapon Weapon { get; set; }
        public int Health { get; set; }
        public int Armor { get; set; }

        public static readonly PrimaryPlayer Instance;

        static PrimaryPlayer()
        {
            Console.Write("Your name: ");
            Instance = new PrimaryPlayer()
            {
                Name = Console.ReadLine(),
                Level = 1,
                Health = 100,
                Armor = 25,
            };
        }

        private PrimaryPlayer() { }
    }
}
