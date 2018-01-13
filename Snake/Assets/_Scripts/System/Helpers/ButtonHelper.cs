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

    public void ExitGame()
    {
        GameManager.ExitGame();
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

    public void HideCursor()
    {
        CursorManager.HideCursor();
    }

    public void HideAndLockCursor()
    {
        CursorManager.HideAndLockCursor();
    }

    public void ShowCursor()
    {
        CursorManager.ShowCursor();
    }
}
