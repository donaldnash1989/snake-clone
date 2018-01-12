using System.Collections.Generic;
using System.Collections;
using UnityEngine;

public class PlayerObject : MonoBehaviour {

    public static List<Vector3> positions = new List<Vector3>();
    public static bool isMove = false;
    
    void Update () {
        if (!isMove)
        {
            if(positions.Count == 0) positions.Add(transform.position);
            else positions.Insert(0, transform.position);
            if (positions.Count > Player.GetInstance().GetSegments()+1) positions.RemoveAt(positions.Count-1);
            transform.position = Player.GetInstance().Move();
            isMove = true;
            StartCoroutine(DelayMove());
        }
    }
    void OnBecameInvisible()
    {
        GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>().NextScene();
    }

    IEnumerator DelayMove()
    {
        yield return new WaitForSeconds(0.1f);
        isMove = false;
    }
}
