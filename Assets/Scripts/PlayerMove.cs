using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _clampLeft;
    [SerializeField] private float _clampRight;
    private float _oldMousePositionX;
    private float _eulerY;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _oldMousePositionX = Input.mousePosition.x;
        }

        if (Input.GetMouseButton(0))
        {
            Vector3 newPosition = transform.position + _speed * Time.deltaTime * transform.forward;
            newPosition.x = Mathf.Clamp(newPosition.x, _clampLeft, _clampRight);
            transform.position = newPosition;

            float deltaX = Input.mousePosition.x - _oldMousePositionX;
            _oldMousePositionX = Input.mousePosition.x;

            _eulerY += deltaX;
            _eulerY = Mathf.Clamp(_eulerY, -70, 70);
            transform.eulerAngles = new Vector3(0, _eulerY, 0);
        }
    }


}
