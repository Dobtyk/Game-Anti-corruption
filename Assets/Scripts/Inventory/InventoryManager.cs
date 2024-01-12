<<<<<<< HEAD
using System.Collections.Generic;
using System.Data;
using Unity.VisualScripting;
=======
using System.Collections;
using System.Collections.Generic;
>>>>>>> origin/master
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
<<<<<<< HEAD
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
=======
    public Transform inventory;
    List<InventorySlot> _slots = new List<InventorySlot>();
    static public InventorySlot activeInventorySlot;

    void Start()
    {
        for (int i = 0; i < inventory.childCount; i++)
        {
            _slots.Add(inventory.GetChild(i).GetComponent<InventorySlot>());
>>>>>>> origin/master
        }
    }

    void BuyItem()
    {
        foreach (InventorySlot slot in _slots)
        {
<<<<<<< HEAD

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
=======
            
        }
    }
>>>>>>> origin/master
}