using System.Collections.Generic;
using RPGFramework.Data;
using UnityEngine;
using System;

public class DefaultEffectRunner : IEffectExecutor
{
    // Diccionario de key => acción
    private static Dictionary<string, Action<GameObject, EffectDefinition>> _effectExecutors = new();

    // Registro de lógica personalizada (lo hace el usuario en el setup de su juego)
    public static void RegisterEffect(string key, Action<GameObject, EffectDefinition> executor)
    {
        _effectExecutors[key] = executor;
    }

    // Ejecución del efecto
    public static void ApplyEffect(GameObject target, EffectDefinition effect)
    {
        if (effect == null) return;

        // Si hay lógica personalizada, ejecuta
        if (!string.IsNullOrEmpty(effect.customLogicKey) && _effectExecutors.TryGetValue(effect.customLogicKey, out var executor))
        {
            executor(target, effect);
        }
        else
        {
            // Lógica por defecto, usando effectType
            switch (effect.effectType)
            {
                case EffectType.Stun:
                    // ... stunear target ...
                    break;
                    // Otros builtin
            }
        }
    }
}