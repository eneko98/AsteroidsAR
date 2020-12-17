using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootBehaviour : MonoBehaviour
{

    private float _timeToFire = 0;
    private Touch touch;
    // Update is called once per frame
    void Update()
    {
        UpdateFire();
    }

    private void UpdateFire()
    {

        if (Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Began)
            {
                float distance = 0;
                Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
                Vector3 pos = ray.GetPoint(distance);
                if(pos.x > 200 && pos.x < 300){
                    _timeToFire -= Time.deltaTime;
            if (_timeToFire <= 0)
            {
                Fire();
                _timeToFire = 0.2f;
            }
                }
            }
        }
    }

    private void Fire()
    {
        Instantiate(Resources.Load("Bullet"), new Vector3(transform.position.x, transform.position.y, 0), Quaternion.identity);
    }
}
