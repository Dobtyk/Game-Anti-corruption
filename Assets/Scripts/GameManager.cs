using UnityEngine;
using UnityEngine.EventSystems;

public class GameManager : MonoBehaviour
{
<<<<<<< HEAD
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
=======

>>>>>>> origin/master
}
