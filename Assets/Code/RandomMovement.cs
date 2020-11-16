using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class RandomMovement : MonoBehaviour
{
    private Transform target;
    public float speed;

    public void SetTarget(Transform transform)
    {
        target = transform;
    }
    private void Update()
    {
        var direction = (target.position - transform.position).normalized;
        var movement = direction * speed * Time.deltaTime;
        transform.position += movement;
    }

}
