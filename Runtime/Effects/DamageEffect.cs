using UnityEngine;
using System;

namespace RPGFramework
{
    public class DamageEffect : IEffect<Enemy>
    {
        // Ejecuci�n del efecto
        public void Apply(Enemy target)
        {
            if (target == null) return;

            // L�gica del efecto
        }

        public void Cancel() { /*noop*/ }
    }
}