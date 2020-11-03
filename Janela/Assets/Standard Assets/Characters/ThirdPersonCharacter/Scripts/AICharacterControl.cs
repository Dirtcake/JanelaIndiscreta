using System;
using UnityEngine;

namespace UnityStandardAssets.Characters.ThirdPerson
{
    [RequireComponent(typeof (UnityEngine.AI.NavMeshAgent))]
    [RequireComponent(typeof (ThirdPersonCharacter))]
    public class AICharacterControl : MonoBehaviour
    {
        public UnityEngine.AI.NavMeshAgent agent { get; private set; }             // the navmesh agent required for the path finding
        public ThirdPersonCharacter character { get; private set; } // the character we are controlling
        public Transform target;                                    // target to aim for


        private void Start()
        {
            // get the components on the object we need ( should not be null due to require component so no need to check )
            agent = GetComponentInChildren<UnityEngine.AI.NavMeshAgent>();
            character = GetComponent<ThirdPersonCharacter>();

	        agent.updateRotation = false;
	        agent.updatePosition = true;
        }


        private void Update()
        {

                // Criar raycast para determinar o target do personagem e atribuir a variavel target
                RaycastHit hit;
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                if (Physics.Raycast(ray, out hit, Mathf.Infinity))
                {
                    iInteragivel obj = hit.collider.GetComponent<iInteragivel>();
                if (obj != null)
                {
                    GameStatus.interacaoHUD.transform.GetChild(0).gameObject.SetActive(true);
                    GameStatus.cursores.SetActive(false);
                }
                else
                {
                    GameStatus.interacaoHUD.transform.GetChild(0).gameObject.SetActive(false);
                    GameStatus.cursores.SetActive(true);
                }

                if (Input.GetMouseButtonDown(0))
                {
                    if (obj != null)
                    {
                        obj.acao();
                    }
                    else GameStatus.targetAction = null;
                    target.position = hit.point;
                }
            }




            if (target != null)
                agent.SetDestination(target.position);

            if (agent.remainingDistance > agent.stoppingDistance)
                character.Move(agent.desiredVelocity, false, false);
            else
                character.Move(Vector3.zero, false, false);
        }


        public void SetTarget(Transform target)
        {
            this.target = target;
        }
    }
}
