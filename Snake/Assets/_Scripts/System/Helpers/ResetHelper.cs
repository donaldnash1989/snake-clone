using UnityEngine;

public class ResetHelper : MonoBehaviour {

    public GameObject yourScore;
    public GameObject highScore;
    public AudioClip achievedHighScore;

    void Start () {
        if(PlayerPrefs.GetInt("HS") < Player.GetInstance().GetSegments())
        {
            PlayerPrefs.SetInt("HS", Player.GetInstance().GetSegments());
            AudioManager.PlaySoundEffect(achievedHighScore);
        }
        yourScore.GetComponent<TMPro.TextMeshProUGUI>().text = "Your Score: " + Player.GetInstance().GetSegments();
        highScore.GetComponent<TMPro.TextMeshProUGUI>().text = "High Score: " + PlayerPrefs.GetInt("HS");
        Player.GetInstance().Reset();
    }
	
	void Update () {
		
	}
}
