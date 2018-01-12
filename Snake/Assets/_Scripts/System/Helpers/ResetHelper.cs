using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResetHelper : MonoBehaviour {

    public GameObject yourScore;
    public GameObject highScore;

    void Start () {
        if(PlayerPrefs.GetInt("HS") < Player.GetInstance().GetSegments())
        {
            PlayerPrefs.SetInt("HS", Player.GetInstance().GetSegments());
        }
        yourScore.GetComponent<TMPro.TextMeshProUGUI>().text = "Your Score: " + Player.GetInstance().GetSegments();
        highScore.GetComponent<TMPro.TextMeshProUGUI>().text = "High Score: " + PlayerPrefs.GetInt("HS");
        Player.GetInstance().Reset();
    }
	
	void Update () {
		
	}
}
