using UnityEngine;

namespace RPGFramework.Data
{
    public enum EffectType
    {
        Stun,
        Knockback,
        Heal,
        Sleep,
        Burn,
        Custom // Para lógica definida por el usuario
    }

    [CreateAssetMenu(fileName = "EffectDefinition", menuName = "RPG Framework/Effect Definition")]
    public class EffectDefinition : ScriptableObject
    {
        public string effectName;
        [TextArea] public string description;
        public Sprite icon;

        [Space(10)]
        public EffectType effectType;
        public float magnitude;
        public float duration;

        [Header("VFX & SFX")]
        public AudioClip soundEffect;
        public GameObject vfxPrefab;

        [Header("Custom")]
        public string customLogicKey;
    }
}