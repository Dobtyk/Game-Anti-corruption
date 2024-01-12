using System.Collections.Generic;
using UnityEngine;

public class SearchTakeAllButton : MonoBehaviour
{
    [SerializeField] Transform _inventoryPanel;
    List<InventorySlot> _slotsinventoryPanel = new();

    void Awake()
    {
        for (int i = 0; i < _inventoryPanel.childCount; i++)
        {
            _slotsinventoryPanel.Add(_inventoryPanel.GetChild(i).GetComponent<InventorySlot>());
        }
    }

    public void ClickOnTakeAll()
    {
        for (var i = 0; i < InventoryManager.activeSearchSlots.Count; i++)
        {
            if (EventManager.OnTookItem(InventoryManager.activeSearchSlots[i].Item1, InventoryManager.activeSearchSlots[i].Item2))
            {
                InventoryManager.activeSearchSlots[i] = (null, 0);
                _slotsinventoryPanel[i].item = null;
                _slotsinventoryPanel[i].amount = 0;
            }
        }
        EventManager.OnChangedInventory();
    }
}
