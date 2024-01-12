using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SearchTable : InteractObject, IPointerClickHandler
{
    [SerializeField] ItemScriptableObject _camera;
    [SerializeField] GameObject _panel;
    [SerializeField] Transform _inventoryPanel;
    List<InventorySlot> _slotsPanel = new();
    List<(ItemScriptableObject, int)> _slotsTable = new();

    void Awake()
    {
        for (int i = 0; i < _inventoryPanel.childCount; i++)
        {
            _slotsPanel.Add(_inventoryPanel.GetChild(i).GetComponent<InventorySlot>());
        }
        StartItems();
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (eventData.pointerId == -1 && CanInteract)
        {
            EventManager.OnClickedOnSearch(true);
            EventManager.OnPlayerInteracted(true);
            loadItems();
            _panel.SetActive(true);
            InventoryManager.activeSearchSlots = _slotsTable;
        }
    }

    void loadItems()
    {
        for (var i = 0; i < _slotsPanel.Count; i++)
        {
            (_slotsPanel[i].item, _slotsPanel[i].amount) = (_slotsTable[i].Item1, _slotsTable[i].Item2);
        }
    }

    void StartItems()
    {
        _slotsTable.Add((_camera, 2));
        _slotsTable.Add((null, 0));
        _slotsTable.Add((null, 0));
        _slotsTable.Add((null, 0));
        _slotsTable.Add((null, 0));
        _slotsTable.Add((null, 0));
        _slotsTable.Add((null, 0));
        _slotsTable.Add((null, 0));
        _slotsTable.Add((null, 0));
    }
}