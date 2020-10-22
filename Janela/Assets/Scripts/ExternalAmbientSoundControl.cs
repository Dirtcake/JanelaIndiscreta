using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExternalAmbientSoundControl : MonoBehaviour
{
    [FMODUnity.EventRef]
    public string eAmbientEvent;
    FMOD.Studio.EventInstance eAmbience;

    public int Daytime;
    public bool isPlaying;



    // Start is called before the first frame update
    void Start()
    {
        eAmbience = FMODUnity.RuntimeManager.CreateInstance(eAmbientEvent);

        FMODUnity.RuntimeManager.AttachInstanceToGameObject(eAmbience, GetComponent<Transform>(), GetComponent<Rigidbody>());

        eAmbience.start();

        if (isPlaying == true)
        {
            //Ambience();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(Daytime >= 0 && Daytime <= 2)
        {
            if(Daytime == 0)
            {
                eAmbience.setParameterByName("Daytime", 0);
            }

            if (Daytime == 1)
            {
                eAmbience.setParameterByName("Daytime", 1);
            }

            if (Daytime == 2)
            {
                eAmbience.setParameterByName("Daytime", 2);
            }
        }
    }

    void Ambience()
    {
        if (isPlaying == true)
        {
            eAmbience.stop(FMOD.Studio.STOP_MODE.IMMEDIATE);
            isPlaying = false;
        }
        else if (isPlaying == false)
        {
            eAmbience.start();
            isPlaying = true;
        }
    }
}
