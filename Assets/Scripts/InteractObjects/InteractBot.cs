using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

public class InteractBot : InteractObject, IPointerClickHandler, IPointerEnterHandler, IPointerExitHandler
{
    [SerializeField] string _botName;
    [SerializeField] GameObject _botNameUp;
    [SerializeField] Dialogue[] _dialogues;
    [SerializeField] DialogueManager _dialogueManager;

    void Awake()
    {
        _botNameUp.GetComponent<TMP_Text>().text = _botName;
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (eventData.pointerId == -1 && CanInteract && !GameManager.IsPlayerInteract)
        {
            EventManager.OnPlayerInteracted(true);
            EventManager.OnStartedCommunication();
            foreach (var dialogue in _dialogues)
            {
                if (dialogue._nameDialogue == "Приветствие")
                {
                    _dialogueManager.StartDialogue(dialogue);
                    break;
                }
            }
        }
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        _botNameUp.SetActive(false);
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        _botNameUp.SetActive(true);
    }
}
