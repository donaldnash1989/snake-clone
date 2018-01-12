using UnityEngine;

public class InputManager : MonoBehaviour {
    
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            InputHandler.NotifyKeyPressed(KeyCode.W);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            InputHandler.NotifyKeyPressed(KeyCode.A);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            InputHandler.NotifyKeyPressed(KeyCode.S);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            InputHandler.NotifyKeyPressed(KeyCode.D);
        }
    }
}
