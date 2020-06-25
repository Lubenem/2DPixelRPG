using System;
using UnityEngine;

public class Fighter : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F)) Fight();
    }

    public void Fight()
    {
        GetComponent<Rigidbody2D>().velocity = Vector3.zero;
        GetComponent<Mover>().enabled = false;
        GetComponent<Animator>().SetTrigger("Attack1");
    }
}