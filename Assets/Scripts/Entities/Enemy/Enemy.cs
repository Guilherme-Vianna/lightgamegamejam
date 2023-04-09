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
        Animator Anim;
        SpriteRenderer SptRender;
        ColiderChase ColChase;

        public bool IsReadyToChase;
        public float ChaseRefreshTime;
        public float ChaseCounter;
        public bool CanChase;

        public int SoundChaseCount;
        public bool DidTheSound;

         NavMeshAgent Agent;

        public bool IsFliped;

        private void Start()
        {
            
            Agent = GetComponent<NavMeshAgent>();
            Anim = GetComponent<Animator>();
            SptRender = GetComponent<SpriteRenderer>();

            LightDetector = GetComponentInChildren<LightDetector>();

            Agent.updateRotation = false;
            Agent.updateUpAxis = false;

            Sfx = GetComponent<SFXPlayer>();
            ColChase = GetComponentInParent<ColiderChase>();
        }

        

        private void Update()
        {
            CanChase = ColChase.CanChase;
            Flipar();
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
            Anim.SetBool("CanChase",CanChase);
            Anim.SetBool("isOnLight", LightDetector.IsInLight);
        }

        private IEnumerator Chase()
        {
            if (!DidTheSound)
            {
                Sfx.PlaySFX();
                DidTheSound = true;
            }
            Anim.SetBool("Changing", true);
            Agent.destination = destination.position;
            yield return new WaitForSecondsRealtime(0.3f);
            Agent.destination = transform.position;
            ChaseCounter = 0;
            DidTheSound = false;

            Anim.SetBool("Changing", false);
        }

        public void Flipar()
        {
            if (transform.position.x > destination.position.x) 
            {
                if (IsFliped)
                {
                    SptRender.flipX = true;
                }
                else
                {
                    SptRender.flipX = false;
                }
            }
            else
            {
                if (IsFliped)
                {
                    SptRender.flipX = false;
                }
                else
                {
                    SptRender.flipX = true;
                }
            }
        }
    }  

}
