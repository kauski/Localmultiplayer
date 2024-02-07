using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTraffic : MonoBehaviour
{
    public GameObject trafficCar;
    
    public float spawnTimer;
    // Start is called before the first frame update
    void Start()
    {
        
        InvokeRepeating("SpawnObject", 0f, spawnTimer);
    }

    private void SpawnObject()
    {
       GameObject spawnedObject = Instantiate(trafficCar, transform.position, Quaternion.identity);
        spawnedObject.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
