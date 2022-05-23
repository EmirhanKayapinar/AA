using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] GameObject _pinObject;
    bool _isPin;

    void SpawnPin()
    {
        if (_isPin)
        {
            Instantiate(_pinObject, transform.position, transform.rotation);
        }
        _isPin = false;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _isPin = true;
        }
    }

    private void FixedUpdate()
    {
        SpawnPin();
    }


}
