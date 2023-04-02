using UnityEngine;

namespace Entities.Enemy
{
    public class Enemy : MonoBehaviour
    {
        public Transform destination; 
        private void Start()
        {
            var agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
            agent.updateRotation = false;
            agent.updateUpAxis = false;
        }

        private void Update()
        {
            //var agent = GetComponent<UnityEngine.AI.NavMeshAgent>().SetDestination(destination.position);
        }
    }
}
