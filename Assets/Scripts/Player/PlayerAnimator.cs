using System;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class PlayerAnimator : MonoBehaviour
{
    private Animator _animator;

    private const string Jump = nameof(Jump);

    public void Init()
    {
        _animator = GetComponent<Animator>();
    }

    public void PlayJumpAnimation()
    {
        _animator.SetTrigger(Jump);
    }
}
