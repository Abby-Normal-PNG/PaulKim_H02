using System;
using UnityEngine;

public enum Rarity { Common, Uncommon, Rare, Unprinted, Gamer, GlowInTheDark, Unique  }
public enum Slot { Head, Earlobe, Chest, RightHand, LeftHand, Pelvis, Shins, Feet, Potion }
[CreateAssetMenu(menuName = "Equipment")]
[Serializable]
public class Equipment : ScriptableObject
{
    public Rarity rarity;
    public string itemName = "";
    public Slot slot;
    public int value = 1;
}
