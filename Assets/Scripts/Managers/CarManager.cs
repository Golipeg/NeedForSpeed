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
       // StartCoroutine(InitAfterTime());
       //StartCoroutine(SayAfterTime());
    }

    private IEnumerator InitAfterTime()
    {
        var waitTime = new WaitForSeconds(1f);
        while (true)
        {
            InitCar();
            yield return waitTime;
        }
    }

    private IEnumerator SayAfterTime()
    {
        Debug.Log("Hello World!");
        yield return new WaitForSeconds(5f);
        Debug.Log("Bye World!");
    }

    private void InitCar()
    {
        var carMain=Instantiate(_carMainPrefab, _initPoint.position,Quaternion.identity,transform);
        CarTransform = carMain.transform;
        
        Debug.Log($"Created Car-{carMain.gameObject.name}");
    }
}
