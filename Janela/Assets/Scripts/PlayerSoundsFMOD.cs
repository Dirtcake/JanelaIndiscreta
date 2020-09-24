using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerSoundsFMOD : MonoBehaviour
{
    [FMODUnity.EventRef]
    public string walkEvent;
    FMOD.Studio.EventInstance Walk;


    public NavMeshAgent navAgent;
    public float curSpeed;

    private Vector3 previousPosition;

    void Start()
    {
        Walk = FMODUnity.RuntimeManager.CreateInstance(walkEvent);
    }

    void Update()
    {
        FMODUnity.RuntimeManager.AttachInstanceToGameObject(Walk, GetComponent<Transform>(), GetComponent<Rigidbody>());

        Vector3 curMove = transform.position - previousPosition;
        curSpeed = curMove.magnitude / Time.deltaTime;
        previousPosition = transform.position;

        if (curSpeed > 1)
        {

            FMOD.Studio.PLAYBACK_STATE fmodPlayback;
            Walk.getPlaybackState(out fmodPlayback);
            if (fmodPlayback == FMOD.Studio.PLAYBACK_STATE.STOPPED)
            {
                Walk.start();
            }
        }
        else
        {
            Walk.stop(FMOD.Studio.STOP_MODE.ALLOWFADEOUT);
        }
    }
}
