using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonHelper : MonoBehaviour {

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
}
