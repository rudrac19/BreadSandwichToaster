using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BreadSelector : MonoBehaviour
{
    public Done done;
    public LiistGenerator liistGenerator;

    public GameObject breadSelectorCanvas;
    public GameObject gameCanvas;
    public GameObject[] breads;

    public void Select(int breadIndex)
    {
        if(SceneManager.GetActiveScene().buildIndex != 3)
        {
            gameCanvas.SetActive(true);
            breads[breadIndex].SetActive(true);
            done.breadType = breadIndex;
            Debug.Log(done.breadType);
            Debug.Log(breadIndex);
            breadSelectorCanvas.SetActive(false);
        }
    }
}
