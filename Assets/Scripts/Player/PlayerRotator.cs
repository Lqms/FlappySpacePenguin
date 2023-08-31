using System;
using UnityEngine;

public class PlayerRotator : MonoBehaviour
{
    private float _maxRotationZ;
    private float _minRotationZ;
    private float _rotationSpeed;
    private Quaternion _maxRotation;
    private Quaternion _minRotation;

    public void Init(float maxRotationZ, float minRotationZ, float rotationSpeed)
    {
        _maxRotationZ = maxRotationZ;
        _minRotationZ = minRotationZ;
        _rotationSpeed = rotationSpeed;

        _maxRotation = Quaternion.Euler(0, 0, _maxRotationZ);
        _minRotation = Quaternion.Euler(0, 0, _minRotationZ);
    }

    private void Update()
    {
        transform.rotation = Quaternion.Lerp(transform.rotation, _minRotation, Time.deltaTime * _rotationSpeed);
    }

    public void SetMaxRotateAngle()
    {
        transform.rotation = _maxRotation;
    }
}