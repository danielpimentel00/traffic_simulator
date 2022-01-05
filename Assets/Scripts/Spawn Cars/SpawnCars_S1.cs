using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCars_S1 : MonoBehaviour
{
    public GameObject[] Cars_S1;
    int random;
    float randomTime;
    public TrafficLight_1_3 tf_S1;

    void Start()
    {
        StartCoroutine("SpawnCar");
    }

    IEnumerator SpawnCar()
    {
        while (true)
        {
            random = Random.Range(0, Cars_S1.Length);
            randomTime = Random.Range(0.5f, 1);

            if (tf_S1.canSpawn_S1_3)
                Instantiate(Cars_S1[random], transform.position, Quaternion.identity);

            yield return new WaitForSeconds(randomTime);
        }
    }
}
