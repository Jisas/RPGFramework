using System.Collections.Generic;
using UnityEngine;

namespace RPGFramework.Data
{
    [CreateAssetMenu(fileName = "WeaponDefinition", menuName = "RPG Framework/Weapon Definition")]
    public class WeaponDefinition : ScriptableObject
    {
        public string weaponName;
        public Sprite icon;

        [Header("Damage")]
        public float baseDamage;
        public DamageTypeDefinition damageType;

        [Header("Adicional effects")]
        public List<EffectDefinition> hitEffects = new List<EffectDefinition>();
    }
}