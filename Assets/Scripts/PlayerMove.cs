using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] float _speed;
    [SerializeField] Rigidbody2D _rigidbody;
    private Vector2 _moveVector;

    void Update()
    {
        _moveVector.x = Input.GetAxis("Horizontal");
        _rigidbody.velocity = new Vector2(_moveVector.x * _speed, _rigidbody.velocity.y);
    }
}
