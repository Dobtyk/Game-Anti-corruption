using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractObject : MonoBehaviour
{
    private bool _canInteract;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        _canInteract = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        _canInteract = false;
    }

    private void OnMouseEnter()
    {
        // ������ �� ������ � ������� ����� �����������������
        if (Input.GetMouseButtonDown(0) && _canInteract)
        {
            // ���-�� ����������
        }
    }
}
