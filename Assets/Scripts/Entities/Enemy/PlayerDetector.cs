using System;
using System.Collections;
using UnityEngine;
using UnityEngine.AI;

namespace Entities.Enemy
{
    public class PlayerDetector : MonoBehaviour
    {
        //public bool IsReadyToWalk;
        public float TimeRefreshWalk;
        public int TimeToWalk;

        // private void Start()
        // {
        //     GetComponentInParent<NavMeshAgent>().speed = 0;
        // }

        private void OnTriggerStay2D(Collider2D other)
        {
            if (other.gameObject.CompareTag("Player"))
            {
                TimeRefreshWalk += Time.deltaTime;
                Debug.Log("Jogador no Alcance");
            }
            
            if (TimeRefreshWalk > TimeToWalk)
            {
                StartCoroutine(Walk());
            }
        }

        private IEnumerator Walk()
        {
            GetComponentInParent<NavMeshAgent>().acceleration = 150f;
            yield return new WaitForSeconds(1);
            TimeRefreshWalk = 0;
        }
    }
}