using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    [SerializeField] private float _yOffset = 0f;
    [SerializeField] private float _zOffset = 0f;
    [SerializeField] private CarManager _carManager;
    [SerializeField] private Camera _camera;
    
    private void LateUpdate()
    {
        if (!_carManager.CarTransform)
        {
            return;
        }
        _camera.transform.position = new Vector3(_carManager.CarTransform.position.x,_carManager.CarTransform.position.y+_yOffset,_carManager.CarTransform.position.z+_zOffset);
         
    }
}

