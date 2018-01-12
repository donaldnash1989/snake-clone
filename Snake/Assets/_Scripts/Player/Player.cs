using System.Collections;
using UnityEngine;

public class Player : IInputListener {

    private static Player instance;

    private static Vector3 p_position;

    private static Vector3 velocity;

    private static int segments = 0;

    private Player() {
        velocity = new Vector3(0.0F, 1.0f, 0.0f);
        InputHandler.Register(this);
    }

    public static Player GetInstance()
    {
        if (instance == null) instance = new Player();
        return instance;
    }

    public Vector3 position { get { return p_position; } }

    public Vector3 Move()
    {
        p_position += velocity;
        return p_position;
    }

    public void AddSegment()
    {
        segments++;
    }

    public int GetSegments()
    {
        return segments;
    }

    public void KeyHeld(KeyCode key)
    {
        //Unimplemented
    }

    public void KeyPressed(KeyCode key)
    {
        switch (key)
        {
            case KeyCode.W:
                velocity = new Vector3(0.0F, 1.0f, 0.0f);
                break;
            case KeyCode.A:
                velocity = new Vector3(-1.0f, 0.0F, 0.0f);
                break;
            case KeyCode.S:
                velocity = new Vector3(0.0F, -1.0f, 0.0f);
                break;
            case KeyCode.D:
                velocity = new Vector3(1.0f, 0.0F, 0.0f);
                break;
            default:
                break;
        }
    }

    public void Reset()
    {
        p_position = Vector3.zero;
        velocity = new Vector3(0.0F, 1.0f, 0.0f);
        segments = 0;
        SpawnPoint.nextSpawn = true;
        PlayerObject.isMove = false;
    }
}
