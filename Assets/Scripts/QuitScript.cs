using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitScript : MonoBehaviour
{
    public void Quit()
    {
        Application.Quit();
        Debug.Log("Quit");
    }
}