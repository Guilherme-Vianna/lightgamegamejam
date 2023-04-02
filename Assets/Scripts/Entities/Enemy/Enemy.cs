using System.Collections;
using System.Collections.Generic;
using Codice.Client.BaseCommands;
using UnityEngine;

namespace Entities.Enemy
{
    public class Enemy : MonoBehaviour
    {
        public Transform destination;
        public GameObject lightDetector;

        public bool IsReadyToChase;
        public float ChaseRefreshTime;
        public float ChaseTimeDuration;
        public float ChaseCounter;
        
        private void Start()
        {
            var agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
            agent.updateRotation = false;
            agent.updateUpAxis = false;
            //agent.speed = 500f;
            agent.speed = 50f;
            
            //agent.acceleration = 50f;
            agent.acceleration = 10f;
        }

        private void Update()
        {
            var agent = GetComponent<UnityEngine.AI.NavMeshAgent>();

            if (!lightDetector.GetComponent<LightDetector>().IsInLight && IsReadyToChase)
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

            ChaseCounter += Time.deltaTime;
        }

        private IEnumerator Chase()
        {
            var agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
            agent.destination = destination.position;
            yield return new WaitForSecondsRealtime(0.3f);
            agent.destination = transform.position;
            ChaseCounter = 0;
        }
    }
}
