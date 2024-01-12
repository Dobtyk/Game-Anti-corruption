using System;

public class EventManager
{
    public static event Action<bool> ClickedOnSlot;
    public static event Action StartedCommunication;
    public static event Action EndedCommunication;
    public static event Action<bool> ClickedOnSearch;
    public static event Action<bool> PlayerInteracted;
    public static event Action<bool> ClickedOnSearchBackButton;
    public static event Func<ItemScriptableObject, int, bool> TookItem;
    public static event Action ChangedInventory;

    public static void OnClickedOnSlot(bool @switch)
    {
        ClickedOnSlot?.Invoke(@switch);
    }

    public static void OnStartedCommunication()
    {
        StartedCommunication?.Invoke();
    }

    public static void OnEndedCommunication()
    {
        EndedCommunication?.Invoke();
    }

    public static void OnClickedOnSearch(bool @switch)
    {
        ClickedOnSearch?.Invoke(@switch);
    }

    public static void OnPlayerInteracted(bool isInteract)
    {
        PlayerInteracted?.Invoke(isInteract);
    }

    public static void OnClickedOnSearchBackButton(bool @switch)
    {
        ClickedOnSearchBackButton?.Invoke(@switch);
    }

    public static bool OnTookItem(ItemScriptableObject item, int amount)
    {
        return (bool)TookItem?.Invoke(item, amount);
    }

    public static void OnChangedInventory()
    {
        ChangedInventory?.Invoke();
    }
}
