using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicSettings : MonoBehaviour
{
    public Slider slider;
    public static float volume=1;

    // Use this for initialization
    void Start ()
    {
        //Сохраненные настройки при старте игры
        //Звук
        volume = PlayerPrefs.GetFloat("volume", volume);
        slider.value = volume;
    }
	
	// Update is called once per frame
	void Update ()
    {
        AudioListener.volume = volume;
        //Сохранение звука
        volume = slider.value;
        PlayerPrefs.SetFloat("volume", volume);
    }
}
