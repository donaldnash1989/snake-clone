using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonHelper : MonoBehaviour
{
    public AudioClip buttonClick;

    public void NextScene()
    {
        GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>().NextScene();
    }

    public void PrevScene()
    {
        GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>().PrevScene();
    }

    public void MainMenu()
    {
        GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>().MainMenu();
    }

    public void PlayClick()
    {
        AudioManager.PlaySoundEffect(buttonClick);
    }

    public void NextTrack()
    {
        AudioManager.NextTrack();
    }

    public void PrevTrack()
    {
        AudioManager.PrevTrack();
    }
}
