using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryButton : MonoBehaviour
{
    [SerializeField] GameObject _inventory;
    [SerializeField] Transform _buttonInventory;
    [SerializeField] float _cameraShift;

    public void Switchinventory()
    {
        if (_inventory.activeSelf)
        {
            _buttonInventory.localPosition = new Vector3(_buttonInventory.localPosition.x - _cameraShift, _buttonInventory.localPosition.y, _buttonInventory.localPosition.z);
            _inventory.SetActive(false);
        }
        else
        {
            _buttonInventory.localPosition = new Vector3(_buttonInventory.localPosition.x + _cameraShift, _buttonInventory.localPosition.y, _buttonInventory.localPosition.z);
            _inventory.SetActive(true);
        }
    }
}
