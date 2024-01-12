using UnityEngine;
using UnityEngine.EventSystems;

public class GameManager : MonoBehaviour
{
    public static bool IsPlayerInteract;

    void Awake()
    {
        EventManager.PlayerInteracted += SwitchPlayerMove;
    }

    void SwitchPlayerMove(bool isInteract)
    {
        if (isInteract)
        {
            IsPlayerInteract = true;
        }
        else
        {
            IsPlayerInteract = false;
        }
    }
}
