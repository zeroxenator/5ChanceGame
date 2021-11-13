using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicManager : MonoBehaviour
{
    public Slider AudioVolumeSlider;
    public AudioSource AudioSource;

    private static MusicManager _musicManagerInstance;

    private void Awake()
    {
        DontDestroyOnLoad(this);
        if(_musicManagerInstance == null)
        {
            _musicManagerInstance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void ChangeVolume(float sliderValue)
    {
        AudioSource.volume = sliderValue;
    }

    void OnEnable()
    {
        //Register Slider Events
        AudioVolumeSlider.onValueChanged.AddListener(delegate { ChangeVolume(AudioVolumeSlider.value); });
    }

    void OnDisable()
    {
        //Un-Register Slider Events
        AudioVolumeSlider.onValueChanged.RemoveAllListeners();
    }
}
