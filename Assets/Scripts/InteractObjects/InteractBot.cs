using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

public class InteractBot : InteractObject, IPointerClickHandler, IPointerEnterHandler, IPointerExitHandler
{
<<<<<<< HEAD
    [SerializeField] string _botName;
    [SerializeField] GameObject _botNameUp;
    [SerializeField] Dialogue[] _dialogues;
    [SerializeField] DialogueManager _dialogueManager;

    void Awake()
    {
        _botNameUp.GetComponent<TMP_Text>().text = _botName;
=======
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
>>>>>>> origin/master
    }

    public void OnPointerClick(PointerEventData eventData)
    {
<<<<<<< HEAD
        if (eventData.pointerId == -1 && CanInteract && !GameManager.IsPlayerInteract)
        {
            EventManager.OnPlayerInteracted(true);
            EventManager.OnStartedCommunication();
=======
        if (eventData.pointerId == -1 && CanInteract && !_dialogueManager.IsCommunicationStart)
        {
            _dialogueManager.StartCommunication();
>>>>>>> origin/master
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
<<<<<<< HEAD
        _botNameUp.SetActive(false);
=======
        _botName.SetActive(false);
>>>>>>> origin/master
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
<<<<<<< HEAD
        _botNameUp.SetActive(true);
=======
        _botName.SetActive(true);
>>>>>>> origin/master
    }
}
