using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionsHelper : MonoBehaviour {
    
    public Slider BGMSlider;
    public Slider SFXSlider;
    public GameObject trackDisplay;

    private void Start()
    {
        BGMSlider.value = AudioManager.BGMVolume;
        SFXSlider.value = AudioManager.SFXVolume;
        gameObject.GetComponent<Canvas>().enabled = false;
    }

    void Update()
    {
            BGMSlider.onValueChanged.AddListener(delegate { AudioManager.BGMValuChanged(BGMSlider.value); });
            SFXSlider.onValueChanged.AddListener(delegate { AudioManager.SFXValuChanged(SFXSlider.value); });
            trackDisplay.GetComponent<TMPro.TextMeshProUGUI>().text = "Current Track: " + AudioManager.CurrentTrack();
    }
}
