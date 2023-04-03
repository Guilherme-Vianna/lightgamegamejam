using System.Collections;
using UnityEngine;
using UnityEngine.AI;

namespace Entities.Enemy
{
    public class Enemy : MonoBehaviour
    {
        public Transform destination;
        public GameObject lightDetector;

        LightDetector LightDetector;

        public bool IsReadyToChase;
        public float ChaseRefreshTime;
        public float ChaseCounter;

         NavMeshAgent Agent;

        private void Start()
        {
            Agent = GetComponent<NavMeshAgent>();
            LightDetector = FindObjectOfType<LightDetector>();

            Agent.updateRotation = false;
            Agent.updateUpAxis = false;
            //agent.speed = 500f;
            //agent.acceleration = 50f;

            //Agent.speed = 5f;            
            //Agent.acceleration = 30f;
        }


        private void Update()
        {
            if (LightDetector.IsInLight)
            {
                ChaseCounter = 0;
                IsReadyToChase = false;
            }
            else
            {
                ChaseCounter += Time.deltaTime;
            }            

            if (!LightDetector.IsInLight && IsReadyToChase)
            {
                StartCoroutine("Chase");
            }


            if (ChaseCounter > ChaseRefreshTime)
            {
                IsReadyToChase = true;
            }
            else
            {
                IsReadyToChase = false;
            }

            
        }

        private IEnumerator Chase()
        {
            
            Agent.destination = destination.position;
            yield return new WaitForSecondsRealtime(0.3f);
            Agent.destination = transform.position;
            ChaseCounter = 0;
        }
    }
}
