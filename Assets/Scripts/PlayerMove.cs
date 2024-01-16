using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] float _speed;
    [SerializeField] Rigidbody2D _rigidbody;
    Vector2 _moveVector;
    [SerializeField] Sprite _playerMoving;
    [SerializeField] Sprite _playerStopping;

    void Update()
    {
        if (GameManager.IsPlayerInteract)
        {
            gameObject.GetComponent<Rigidbody2D>().velocityX = 0;         
        }
        if (!GameManager.IsPlayerInteract)
        {
            _moveVector.x = Input.GetAxis("Horizontal");
            _rigidbody.velocity = new Vector2(_moveVector.x * _speed, _rigidbody.velocity.y);
            transform.GetComponent<SpriteRenderer>().sprite = _playerMoving;
        }
        if (gameObject.GetComponent<Rigidbody2D>().velocityX == 0)
        {
            transform.GetComponent<SpriteRenderer>().sprite = _playerStopping;
        }
        if (Input.GetAxis("Horizontal") > 0)
        {
            Quaternion rot = transform.rotation;
            rot.y = 0;
            transform.rotation = rot;
        }

        if (Input.GetAxis("Horizontal") < 0)
        {
            Quaternion rot = transform.rotation;
            rot.y = 180;
            transform.rotation = rot;
        }
    }
}
