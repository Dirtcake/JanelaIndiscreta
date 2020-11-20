using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VolumeMaster : MonoBehaviour
{
    FMOD.Studio.Bus Master;
    FMOD.Studio.Bus SFX;
    FMOD.Studio.Bus Music;
    FMOD.Studio.Bus Ambience;

    [SerializeField]
    [Range(-80f, 10f)]
    public float masterVolume;

    [SerializeField]
    [Range(-80f, 10f)]
    public float sfxVolume;

    [SerializeField]
    [Range(-80f, 10f)]
    public float musicVolume;

    [SerializeField]
    [Range(-80f, 10f)]
    public float ambienceVolume;


    // Start is called before the first frame update
    void Start()
    {
        Master = FMODUnity.RuntimeManager.GetBus("bus:/Master");
        SFX = FMODUnity.RuntimeManager.GetBus("bus:/Master/SFX");
        Music = FMODUnity.RuntimeManager.GetBus("bus:/Master/Music");
        Ambience = FMODUnity.RuntimeManager.GetBus("bus:/Master/Ambience");
    }

    // Update is called once per frame
    void Update()
    {
        Master.setVolume(DecibelToLinear(masterVolume));
        SFX.setVolume(DecibelToLinear(sfxVolume));
        Music.setVolume(DecibelToLinear(musicVolume));
        Ambience.setVolume(DecibelToLinear(ambienceVolume));
    }

    private float DecibelToLinear(float dB)
    {
        float linear = Mathf.Pow(10.0f, dB / 20f);
        return linear;
    }
}
