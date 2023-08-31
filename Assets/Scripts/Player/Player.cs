using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PlayerJumper))]
[RequireComponent(typeof(PlayerAnimator))]
[RequireComponent(typeof(PlayerRotator))]
public class Player : MonoBehaviour
{
    [SerializeField] private float _jumpPower = 5;
    [SerializeField] private float _maxRotationZ = 45;
    [SerializeField] private float _minRotationZ = -60;
    [SerializeField] private float _rotationSpeed = 5;

    private PlayerAnimator _animator;
    private PlayerJumper _jumper;
    private PlayerRotator _rotator;

    private void OnEnable()
    {
        PlayerInput.Tapped += OnTapped;
    }

    private void OnDisable()
    {
        PlayerInput.Tapped -= OnTapped;
    }

    private void Start()
    {
        _animator = GetComponent<PlayerAnimator>();
        _jumper = GetComponent<PlayerJumper>();
        _rotator = GetComponent<PlayerRotator>();

        _animator.Init();
        _jumper.Init(_jumpPower);
        _rotator.Init(_maxRotationZ, _minRotationZ, _rotationSpeed);
    }

    private void OnTapped()
    {
        _jumper.Jump();
        _animator.PlayJumpAnimation();
        _rotator.SetMaxRotateAngle();
    }
}
