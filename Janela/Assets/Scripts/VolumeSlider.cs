using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeSlider : MonoBehaviour
{
    public enum Canal
    {
        Master,
        SFX,
        Musica,
        Ambiencia
    }

    public Canal canais;

    public float StringValue;

    public Slider Slider;
    public GameObject VolumeController;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        switch (canais)
        {
            case Canal.Master:
                VolumeController.GetComponent<VolumeMaster>().masterVolume = Slider.value;
                break;

            case Canal.SFX:
                VolumeController.GetComponent<VolumeMaster>().sfxVolume = Slider.value;
                break;

            case Canal.Musica:
                VolumeController.GetComponent<VolumeMaster>().musicVolume = Slider.value;
                break;

            case Canal.Ambiencia:
                VolumeController.GetComponent<VolumeMaster>().ambienceVolume = Slider.value;
                break;
        }
    }
}
