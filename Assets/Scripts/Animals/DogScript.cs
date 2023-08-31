using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogScript : MonoBehaviour
{
    private float _speed =7;
    private GameManager gameManager;
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * _speed);
        if (transform.position.z <= -6)
        {
            Destroy(gameObject);

        }
    }
}
