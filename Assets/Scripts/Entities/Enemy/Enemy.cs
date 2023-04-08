using System.Collections;
using UnityEngine;
using UnityEngine.AI;

namespace Entities.Enemy
{
    public class Enemy : MonoBehaviour
    {
        public SFXPlayer Sfx;

        public Transform destination;
        public GameObject lightDetector;

        public LightDetector LightDetector;

        public bool IsReadyToChase;
        public float ChaseRefreshTime;
        public float ChaseCounter;
        public bool CanChase;

        public int SoundChaseCount;
        public bool DidTheSound;

         NavMeshAgent Agent;

        private void Start()
        {
            
            Agent = GetComponent<NavMeshAgent>();

            LightDetector = GetComponentInChildren<LightDetector>();

            Agent.updateRotation = false;
            Agent.updateUpAxis = false;

            Sfx = GetComponent<SFXPlayer>();

        }


        private void Update()
        {
            if (CanChase)
            {
                if (LightDetector.IsInLight)
                {
                    Debug.Log("Ta na luz");
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
            if (!DidTheSound)
            {
                Sfx.PlaySFX();
                DidTheSound = true;
            }
                     
            Agent.destination = destination.position;
            yield return new WaitForSecondsRealtime(0.3f);
            Agent.destination = transform.position;
            ChaseCounter = 0;
            DidTheSound = false;
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
