using System.Collections.Generic;
using System.Data;
using Unity.VisualScripting;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    [SerializeField] Transform _inventory;
    List<InventorySlot> _slots = new();
    static public InventorySlot activeInventorySlot;
    static public List<(ItemScriptableObject, int)> activeSearchSlots;

    void Awake()
    {
        EventManager.TookItem += IsAddItem;
        for (int i = 0; i < _inventory.childCount; i++)
        {
            _slots.Add(_inventory.GetChild(i).GetComponent<InventorySlot>());
        }
    }

    void BuyItem()
    {
        foreach (InventorySlot slot in _slots)
        {

        }
    }

    bool IsAddItem(ItemScriptableObject item, int amount)
    {
        if (item.IsUnityNull() || amount == 0)
        {
            return false;
        }
        foreach(InventorySlot slot in _slots)
        {
            if (slot.item == item)
            {
                slot.amount += amount;
                return true;
            }
        }
        foreach(InventorySlot slot in _slots)
        {
            if (slot.item.IsUnityNull())
            {
                slot.item = item;
                slot.amount = amount;
                return true;
            }
        }
        return false;
    }
}