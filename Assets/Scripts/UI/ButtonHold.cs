using UnityEngine;
using UnityEngine.Events;

public class ButtonHold : MonoBehaviour
{
    private bool isHeld;
    public UnityEvent OnButtonHeld;


    private void Update()
    {
        if (isHeld) OnButtonHeld.Invoke();
    }

    public void OnButtonDown()
    {
        isHeld = true;
    }

    public void OnButtonUp()
    {
        isHeld = false;
    }
}