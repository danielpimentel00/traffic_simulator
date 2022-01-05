using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrafficLight_2_4 : MonoBehaviour
{
    public GameObject green_2_4;
    public GameObject yellow_2_4;
    public GameObject red_2_4;
    public bool isGreen_2_4;
    //public bool isYellow_2_4;
    public bool canSpawn_S2_4;

    void Start()
    {
        StartCoroutine("Lights_2_4");
    }

    void GreenLight_2_4()
    {
        green_2_4.SetActive(true);
        yellow_2_4.SetActive(false);
        red_2_4.SetActive(false);

        isGreen_2_4 = true;
        //isYellow_2_4 = false;

        canSpawn_S2_4 = true;
    }

    void YellowLight_2_4()
    {
        green_2_4.SetActive(false);
        yellow_2_4.SetActive(true);
        red_2_4.SetActive(false);

        isGreen_2_4 = false;
        //isYellow_2_4 = true;

        canSpawn_S2_4 = false;
    }

    void RedLight_2_4()
    {
        green_2_4.SetActive(false);
        yellow_2_4.SetActive(false);
        red_2_4.SetActive(true);

        isGreen_2_4 = false;
        //isYellow_2_4 = false;

        canSpawn_S2_4 = false;
    }

    IEnumerator Lights_2_4()
    {

        while (true)
        {
            RedLight_2_4();
            yield return new WaitForSeconds(6);

            GreenLight_2_4();
            yield return new WaitForSeconds(4);

            YellowLight_2_4();
            yield return new WaitForSeconds(2);
        }

    }
}
