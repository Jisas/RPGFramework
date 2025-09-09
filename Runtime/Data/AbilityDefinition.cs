using System.Collections.Generic;
using UnityEngine;

namespace RPGFramework.Data
{
    public enum AbilityTargetType
    {
        Self,
        SingleEnemy,
        MultipleEnemies,
        Allies,
        AreaOfEffect,
        Environment
    }

    [CreateAssetMenu(menuName = "RPG Framework/Ability Definition")]
    public class AbilityDefinition : ScriptableObject
    {
        public string abilityName;
        [TextArea] public string description;
        public Sprite icon;

        [Header("Caracteristicas de la Habilidad")]
        public DamageTypeDefinition damageType;
        public float baseDamage;
        public float cooldown; // En segundos
        public float manaCost;
        public float staminaCost;

        [Header("Alcance y Area")]
        public float range = 1f; // Alcance en unidades del juego
        public float areaRadius = 0f; // Si es AOE, radio en unidades

        [Header("Targeting")]
        public AbilityTargetType targetType;

        [Header("Efectos Adicionales")]
        public List<EffectDefinition> effects = new List<EffectDefinition>();

        [Header("Animaciones y Efectos")]
        string animationTrigger;

        [Header("VFX y SFX")]
        public AudioClip soundEffect;
        public GameObject vfxPrefab;
    }
}