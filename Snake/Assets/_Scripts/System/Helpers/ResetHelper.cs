using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResetHelper : MonoBehaviour {

    public Text yourScore;
    public Text highScore;

    void Start () {
        if(PlayerPrefs.GetInt("HS") < Player.GetInstance().GetSegments())
        {
            PlayerPrefs.SetInt("HS", Player.GetInstance().GetSegments());
        }
        yourScore.text = "Your Score: " + Player.GetInstance().GetSegments();
        highScore.text = "High Score: " + PlayerPrefs.GetInt("HS");
        Player.GetInstance().Reset();
    }
	
	void Update () {
		
	}
}
