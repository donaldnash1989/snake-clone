using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Segment : MonoBehaviour {

    public int id;

    private void Update()
    {
        transform.position = PlayerObject.positions[id];
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("PlayerHitbox"))
        {
            GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>().NextScene();
        }
    }
}
