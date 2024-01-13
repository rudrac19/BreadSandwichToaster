using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerScript : MonoBehaviour
{
    public GameObject[] buttons;

    public bool isItShowen = true;

    public void Unlock(string topping)
    {
        if (topping == "Sauce")
        {
            buttons[0].SetActive(isItShowen);
        }

        if (topping == "Mustard")
        {
            buttons[1].SetActive(isItShowen);
        }

        if (topping == "Cheese")
        {
            buttons[2].SetActive(isItShowen);
        }

        if (topping == "Lettuce")
        {
            buttons[3].SetActive(isItShowen);
        }

        if (topping == "Black Olives")
        {
            buttons[4].SetActive(isItShowen);
        }

        if (topping == "Jam")
        {
            buttons[5].SetActive(isItShowen);
        }

        if (topping == "Choc-Rella")
        {
            buttons[6].SetActive(isItShowen);
        }
    }
}
