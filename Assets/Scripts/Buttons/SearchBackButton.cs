using System.Collections.Generic;
using UnityEngine;

public class SearchBackButton : MonoBehaviour
{
    [SerializeField] GameObject _panel;
    [SerializeField] Transform _inventoryPanel;
    List<InventorySlot> _slotsPanel = new();

    void Awake()
    {
        for (int i = 0; i < _inventoryPanel.childCount; i++)
        {
            _slotsPanel.Add(_inventoryPanel.GetChild(i).GetComponent<InventorySlot>());
        }
    }
    public void ClickOnBack()
    {
        EventManager.OnClickedOnSearchBackButton(false);
        _panel.SetActive(false);
        EventManager.OnPlayerInteracted(false);
        SaveItems();
        InventoryManager.activeSearchSlots = null;
    }

    void SaveItems()
    {
        for (var i = 0; i < InventoryManager.activeSearchSlots.Count; i++)
        {
            InventoryManager.activeSearchSlots[i] = (_slotsPanel[i].item, _slotsPanel[i].amount);
        }
    }
}
