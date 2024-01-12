using System.Collections.Generic;
using UnityEngine;

public class SlotInventoryPanel : MonoBehaviour
{         
    [SerializeField] GameObject _slotInventoryPanelButton;

    public void ClickOnSlotInventoryPanel()
    {
        var slot = _slotInventoryPanelButton.GetComponent<InventorySlot>();
        if (EventManager.OnTookItem(slot.item, 1))
        {
            if (slot.amount == 1)
            {
                slot.item = null;
                slot.amount = 0;
            }
            else if (slot.amount >= 1)
            {
                slot.amount -= 1;
            }
        }
        EventManager.OnChangedInventory();
    }
}