using UnityEngine;
using UnityEngine.Events;

public class PlayerInput : MonoBehaviour
{
    public static event UnityAction Tapped;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Tapped?.Invoke();
        }
    }
}