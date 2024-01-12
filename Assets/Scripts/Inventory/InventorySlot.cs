using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class InventorySlot : MonoBehaviour
{
    public ItemScriptableObject item;
    public int amount;
    [SerializeField] GameObject _iconObject;
    [SerializeField] GameObject _amountObject;


    private void Awake()
    {
        EventManager.ChangedInventory += Update;
        Update();
    }

    public void UseItem()
    {
        switch (amount)
        {
            case > 1:
                amount -= 1;
                SetAmount();
                break;
            case 1:
                amount = 0;
                SwitchActive();
                break;
        }
    }

    void SetAmount()
    {
        switch (amount)
        {
            case <= 1:
                _amountObject.GetComponent<TMP_Text>().text = "";
                break;
            default:
                _amountObject.GetComponent<TMP_Text>().text = amount.ToString();
                break;
        }
    }

    void SetImage()
    {
        if (item.IsUnityNull())
        {
            return;
        }
        _iconObject.GetComponent<UnityEngine.UI.Image>().sprite = item.image;
    }

    void SwitchActive()
    {
        bool active;
        if (amount == 0)
        {
            active = false;
        }
        else
        {
            active = true;
        }
        _iconObject.SetActive(active);
        _amountObject.SetActive(active);
    }

    void Update()
    {
        SetImage();
        SetAmount();
        SwitchActive();
    }
}
