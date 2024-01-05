using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class InteractCamera : InteractObject, IPointerClickHandler
{
    bool _canSetup = true;
    [SerializeField] Sprite _image;

    public void OnPointerClick(PointerEventData eventData)
    {
        if (eventData.pointerId == -1 && CanInteract && _canSetup && !InventoryManager.activeInventorySlot.IsUnityNull() && InventoryManager.activeInventorySlot.item.itemName == "Camera")
        {
            transform.GetComponent<SpriteRenderer>().sprite = _image;
            _canSetup = false;
            InventoryManager.activeInventorySlot.UseItem();
            InventoryManager.activeInventorySlot = null;
        }
    }
}