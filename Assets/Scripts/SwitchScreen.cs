using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchScreen : MonoBehaviour
{
    public string currentScreen = "Home";
    public Animator screenAnimation;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GoTo(string screen)
    {
        if (screen == "Home")
        {
            if (currentScreen == "Mode")
            {
                // Go Mode To Home
                screenAnimation.SetTrigger("Go Mode to Home");
                currentScreen = "Home";
            }

            if (currentScreen == "Options")
            {
                // Go Options To Home
                screenAnimation.SetTrigger("Go Options to Home");
                currentScreen = "Home";
            }


        }

        if (screen == "Mode")
        {
            if (currentScreen == "Options")
            {
                // Go Options To Mode
                screenAnimation.SetTrigger("Go Options to Mode");
                currentScreen = "Mode";
            }

            if (currentScreen == "Home")
            {
                // Go Home To Mode
                // "To" is capitilazed
                screenAnimation.SetTrigger("Go Home To Mode");
                currentScreen = "Mode";
            }

        }

        if (screen == "Options")
        {
            if (currentScreen == "Mode")
            {
                // Go Mode To Options
                screenAnimation.SetTrigger("Go Mode to Options");
                currentScreen = "Options";
            }

            if (currentScreen == "Home")
            {
                // Go Home To Options
                // "To" is capitilazed
                screenAnimation.SetTrigger("Go Home To Options");
                currentScreen = "Options";
            }

        }

    }
}

