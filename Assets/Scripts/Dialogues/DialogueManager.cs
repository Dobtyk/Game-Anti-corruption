using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DialogueManager : MonoBehaviour
{
    [SerializeField] GameObject _dialogueText;
    [SerializeField] GameObject _panel;
    [SerializeField] GameObject _playerIcon;
    [SerializeField] GameObject _botIcon;
    [SerializeField] GameObject _buttonEnd;
    [SerializeField] GameObject _buttonVariant1;
    Queue<(string, string)> _sentences;
    public bool IsCommunicationStart;


    void Awake()
    {
        EventManager.StartedCommunication += StartCommunication;
        EventManager.EndedCommunication += EndCommunication;
        _sentences = new Queue<(string, string)>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && IsCommunicationStart)
        {
            DisplayNextSentence();
        }
    }
    void StartCommunication()
    {
        IsCommunicationStart = true;
        _panel.SetActive(true);
    }

    void EndCommunication()
    {
        if (IsCommunicationStart)
        {
            IsCommunicationStart = false;
            _panel.SetActive(false);
            _buttonVariant1.SetActive(false);
            _buttonEnd.SetActive(false);
            EventManager.OnPlayerInteracted(false);
        }
    }

    public void StartDialogue(Dialogue dialogue)
    {
        _buttonVariant1.SetActive(false);
        _buttonEnd.SetActive(false);
        _sentences.Clear();
        foreach (var sentence in dialogue.sentences)
        {
            _sentences.Enqueue(sentence);
        }
        DisplayNextSentence();
    }

    void DisplayNextSentence()
    {
        if (_sentences.Count == 0)
        {
            StopAllCoroutines();
            EndDialogue();
            return;
        }
        var (sentence, speaker) = _sentences.Dequeue();
        if (speaker == "Player")
        {
            _dialogueText.GetComponent<TMP_Text>().alignment = TextAlignmentOptions.Left;
            _botIcon.SetActive(false);
            _playerIcon.SetActive(true);
        }
        else if (speaker == "Bot")
        {
            _dialogueText.GetComponent<TMP_Text>().alignment = TextAlignmentOptions.Right;
            _botIcon.SetActive(true);
            _playerIcon.SetActive(false);
        }
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));
    }

    IEnumerator TypeSentence(string sentence)
    {
        _dialogueText.GetComponent<TMP_Text>().text = "";
        foreach (char letter in sentence.ToCharArray())
        {
            _dialogueText.GetComponent<TMP_Text>().text += letter;
            yield return new WaitForSeconds(0.05f);
        }
    }

    void EndDialogue()
    {
        _dialogueText.GetComponent<TMP_Text>().text = "";
        _botIcon.SetActive(false);
        _playerIcon.SetActive(false);
        _buttonVariant1.SetActive(true);
        _buttonEnd.SetActive(true);
    }
}
