using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerSoundsFMOD : MonoBehaviour
{
    [FMODUnity.EventRef]
    public string walkEvent;
    FMOD.Studio.EventInstance Walk;

    bool isPlayerWalking = false;

    public NavMeshAgent navAgent;
    public float curSpeed; //só pra ver a velocidade da navmesh
    public float walkSpeed; //intervalo entre os passos, 0.3 funciona bem

    private Vector3 previousPosition;

    void Start()
    {
        Walk = FMODUnity.RuntimeManager.CreateInstance(walkEvent);
        InvokeRepeating("Footsteps", 0, walkSpeed);
    }

    void Update()
    {
        FMODUnity.RuntimeManager.AttachInstanceToGameObject(Walk, GetComponent<Transform>(), GetComponent<Rigidbody>());

        //verificar velocidade da NavMesh
        Vector3 curMove = transform.position - previousPosition;
        curSpeed = curMove.magnitude / Time.deltaTime;
        previousPosition = transform.position;

        if (curSpeed > 1)
        {
            isPlayerWalking = true;
        }
        else isPlayerWalking = false;
    }

    //Unity me ama então mudei a porra toda pra tocar os passos
    void Footsteps()
    {
        if(isPlayerWalking == true)
        {
            //FMODUnity.RuntimeManager.PlayOneShot(walkEvent);
            Walk.start();
        }
    }

    void OnDisable()
    {
        isPlayerWalking = false;
    }
}
