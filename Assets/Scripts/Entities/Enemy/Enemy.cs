using System.Collections;
using UnityEngine;
using UnityEngine.AI;

namespace Entities.Enemy
{
    public class Enemy : MonoBehaviour
    {
        public SoundController soundControl;
        public Transform destination;
        public GameObject lightDetector;

        LightDetector LightDetector;

        public bool IsReadyToChase;
        public float ChaseRefreshTime;
        public float ChaseCounter;
        public bool CanChase;

         NavMeshAgent Agent;

        private void Awake()
        {
            Agent = GetComponent<NavMeshAgent>();

            LightDetector = FindObjectOfType<LightDetector>();

            Agent.updateRotation = false;
            Agent.updateUpAxis = false;

            soundControl = GameObject.FindAnyObjectByType<SoundController>();
        }


        private void Update()
        {   

            if (CanChase)
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

        }

        private IEnumerator Chase()
        {
            soundControl.EnemySlide();
            Agent.destination = destination.position;
            yield return new WaitForSecondsRealtime(0.3f);
            Agent.destination = transform.position;
            ChaseCounter = 0;
        }


        private void OnTriggerStay2D(Collider2D other)
        {
            if (other.gameObject.CompareTag("Player"))
            {
                CanChase = true;
            }
        }


        private void OnTriggerExit2D(Collider2D collision)
        {
            if (collision.gameObject.CompareTag("Player"))
            {
                CanChase = false;
            }
        }


    }



}
