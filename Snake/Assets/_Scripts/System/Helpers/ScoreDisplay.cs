using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour {

    public GameObject scoreDisplayObject;

	void Update () {
        scoreDisplayObject.GetComponent<TMPro.TextMeshProUGUI>().text = "" + Player.GetInstance().GetSegments();
	}
}
