using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cars_S4 : MonoBehaviour
{
    float speed;
    public GameObject tf_S4;
    bool isHalfWay_S4;
    bool collider_S4;

    void Start()
    {
        collider_S4 = false;
        isHalfWay_S4 = false;
        tf_S4 = GameObject.Find("Pole 4");

        speed = 0.03f;

        transform.Rotate(0, 0, 180, Space.Self);
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

        if (collision.gameObject.tag == "Stop_S4")
        {
            isHalfWay_S4 = true;
        }

        if (collision.gameObject.tag == "GameController")
        {
            collider_S4 = true;
        }
    }

    void StopSign()
    {
        if ((tf_S4.GetComponent<TrafficLight_2_4>().isGreen_2_4 && !isHalfWay_S4) || (tf_S4.GetComponent<TrafficLight_2_4>().isGreen_2_4 && isHalfWay_S4) || (!tf_S4.GetComponent<TrafficLight_2_4>().isGreen_2_4 && !isHalfWay_S4) || (!tf_S4.GetComponent<TrafficLight_2_4>().isGreen_2_4 && collider_S4))
        {
            transform.position = new Vector2(transform.position.x, transform.position.y - speed);
        }
    }
}
