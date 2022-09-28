using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarManager : MonoBehaviour
{
    [SerializeField] private CarMain _carMainPrefab;
    [SerializeField] private Transform _initPoint;
    [HideInInspector] public Transform CarTransform;

    private void Start()
    {
        InitCar();
    }

    private void InitCar()
    {
        var carMain=Instantiate(_carMainPrefab, _initPoint.position,Quaternion.identity,transform);
        CarTransform = carMain.transform;
        
        Debug.Log($"Created Car-{carMain.gameObject.name}");
    }
}
