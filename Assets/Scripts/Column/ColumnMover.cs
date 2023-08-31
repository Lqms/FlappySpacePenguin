using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColumnMover : MonoBehaviour
{
    private float _speed;

    public void Init(float speed)
    {
        _speed = speed;
    }

    private void Update()
    {
        transform.Translate(Vector2.left * _speed * Time.deltaTime);
    }
}
