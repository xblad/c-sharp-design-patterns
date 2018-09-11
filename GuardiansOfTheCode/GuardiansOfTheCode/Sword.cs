using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuardiansOfTheCode
{
    public class Sword : IWeapon
    {
        public int Damage { get; }
        public int ArmorDamage { get; }

        public Sword(int damage, int armorDamage)
        {
            Damage = damage;
            ArmorDamage = armorDamage;
        }

        public void Use(IEnemy enemy)
        {
            enemy.Health -= Damage;
            enemy.Armor -= ArmorDamage;
        }
    }
}
