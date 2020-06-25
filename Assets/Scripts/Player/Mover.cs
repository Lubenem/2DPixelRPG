using System;
using UnityEngine;

public class Mover : MonoBehaviour
{
    private Vector3 keyboardVel;
    private Vector3 joystickVel;
    [HideInInspector] public Vector3 velocity;
    public Joystick joystick;
    public float speed = 3;

    private void Update()
    {
        keyboardVel = new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"), 0);
        joystickVel = new Vector3(joystick.Horizontal, joystick.Vertical, 0);
        velocity = keyboardVel.normalized + joystickVel;
        GetComponent<Animator>().SetFloat("velocity", velocity.magnitude);
        GetComponent<Rigidbody2D>().velocity = velocity * speed;
    }
}