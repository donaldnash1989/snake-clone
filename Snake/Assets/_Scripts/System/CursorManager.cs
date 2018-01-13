using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorManager : MonoBehaviour {

    public Texture2D mainCursor;

    public static void HideCursor()
    {
        Cursor.visible = false;
    }

    public static void HideAndLockCursor()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    public static void ShowCursor()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }

    public void InitCursor()
    {
        Cursor.SetCursor(mainCursor, new Vector2(0.0f, 0.0f), CursorMode.Auto);
    }
}
