using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cars_S3 : MonoBehaviour
{
    float speed;
    public GameObject tf_S3;
    bool isHalfWay_S3;
    bool collider_S3;


    void Start()
    {
        collider_S3 = false;
        isHalfWay_S3 = false;
        tf_S3 = GameObject.Find("Pole 3");

        speed = 0.03f;

        transform.Rotate(0, 0, 90, Space.Self);
        transform.localScale = new Vector2(0.35f, 0.35f);
    }

    void Update()
    {
        speed = 0.03f * Time.timeScale;

        StopSign();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Destroyer")
        {
            Destroy(gameObject);
        }

        if (collision.gameObject.tag == "Stop_S3")
        {
            isHalfWay_S3 = true;
        }

        if (collision.gameObject.tag == "GameController")
        {
            collider_S3 = true;
        }
    }

    void StopSign()
    {
        if ((tf_S3.GetComponent<TrafficLight_1_3>().isGreen_1_3 && !isHalfWay_S3) || (tf_S3.GetComponent<TrafficLight_1_3>().isGreen_1_3 && isHalfWay_S3) || (!tf_S3.GetComponent<TrafficLight_1_3>().isGreen_1_3 && !isHalfWay_S3) || (!tf_S3.GetComponent<TrafficLight_1_3>().isGreen_1_3 && collider_S3)) //si esta verde o paso de la mitad
        {
            transform.position = new Vector2(transform.position.x - speed, transform.position.y);
        }

    }
}
