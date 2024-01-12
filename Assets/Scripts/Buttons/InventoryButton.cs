using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class InventoryButton : MonoBehaviour
{
    [SerializeField] GameObject _inventory;
    [SerializeField] Transform _buttonInventory;
    [SerializeField] float _buttonInventoryShift;
    Vector3 _firstPosition;
    Vector3 _lastPosition;

    void Awake()
    {
        EventManager.ClickedOnSlot += Switchinventory;
        EventManager.ClickedOnSearch += Switchinventory;
        EventManager.ClickedOnSearchBackButton += Switchinventory;
        _firstPosition = new Vector3(_buttonInventory.localPosition.x, _buttonInventory.localPosition.y, _buttonInventory.localPosition.z);
        _lastPosition = new Vector3(_buttonInventory.localPosition.x + _buttonInventoryShift, _buttonInventory.localPosition.y, _buttonInventory.localPosition.z);
    }
    public void Switchinventory(bool @switch)
    {
        if (@switch)
        {
            _buttonInventory.localPosition = _lastPosition;
            _inventory.SetActive(true);
        }
        else
        {
            _buttonInventory.localPosition = _firstPosition;
            _inventory.SetActive(false);
        }
    }

    public void Switchinventory()
    {
        if (_inventory.activeSelf)
        {
            _buttonInventory.localPosition = _firstPosition;
            _inventory.SetActive(false);
        }
        else
        {
            _buttonInventory.localPosition = _lastPosition;
            _inventory.SetActive(true);
        }
    }
}
