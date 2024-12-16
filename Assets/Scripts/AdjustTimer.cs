using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class AdjustTimer : MonoBehaviour
{
    public Text time;
    [SerializeField] Slider slider;
    [SerializeField] GameObject sliderObject;
    [SerializeField] GameObject[] buttons;
    [SerializeField] GameObject[] editableUIs;

    public int minutes;
    public int seconds;

    public bool editable;

    void Start()
    {
        editable = true;
        sliderObject.SetActive(true);
        foreach (var button in buttons)
        {
            button.SetActive(false);
        }
        foreach (var editableUI in editableUIs)
        {
            editableUI.SetActive(true);
        }
    }

    void Update()
    {
        if (editable)
        {
            sliderObject
                .SetActive(true);
            float x = slider.value;

            int min = (int)x / 60;
            int sec = (int)x % 60;

            minutes = min; // For global use only
            seconds = sec; // For global use only


            time.text = min.ToString("D2") + ":" + sec.ToString("D2");
        } else
        {
            editable = false;
            sliderObject.SetActive(false);
            foreach (var button in buttons)
            {
                button.SetActive(true);
            }
            foreach (var editableUI in editableUIs)
            {
                editableUI.SetActive(false);
            }
            time.text = minutes.ToString("D2") + ":" + seconds.ToString("D2");
        }
    }
    
    public void PerpareCountdown()
    {
        editable = false;
        StartCoroutine(StartCountdown());
    }

    IEnumerator StartCountdown()
    {
        yield return new WaitForSeconds(1f);
        int sum = minutes + seconds;

        if (sum != 0)
        {
            if (seconds == 0)
            {
                minutes -= 1;
                seconds = 60;
                seconds -= 1;
            }
            else
            {
                seconds -= 1;
            }
            StartCoroutine(StartCountdown());
        }
        else
        {
            //end countdown
        }
    }
}