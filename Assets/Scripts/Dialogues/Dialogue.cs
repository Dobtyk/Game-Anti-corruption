using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum DialogueType { PetyaGreetings, PetyaWhereGo };
public class Dialogue: MonoBehaviour
{
    public DialogueType DialogueType;
    public string _nameDialogue;
    [TextArea(3, 10)]
    [SerializeField] public (string, string)[] sentences;

    private void Awake()
    {
        if (DialogueType == DialogueType.PetyaGreetings)
        {
            _nameDialogue = "Приветствие";
            sentences = new (string, string)[]
            {
                ("Добрый день!", "Player"),
                ("Здравствуйте.", "Bot"),
                ("Вы должно быть, username?", "Bot"),
                ("Да всё верно.", "Player")
            };
        }
        else if (DialogueType == DialogueType.PetyaWhereGo)
        {
            sentences = new (string, string)[]
            {
                ("Как я могу пройти на своё рабочее место?", "Player"),
                ("Прямо у вас за спиной находится ваш компьютер.", "Bot"),
                ("Отлично. Хорошего дня!", "Player")
            };
        }
    }
}
