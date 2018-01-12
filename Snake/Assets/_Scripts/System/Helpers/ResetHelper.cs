using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetHelper : MonoBehaviour {
    
	void Start () {
        Player.GetInstance().Reset();

    }
	
	void Update () {
		
	}
}
