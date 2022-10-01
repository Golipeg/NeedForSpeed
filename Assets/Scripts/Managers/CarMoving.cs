using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMoving : MonoBehaviour
{
    private float _speed = 5f;
    [SerializeField] private float _timer;
    private Rigidbody _rigidbody;
    [SerializeField] private float _jumpForce = 10f;
    
    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        gameObject.transform.position = new Vector3(transform.position.x + horizontal * _speed * Time.deltaTime,
            transform.position.y, transform.position.z + vertical * _speed * Time.deltaTime);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _rigidbody.AddForce(Vector3.up*_jumpForce,ForceMode.Impulse);
        }

        /*if(Input.GetKey(KeyCode.W))
        {
            position.z += step;
            transform.position = position;
        }

        if (Input.GetKey(KeyCode.A))
        {
            position.x -= step;
            transform.position = position;
        }

        if (Input.GetKey(KeyCode.D))
        {
            position.x += step;
            transform.position = position;
        }

        if (Input.GetKey(KeyCode.S))
        {
            position.z -= step;
            transform.position = position;
        }*/
    }
}