using UnityEngine;
using UnityEngine.UI;

public class ResolutionCheck : MonoBehaviour
{
    public Text textObj;

    private void Start()
    {
        textObj.text = $"{Screen.width} * {Screen.height}";
    }
}