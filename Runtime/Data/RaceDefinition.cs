using System.Collections.Generic;
using UnityEngine;

namespace RPGFramework.Data
{
    [CreateAssetMenu(fileName = "RaceDefinition", menuName = "RPG Framework/Race Definition")]
    public class RaceDefinition : ScriptableObject
    {
        [Header("Datos Básicos")]
        public string raceName;
        [TextArea] public string description;
        public Sprite icon;

        [Header("Habilidades Raciales")]
        public List<AbilityDefinition> racialAbilities = new();     // Habilidades raciales
        public List<SubRaceDefinition> availableSubRaces;           // Sub razas permitidas
        public List<ClassDefinition> availableClasses;              // Clases permitidas
    }
}