using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ItemType { PlayerEquipment, Evidence};
public class ItemScriptableObject : ScriptableObject
{
    public ItemType itemType;
    public string itemName;
    public string itemDescription;
    public Sprite image;
}
