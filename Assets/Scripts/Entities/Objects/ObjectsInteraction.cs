using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Entities.Player;

namespace Entities.Objects
{
    public class ObjectsInteraction : MonoBehaviour
    {
        private PlayerController _pc;

        private GameObject _obj;
        private string _className;

        // Start is called before the first frame update
        void Start()
        {
            _pc = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
        }

        // Update is called once per frame
        void Update()
        {
            if (_pc.GetInteraction())
            {
                print("rotina");
                ObjectAction();
                _pc.SetInteractionEnd(false);
            }
        }

        public void SetGameObject(GameObject obj)
        {
            _obj = obj;
        }

        public void SetObjectClass(string name)
        {
            _className = name;
        }

        private void ObjectAction()
        {
            print(_className);
            if (_className == "Keys")
            {
                print("Action");
                _obj.GetComponent<Keys>().Action();
            }
        }
    }
}