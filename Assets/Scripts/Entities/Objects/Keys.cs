using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Entities.Player;

namespace Entities.Objects
{
    public class Keys : MonoBehaviour
    {
        [SerializeField] private GameObject _prefab;

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.gameObject.CompareTag("Player"))
            {
                Debug.Log("Chave");
                Instantiate(_prefab, transform.position, Quaternion.identity);
                _prefab.GetComponent<ObjectsInteraction>().SetGameObject(gameObject);
            }
        }

        public void Action()
        {
            print("Destroy");
            Destroy(gameObject, 3);
        }
    }
}
