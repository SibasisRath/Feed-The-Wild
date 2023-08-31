using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PizzaBullet : MonoBehaviour
{
    private float _speed = 20;
    void Update()
    {
        transform.Translate(Vector3.forward*Time.deltaTime*_speed);
        if (transform.position.z >= 20 || transform.position.z <= -20 || transform.position.x >= 40 || transform.position.x <= -40)
        {
            Destroy(gameObject);
        }
    }
}
