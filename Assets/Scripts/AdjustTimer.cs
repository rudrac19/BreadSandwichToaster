using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdjustTimer : MonoBehaviour
{
    public Text time;
    [SerializeField] Slider slider;

    void Update()
    {
        time.text = Translate(slider.value);
    }

    void Translate(float x, out string minutes, out string seconds)
    {
        int a = (int)x / 60;
        int b = (int)x % 60;
        var c = a.ToString("D2") + ":" + b.ToString("D2");
        return c;
    }
}
