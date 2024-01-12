<<<<<<< HEAD
=======
using System.Collections;
using System.Collections.Generic;
>>>>>>> origin/master
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    [SerializeField] float _speed;
    Transform _playerTransform;

    void Awake()
    {
        _playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
        transform.position = new Vector3
        {
            x = _playerTransform.position.x,
<<<<<<< HEAD
            y = 0,
=======
            y = _playerTransform.position.y,
>>>>>>> origin/master
            z = _playerTransform.position.z - 10
        };
    }

    void Update()
    {
        var target = new Vector3
        {
            x = _playerTransform.position.x,
<<<<<<< HEAD
            y = 0,
=======
            y = _playerTransform.position.y,
>>>>>>> origin/master
            z = _playerTransform.position.z - 10
        };
        transform.position = Vector3.Lerp(a: transform.position, b: target, t: _speed * Time.deltaTime); ;
    }
}
