using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidSpawner : MonoBehaviour
{
    public Transform playerT;
    public GameObject[] asteroids;
    //public GameObject asteroid2;
    //public GameObject asteroid3;

    public int cadence = 5;
    private Coroutine couroutine;

    private IEnumerator SpawnAsteroids()
    {
        while (true)
        {
            var asteroid1GameObject = Instantiate(asteroids[Random.Range(0, asteroids.Length)]);
            var randomMovement = asteroid1GameObject.GetComponent<RandomMovement>();
            randomMovement.SetTarget(playerT);
            //var asteroid2GameObject = Instantiate(asteroid2);
            //var asteroid3GameObject = Instantiate(asteroid3);

            float x = Random.Range(-10, 10);
            float z = Random.Range(-10, 10);

            asteroid1GameObject.transform.position = new Vector3(x, 1, z);
            //asteroid2GameObject.transform.position = new Vector3(x, 1, z);
            //asteroid3GameObject.transform.position = new Vector3(x, 1, z);

            yield return new WaitForSeconds(cadence);
        }
        
        
    }
    private void OnEnable()
    {
        couroutine = StartCoroutine(SpawnAsteroids());  
    }
    private void OnDisable()
    {
        StopCoroutine(couroutine);
    }
    
    
    void OnCollisionEnter(Collision collision)
    {
      if (collision.gameObject.CompareTag("Enemy"))
         {
          Destroy(gameObject);
         Destroy(collision.gameObject);
        }
    }
}
