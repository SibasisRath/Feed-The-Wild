using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MainPlayerObjectMove : MonoBehaviour
{
    private float _leftLimit = -17;
    private float _rightLimit = 17;
    private float _frontLimit = 17;
    private float _backLimit = -4;
    private float _speed = 10;
    private float _xAxisInput;
    private float _zaxisInput;
    private Vector2 _movement;

    private void Start()
    {
        transform.position = Vector3.zero;
    }
    void OnMove(InputValue inputValue)
    {
        _movement = inputValue.Get<Vector2>();
        _xAxisInput = _movement.x;
        _zaxisInput = _movement.y;
    }

    private void Update()
    {
        transform.Translate(Vector3.forward * _zaxisInput * _speed * Time.deltaTime);
        transform.Translate(Vector3.right * _xAxisInput * _speed * Time.deltaTime);


        if (transform.position.x >= _rightLimit)
        {
            transform.position = new Vector3(_leftLimit, 0, transform.position.z);
        }
        else if (transform.position.x <= _leftLimit)
        {
            transform.position = new Vector3(_rightLimit, 0, transform.position.z);
        }
        if (transform.position.z >= _frontLimit)
        {
            transform.position = new Vector3(transform.position.x, 0, _backLimit);
        }
        else if (transform.position.z <= _backLimit)
        {
            transform.position = new Vector3(transform.position.x, 0, _frontLimit);
        }
        
    }
}
