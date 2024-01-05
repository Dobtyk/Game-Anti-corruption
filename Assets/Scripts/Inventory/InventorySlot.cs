using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class InventorySlot : MonoBehaviour
{
    public ItemScriptableObject item;
    public int amount;
    public bool isEmpty = true;
    [SerializeField] GameObject _iconObject;
    [SerializeField] GameObject _amountObject;


    private void Start()
    {
        SetImage();
        SetAmount();
        SetEmpty();
        SwitchActive();
    }

    public void UseItem()
    {
        if (amount == 0)
        {
            return;
        }
        if (amount > 1)
        {
            amount -= 1;
            SetAmount();
        }
        else
        {
            amount = 0;
            SetEmpty();
            SwitchActive();
        }
    }

    void SetAmount()
    {
        if (amount <= 1)
        {
            _amountObject.GetComponent<TMP_Text>().text = "";
        }
        else
        {
            _amountObject.GetComponent<TMP_Text>().text = amount.ToString();
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

    void SetEmpty()
    {
        if (amount == 0)
        {
            isEmpty = true;
            item = null;
        }
        else
        {
            isEmpty = false;
        }
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
}
