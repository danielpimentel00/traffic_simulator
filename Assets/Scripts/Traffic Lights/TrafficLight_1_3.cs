using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrafficLight_1_3 : MonoBehaviour
{
    public GameObject green_1_3;
    public GameObject yellow_1_3;
    public GameObject red_1_3;
    public bool isGreen_1_3;
//l    public bool isYellow_1_3;
    public bool canSpawn_S1_3;

    void Start()
    {
        StartCoroutine("Lights_1_3");
    }

    void GreenLight_1_3()
    {
        green_1_3.SetActive(true);
        yellow_1_3.SetActive(false);
        red_1_3.SetActive(false);

        isGreen_1_3 = true;
        //isYellow_1_3 = false;

        canSpawn_S1_3 = true;
    }
    
    void YellowLight_1_3()
    {
        green_1_3.SetActive(false);
        yellow_1_3.SetActive(true);
        red_1_3.SetActive(false);

        isGreen_1_3 = false;
        //isYellow_1_3 = true;

        canSpawn_S1_3 = false;
    }

    void RedLight_1_3()
    {
        green_1_3.SetActive(false);
        yellow_1_3.SetActive(false);
        red_1_3.SetActive(true);

        isGreen_1_3 = false;
        //isYellow_1_3 = false;

        canSpawn_S1_3 = false;
    }

    IEnumerator Lights_1_3()
    {

        while (true)
        {
            GreenLight_1_3();
            yield return new WaitForSeconds(4);

            YellowLight_1_3();
            yield return new WaitForSeconds(2);

            RedLight_1_3();
            yield return new WaitForSeconds(6);
        }
        
    }
}
