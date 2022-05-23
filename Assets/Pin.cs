using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pin : MonoBehaviour
{
    [SerializeField] float _speed = 20f;
    [SerializeField] Rigidbody2D _rb;
    GameObject _main;
    bool _isPinned = false;

    private void Awake()
    {
        _main = GameObject.FindGameObjectWithTag("Main");
    }
    private void FixedUpdate()
    {
        if (!_isPinned)
        {
            _rb.MovePosition(_rb.position + Vector2.up * _speed * Time.deltaTime);
        }
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Rotator"))
        {
            transform.SetParent(collision.gameObject.transform);

            collision.gameObject.GetComponent<Rotator>()._speed *= -1;

            _main.GetComponent<Score>()._score++;
            
            _isPinned = true;
        }

        else if (collision.gameObject.CompareTag("Pin"))
        {
            _main.GetComponent<GameManager>().EndGame();
            
        }
    }
}
