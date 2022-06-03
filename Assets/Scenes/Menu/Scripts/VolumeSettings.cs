using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class VolumeSettings : MonoBehaviour
{
    public AudioMixer am;
    public Slider slider;

    public void Awake()
    {
        slider.onValueChanged.AddListener(HandenSlider);
    }

    private void HandenSlider(float volume) 
    {
        am.SetFloat("Volume", volume);
    }


}
