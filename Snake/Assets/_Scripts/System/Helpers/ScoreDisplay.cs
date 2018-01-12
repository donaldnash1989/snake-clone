using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour {

    public Text scoreDisplayObject;

	void Update () {
        scoreDisplayObject.text = "" + Player.GetInstance().GetSegments();
	}
}
