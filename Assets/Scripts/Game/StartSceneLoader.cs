using UnityEngine;
using UnityEngine.SceneManagement;

public class StartSceneLoader : MonoBehaviour
{
    public string startScene;

    private void Start()
    {
        SceneManager.LoadScene(startScene);
    }
}