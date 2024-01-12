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
            _nameDialogue = "�����������";
            sentences = new (string, string)[]
            {
                ("������ ����!", "Player"),
                ("������������.", "Bot"),
                ("�� ������ ����, username?", "Bot"),
                ("�� �� �����.", "Player")
            };
        }
        else if (DialogueType == DialogueType.PetyaWhereGo)
        {
            sentences = new (string, string)[]
            {
                ("��� � ���� ������ �� ��� ������� �����?", "Player"),
                ("����� � ��� �� ������ ��������� ��� ���������.", "Bot"),
                ("�������. �������� ���!", "Player")
            };
        }
    }
}
