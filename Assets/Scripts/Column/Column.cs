using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(ColumnMover))]
public class Column : MonoBehaviour
{
    private ColumnMover _mover;

    public void Init(float speed)
    {
        _mover = GetComponent<ColumnMover>();
        _mover.Init(speed);
    }

    private void Update()
    {
        if (transform.position.x - transform.localScale.x * 2 < Camera.main.ScreenToWorldPoint(Vector3.zero).x)
        {
            Destroy(gameObject);
        }
    }
}
