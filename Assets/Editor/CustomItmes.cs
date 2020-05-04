using UnityEditor;
using UnityEditor.SceneManagement;

class EditorScrips : EditorWindow
{
    [MenuItem("Custom/Run Preload _F1")]
    public static void RunPreload()
    {
        if (EditorApplication.isPlaying == true)
        {
            EditorApplication.isPlaying = false;
            return;
        }

        EditorSceneManager.SaveOpenScenes();
        EditorSceneManager.OpenScene(EditorBuildSettings.scenes[0].path);
        EditorApplication.isPlaying = true;
    }

    [MenuItem("Custom/Open Preload _%0")]
    public static void OpenPreload()
    {
        EditorSceneManager.OpenScene(EditorBuildSettings.scenes[0].path);
    }

    [MenuItem("Custom/Open First Scene _%1")]
    public static void OpenScene1()
    {
        EditorSceneManager.OpenScene(EditorBuildSettings.scenes[1].path);
    }

    [MenuItem("Custom/Open Second Scene _%2")]
    public static void OpenScene2()
    {
        EditorSceneManager.OpenScene(EditorBuildSettings.scenes[2].path);
    }

    [MenuItem("Custom/Open Third Scene _%3")]
    public static void OpenScene3()
    {
        EditorSceneManager.OpenScene(EditorBuildSettings.scenes[3].path);
    }
}
