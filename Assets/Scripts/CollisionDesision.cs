using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDesision : MonoBehaviour
{
    private GameManager gameManager;

    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Food"))
        {
            //Destroy(gameObject);
            GetComponent<AnimalHunger>().FeedAnimal(1);
            Destroy(other.gameObject);
            gameManager.AddScore(1);
        }
        if (other.CompareTag("Player"))
        {
            Destroy(gameObject);
            gameManager.AddLives(-1);
        }
    }
}
