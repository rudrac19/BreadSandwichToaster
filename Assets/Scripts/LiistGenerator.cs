using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LiistGenerator : MonoBehaviour
{
    public bool ListMode = true;

    public List<int> randomValues = new List<int>();

    public SpawnManager spawnManager;
    public ListTranslater listtranslater;

    // Start is called before the first frame update
    void Start()
    {
        if (SceneManager.GetActiveScene().buildIndex == 3 || SceneManager.GetActiveScene().buildIndex == 4)
        {
            GenerateList();
        }

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GenerateList()
    {
        int randomNumber1 = Random.Range(0, 10);
        int randomNumber2 = Random.Range(0,10);
        int randomNumber3 = Random.Range(0,10);
        int randomNumber4 = Random.Range(0, 10);
        int randomNumber5 = Random.Range(0, 10);

        Debug.Log(randomNumber1);
        Debug.Log(randomNumber2);
        Debug.Log(randomNumber3);
        Debug.Log(randomNumber4);
        Debug.Log(randomNumber5);

        randomValues.Add(randomNumber1);
        randomValues.Add(randomNumber2);
        randomValues.Add(randomNumber3);
        randomValues.Add(randomNumber4);
        randomValues.Add(randomNumber5);
        listtranslater.Translate(randomValues);
    }
}
