using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuardiansOfTheCode
{
    public interface IWeapon
    {
        int Damage { get; }
        void Use(IEnemy enemy);
    }
}
