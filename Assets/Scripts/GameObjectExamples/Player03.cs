using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameObjectExamples
{

    public class Player03 : MonoBehaviour
    {

        public int health;

        public string name;


        private void Start()
        {

            Debug.Log(gameObject.name);

        }

        public void TakeDamege()

        {

            health -= 10;

        }

    }

}
