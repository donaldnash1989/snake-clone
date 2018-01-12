using UnityEngine;

public interface IInputListener {
    void KeyPressed(KeyCode key);
    void KeyHeld(KeyCode key);
}
