using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidSpawner : MonoBehaviour
{
    public GameObject asteroid1;
    //public GameObject asteroid2;
    //public GameObject asteroid3;

    public int asteroidCount = 5;

    private void Awake()
    {
        for (int i = 0; i < asteroidCount; i++)
        {
            var asteroid1GameObject = Instantiate(asteroid1);
            //var asteroid2GameObject = Instantiate(asteroid2);
            //var asteroid3GameObject = Instantiate(asteroid3);

            float x = Random.Range(-10, 10);
            float z = Random.Range(-10, 10);

            asteroid1GameObject.transform.position = new Vector3(x, 1, z);
            //asteroid2GameObject.transform.position = new Vector3(x, 1, z);
            //asteroid3GameObject.transform.position = new Vector3(x, 1, z);
        }
    }
}
