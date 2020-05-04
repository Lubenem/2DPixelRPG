using UnityEngine;

public class Mover : MonoBehaviour
{
    private Vector3 keyboardVel;
    private Vector3 joystickVel;
    public Joystick joystick;
    public float speed = 3;

    private void FixedUpdate()
    {
        keyboardVel = new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"), 0);
        joystickVel = new Vector3(joystick.Horizontal, joystick.Vertical, 0);
        transform.Translate((keyboardVel.normalized + joystickVel) * speed * Time.deltaTime);
    }
}