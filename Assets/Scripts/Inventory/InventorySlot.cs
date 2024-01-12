using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class InventorySlot : MonoBehaviour
{
    public ItemScriptableObject item;
    public int amount;
<<<<<<< HEAD
=======
    public bool isEmpty = true;
>>>>>>> origin/master
    [SerializeField] GameObject _iconObject;
    [SerializeField] GameObject _amountObject;


<<<<<<< HEAD
    private void Awake()
    {
        EventManager.ChangedInventory += Update;
        Update();
=======
    private void Start()
    {
        SetImage();
        SetAmount();
        SetEmpty();
        SwitchActive();
>>>>>>> origin/master
    }

    public void UseItem()
    {
<<<<<<< HEAD
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
=======
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
>>>>>>> origin/master
        }
    }

    void SetAmount()
    {
<<<<<<< HEAD
        switch (amount)
        {
            case <= 1:
                _amountObject.GetComponent<TMP_Text>().text = "";
                break;
            default:
                _amountObject.GetComponent<TMP_Text>().text = amount.ToString();
                break;
        }
=======
        if (amount <= 1)
        {
            _amountObject.GetComponent<TMP_Text>().text = "";
        }
        else
        {
            _amountObject.GetComponent<TMP_Text>().text = amount.ToString();
        }

>>>>>>> origin/master
    }

    void SetImage()
    {
        if (item.IsUnityNull())
        {
            return;
        }
        _iconObject.GetComponent<UnityEngine.UI.Image>().sprite = item.image;
    }

<<<<<<< HEAD
=======
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

>>>>>>> origin/master
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
<<<<<<< HEAD

    void Update()
    {
        SetImage();
        SetAmount();
        SwitchActive();
    }
=======
>>>>>>> origin/master
}
