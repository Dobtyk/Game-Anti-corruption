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
            y = 0,
            z = _playerTransform.position.z - 10
        };
    }

    void Update()
    {
        var target = new Vector3
        {
            x = _playerTransform.position.x,
            y = 0,
            z = _playerTransform.position.z - 10
        };
        transform.position = Vector3.Lerp(a: transform.position, b: target, t: _speed * Time.deltaTime); ;
    }
}
