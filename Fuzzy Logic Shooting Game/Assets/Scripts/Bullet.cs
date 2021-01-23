using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    private void Start()
    {
        Destroy(gameObject, 3f);
    }


    private void OnCollisionEnter(Collision collision)
    {
       HealthBehaviour hb =  collision.gameObject.GetComponent<HealthBehaviour>();

        if (hb)
        {
            hb.TakeDamage(5);
        }

        Destroy(gameObject, 0f);
    }
}
