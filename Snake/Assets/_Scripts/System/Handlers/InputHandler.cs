using System.Collections.Generic;
using UnityEngine;

public class InputHandler {

    private static InputHandler instance;

    private static List<IInputListener> listeners = new List<IInputListener>();

    private InputHandler() { }

    public static InputHandler GetInstance()
    {
        if (instance == null) instance = new InputHandler();
        return instance;
    }

    public static void Register(IInputListener listener)
    {
        listeners.Add(listener);
    }

    public static void Unregister(IInputListener listener)
    {
        listeners.RemoveAt(listeners.IndexOf(listener));
    }

    public static void NotifyKeyPressed(KeyCode key)
    {
        foreach(IInputListener listener in listeners)
        {
            listener.KeyPressed(key);
        }
    }

    public static void NotifyKeyHeld(KeyCode key)
    {
        foreach (IInputListener listener in listeners)
        {
            listener.KeyHeld(key);
        }
    }
}
