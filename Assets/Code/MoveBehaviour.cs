using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBehaviour : MonoBehaviour
{
    private Touch touch;
    private Vector3 oldTouchPosition;
    private Vector3 NewTouchPosition;
    [SerializeField]
    private float keepRotateSpeed = 10f;

    private void Update()
    {
        RotateShip();
    }
    private void RotateShip()
    {
        if (Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Began)
            {
                oldTouchPosition = touch.position;
            }

            else if (touch.phase == TouchPhase.Moved)
            {
                NewTouchPosition = touch.position;
            }

            Vector2 rotDirection = oldTouchPosition - NewTouchPosition;
            if (rotDirection.x < 0)
            {
                RotateRight();
            }

            else if (rotDirection.x > 0)
            {
                RotateLeft();
            }
        }
    }

    void RotateLeft()
    {
        transform.rotation = Quaternion.Euler(0f, 1.5f * keepRotateSpeed, 0f) * transform.rotation;
    }

    void RotateRight()
    {
        transform.rotation = Quaternion.Euler(0f, -1.5f * keepRotateSpeed, 0f) * transform.rotation;
    }
}
