using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

public class InteractBot : InteractObject, IPointerClickHandler, IPointerEnterHandler, IPointerExitHandler
{
    public string botName;
    [SerializeField] GameObject _botName;
    [SerializeField] Dialogue[] _dialogues;
    [SerializeField] DialogueManager _dialogueManager;


    void Start()
    {
        _botName.GetComponent<TMP_Text>().text = botName;
    }
    void Update()
    {
        if (!CanInteract)
        {
            _dialogueManager.EndCommunication();
        }
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (eventData.pointerId == -1 && CanInteract && !_dialogueManager.IsCommunicationStart)
        {
            _dialogueManager.StartCommunication();
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
        _botName.SetActive(false);
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        _botName.SetActive(true);
    }
}
