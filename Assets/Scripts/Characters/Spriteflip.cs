using UnityEngine;

public class Spriteflip : MonoBehaviour
{
    private void Update()
    {
        if (GetComponent<Mover>().velocity.x < 0)
        { GetComponent<SpriteRenderer>().flipX = true; }

        if (GetComponent<Mover>().velocity.x > 0)
        { GetComponent<SpriteRenderer>().flipX = false; }
    }
}