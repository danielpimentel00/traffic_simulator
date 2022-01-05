using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class myUI : MonoBehaviour
{
    public Slider slider;
    public Button normal;
    public Button fast;
    public Button slow;

    void Start()
    {
    }

    void Update()
    {
        normal.onClick.AddListener(NormalSpeed);
        fast.onClick.AddListener(FastSpeed);
        slow.onClick.AddListener(SlowSpeed);
        TimeValue();
    }

    void TimeValue()
    {
        Time.timeScale = slider.value;
    }

    void NormalSpeed()
    {
        slider.value = 1;
    }
    void FastSpeed()
    {
        slider.value = 3;
    }
    void SlowSpeed()
    {
        slider.value = 0.3f;
    }
}
