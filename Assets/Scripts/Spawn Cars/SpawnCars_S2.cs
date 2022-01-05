using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCars_S2 : MonoBehaviour
{
    public GameObject[] Cars_S2;
    int random;
    float randomTime;
    public TrafficLight_2_4 tf_S2;

    void Start()
    {
        random = Random.Range(0, Cars_S2.Length);
        Instantiate(Cars_S2[random], transform.position, Quaternion.identity);

        StartCoroutine("SpawnCar");
    }

    IEnumerator SpawnCar()
    {
        while (true)
        {
            random = Random.Range(0, Cars_S2.Length);
            randomTime = Random.Range(0.5f, 1);

            if (tf_S2.canSpawn_S2_4)
                Instantiate(Cars_S2[random], transform.position, Quaternion.identity);

            yield return new WaitForSeconds(randomTime);
        }
    }
}
