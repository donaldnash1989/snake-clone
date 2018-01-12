using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHitbox : MonoBehaviour {

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("Bound"))
        {
            GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>().NextScene();
        }
    }
}
