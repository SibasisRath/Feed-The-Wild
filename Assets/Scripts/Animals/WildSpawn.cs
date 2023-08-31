using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WildSpawn : MonoBehaviour
{
    [SerializeField]
    private List<GameObject> _wildAnimals;
    private float _initialInterval = 0.5f;
   

    void Start()
    {
        InvokeRepeating("AnimalSpawn", _initialInterval, Random.Range(1, 3));
    }

    void AnimalSpawn()
    {
        Instantiate(_wildAnimals[Random.Range(0,3)], new Vector3(Random.Range(-17,17),0,20),Quaternion.Euler(0,180,0));
    }
    

}
