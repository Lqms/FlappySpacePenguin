using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerJumper : MonoBehaviour
{
    private Rigidbody2D _rigidbody;
    private float _jumpPower = 5;

    public void Init(float jumpPower)
    {
        _rigidbody = GetComponent<Rigidbody2D>();

        _jumpPower = jumpPower;
    }

    public void Jump()
    {
        _rigidbody.velocity = Vector2.zero;
        _rigidbody.AddForce(Vector2.up * _jumpPower, ForceMode2D.Impulse);
    }
}
