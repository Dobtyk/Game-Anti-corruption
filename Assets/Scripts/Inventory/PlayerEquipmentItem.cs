using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Player Equipment Item", menuName = "Inventory/Items/New Player Equipment Item")]
public class PlayerEquipmentItem : ItemScriptableObject
{
    public int price;

    void Start()
    {
        itemType = ItemType.PlayerEquipment;
    }
}
