using Unity.VisualScripting;
using UnityEngine;

public class SlotInventoryButton : MonoBehaviour
{
    [SerializeField] GameObject _slotButton;
    public void ClickOnSlot() // ���������� ������ ��� ������
    {
        if (!InventoryManager.activeSearchSlots.IsUnityNull())
        {

        }
        else
        {
            var slot = _slotButton.GetComponent<InventorySlot>();
            if (slot.amount != 0 && slot.item.itemType == ItemType.PlayerEquipment)
            {
                EventManager.OnClickedOnSlot(false);
                InventoryManager.activeInventorySlot = slot;
            }
        }
    }
}
