using UnityEngine;

public class ViKtoTakie : MonoBehaviour
{
    public Transform secretPortal;

    private void Start()
    {
        GetComponent<SpriteRenderer>().enabled = false;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            GetComponent<SpriteRenderer>().enabled = true;
            GetComponent<Animator>().enabled = true;
            GetComponent<AudioSource>().enabled = true;
        }
    }

    public void SendPlayerBack()  // animation func
    {
        secretPortal.GetComponent<SceneLoader>().MakeTransfer();
    }
}
