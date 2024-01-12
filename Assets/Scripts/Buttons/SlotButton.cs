using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SlotButton : MonoBehaviour
{
    [SerializeField] InventoryButton _inventoryButton;
    public void ClickOnSlot() // –≈À»«Œ¬¿ÕŒ “ŒÀ‹ Œ ƒÀﬂ  ¿Ã≈–€
    {
        var clickedObject = EventSystem.current.currentSelectedGameObject;
        var slot = clickedObject.GetComponent<InventorySlot>();
        if (!slot.isEmpty && slot.item.itemType == ItemType.PlayerEquipment)
        {
            _inventoryButton.Switchinventory();
            InventoryManager.activeInventorySlot = slot;
        }
    }
}
