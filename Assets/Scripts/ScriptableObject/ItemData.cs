using JetBrains.Annotations;
using System;
using UnityEngine;

public enum ItemType
{
    Consumable,
    Resource
}

public enum ConsumableType
{
    Health,
    Hunger,
    Stamina,
    Stat
}

[Serializable]
public class ItemDataConsumable
{
    public ConsumableType type;
    public float value;
}

public enum StatType
{
    Speed,
    Jump
}

[Serializable]
public class PlayerStatData
{
    public StatType type;
    public float value;
}

[CreateAssetMenu(fileName = "Item" , menuName = "New Item")]
public class ItemData : ScriptableObject
{
    [Header("Info")]
    public string displayName;
    public string description;
    public ItemType type;
    public Sprite icon;
    public GameObject dropPrefab;

    [Header("Stacking")]
    public bool canStack;
    public int maxStackAmount;

    [Header("Consumable")]
    public ItemDataConsumable[] consumables;

    [Header("Stat")]
    public PlayerStatData[] stats;
}
