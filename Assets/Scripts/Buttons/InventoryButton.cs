<<<<<<< HEAD
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
=======
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
>>>>>>> origin/master

public class InventoryButton : MonoBehaviour
{
    [SerializeField] GameObject _inventory;
    [SerializeField] Transform _buttonInventory;
<<<<<<< HEAD
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
=======
    [SerializeField] float _cameraShift;
>>>>>>> origin/master

    public void Switchinventory()
    {
        if (_inventory.activeSelf)
        {
<<<<<<< HEAD
            _buttonInventory.localPosition = _firstPosition;
=======
            _buttonInventory.localPosition = new Vector3(_buttonInventory.localPosition.x - _cameraShift, _buttonInventory.localPosition.y, _buttonInventory.localPosition.z);
>>>>>>> origin/master
            _inventory.SetActive(false);
        }
        else
        {
<<<<<<< HEAD
            _buttonInventory.localPosition = _lastPosition;
=======
            _buttonInventory.localPosition = new Vector3(_buttonInventory.localPosition.x + _cameraShift, _buttonInventory.localPosition.y, _buttonInventory.localPosition.z);
>>>>>>> origin/master
            _inventory.SetActive(true);
        }
    }
}
