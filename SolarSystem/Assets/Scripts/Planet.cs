using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planet : MonoBehaviour
{
    [SerializeField] private float _rotateSpeed;
    [SerializeField] private float _planetSpeed;
    [SerializeField] private float _scaleFactor;
    [SerializeField] private GameObject _rotationCenter;

    private void Start()
    {
        transform.localScale = transform.localScale * _scaleFactor;        
    }

    void Update()
    {
        transform.Rotate(Vector3.up, _rotateSpeed * Time.deltaTime);

        transform.RotateAround(_rotationCenter.transform.position, Vector3.up, _planetSpeed * Time.deltaTime);
    }
}
