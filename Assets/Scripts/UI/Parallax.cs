using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(RawImage))]
public class Parallax : MonoBehaviour
{
    [SerializeField] private float _speed = 0.05f;

    private RawImage _backgroundImage;
    private float _offsetX;

    private void Start()
    {
        _backgroundImage = GetComponent<RawImage>();    
    }

    private void Update()
    {
        _offsetX += _speed * Time.deltaTime;

        if (_offsetX >= 1)
            _offsetX = 0;

        _backgroundImage.uvRect = new Rect(_offsetX, _backgroundImage.uvRect.y, _backgroundImage.uvRect.width, _backgroundImage.uvRect.height);
    }
}
