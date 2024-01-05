using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    public Transform inventory;
    List<InventorySlot> _slots = new List<InventorySlot>();
    static public InventorySlot activeInventorySlot;

    void Start()
    {
        for (int i = 0; i < inventory.childCount; i++)
        {
            _slots.Add(inventory.GetChild(i).GetComponent<InventorySlot>());
        }
    }

    void BuyItem()
    {
        foreach (InventorySlot slot in _slots)
        {
            
        }
    }
}