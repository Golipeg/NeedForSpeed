using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    [SerializeField] private float _yOffset = 0f;
    [SerializeField] private float _zOffset = 0f;
    [SerializeField] private Transform _car;
    [SerializeField] private Camera _camera;
    
    private void LateUpdate()
    {
        if (!_car.transform)
        {
            return;
        }
        _camera.transform.position = new Vector3(_car.transform.position.x,_car.transform.position.y+_yOffset,_car.transform.position.z+_zOffset);
         
    }
}

