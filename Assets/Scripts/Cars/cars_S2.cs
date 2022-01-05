using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cars_S2 : MonoBehaviour
{
    float speed;
    public GameObject tf_S2;
    bool isHalfWay_S2;
    bool collider_S2;

    void Start()
    {
        collider_S2 = false;
        isHalfWay_S2 = false;

        tf_S2 = GameObject.Find("Pole 2");

        speed = 0.03f;

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

        if (collision.gameObject.tag == "Stop_S2")
        {
            isHalfWay_S2 = true;
        }

        if (collision.gameObject.tag == "GameController")
        {
            collider_S2 = true;
        }
    }

    void StopSign()
    {
        if ((tf_S2.GetComponent<TrafficLight_2_4>().isGreen_2_4 && !isHalfWay_S2) || (tf_S2.GetComponent<TrafficLight_2_4>().isGreen_2_4 && isHalfWay_S2) || (!tf_S2.GetComponent<TrafficLight_2_4>().isGreen_2_4 && !isHalfWay_S2) || (!tf_S2.GetComponent<TrafficLight_2_4>().isGreen_2_4 && collider_S2))
        {
            transform.position = new Vector2(transform.position.x, transform.position.y + speed);

        }
    }
}
