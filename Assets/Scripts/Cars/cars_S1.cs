using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cars_S1 : MonoBehaviour
{
    float speed;
    public GameObject tf_S1;
    bool isHalfWay_S1;
    bool collider_S1;

    void Start()
    {
        collider_S1 = false;
        isHalfWay_S1 = false;
        tf_S1 = GameObject.Find("Pole 1");

        speed = 0.03f;

        transform.Rotate(0, 0, -90, Space.Self);
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

        if (collision.gameObject.tag == "Stop_S1")
        {
            isHalfWay_S1 = true;
        }

        if(collision.gameObject.tag == "GameController")
        {
            collider_S1 = true;
        }
    }

    void StopSign()
    {

        if ((tf_S1.GetComponent<TrafficLight_1_3>().isGreen_1_3 && !isHalfWay_S1) || (tf_S1.GetComponent<TrafficLight_1_3>().isGreen_1_3 && isHalfWay_S1) || (!tf_S1.GetComponent<TrafficLight_1_3>().isGreen_1_3 && !isHalfWay_S1) || (!tf_S1.GetComponent<TrafficLight_1_3>().isGreen_1_3 && collider_S1)) //(si esta verde y no paso de la mitad) o (si esta verde y paso de la mitad) o (si no esta verde y no ha llegado a la mitad) o (si no esta verde y paso de la mitad)
        {
            transform.position = new Vector2(transform.position.x + speed, transform.position.y);
        }
    }
}
