using UnityEngine;
using UnityEngine.InputSystem;

public class ExitScript : MonoBehaviour
{
    void Update()
    {
        if (Keyboard.current.escapeKey.isPressed)
        {
            Debug.Log("Escape key pressed, exiting application.");
            Application.Quit();
        }
    }
}
