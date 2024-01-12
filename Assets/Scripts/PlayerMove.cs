using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] float _speed;
    [SerializeField] Rigidbody2D _rigidbody;
<<<<<<< HEAD
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
=======
    private Vector2 _moveVector;

    void Update()
    {
        _moveVector.x = Input.GetAxis("Horizontal");
        _rigidbody.velocity = new Vector2(_moveVector.x * _speed, _rigidbody.velocity.y);
>>>>>>> origin/master
    }
}
