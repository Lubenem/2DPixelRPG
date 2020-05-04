using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;


public enum Destination { A, B, C, D, None };

[RequireComponent(typeof(BoxCollider2D))]
public class SceneLoader : MonoBehaviour
{
    public string sceneToLoad;
    public Destination destination;
    public Transform spawnPoint;
    private GameObject player;
    public float timeToWait = 1;
    private float currentTime;

    private void Start()
    {
        ResetTimer();
    }

    private void ResetTimer()
    {
        currentTime = timeToWait;
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            if (currentTime <= 0)
            {
                StartCoroutine(Transfer());
                ResetTimer();
            }

            currentTime = Mathf.Clamp(currentTime - Time.deltaTime, 0, timeToWait);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Player") ResetTimer();
    }

    public void MakeTransfer()
    {
        StartCoroutine(Transfer());
    }

    private IEnumerator Transfer()
    {
        if (destination == Destination.None || sceneToLoad == "")
        {
            Debug.Log("No destination");
            yield break;
        }

        GetComponent<BoxCollider2D>().enabled = false;
        gameObject.transform.parent = null;
        DontDestroyOnLoad(gameObject);
        yield return SceneManager.LoadSceneAsync(sceneToLoad);

        player = GameObject.FindWithTag("Player");
        player.transform.position = GetDestination().position;
        Destroy(gameObject);
    }

    private Transform GetDestination()
    {
        foreach (SceneLoader portal in FindObjectsOfType<SceneLoader>())
        {
            if (portal == this) continue;
            if (portal.destination == destination) return portal.spawnPoint;
        }
        return player.transform;
    }
}