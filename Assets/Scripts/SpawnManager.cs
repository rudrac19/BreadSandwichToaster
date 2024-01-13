using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpawnManager : MonoBehaviour
{
    public Done done;
    public LiistGenerator liistGenerator;

    public AudioSource stickySpawn;
    public AudioSource hardSpawn;

    public GameObject[] toppingUi;
    public List<int> toppingsAdded = new List<int>();

    public int atLeastTwoToppings = 0;
    

    void Say(string speak)
    {
        Debug.Log(speak);
    }


    public void Spawn(int toppingIndex)
    {
        if(done.spawnAllowed == true)
        {
            toppingUi[toppingIndex].SetActive(true);
            atLeastTwoToppings++;
            
            if (toppingIndex == 1 || toppingIndex == 3 || toppingIndex == 5 || toppingIndex == 7 || toppingIndex == 9)
            {
                hardSpawn.Play();
            }

            if (toppingIndex == 0 || toppingIndex == 2 || toppingIndex == 4 || toppingIndex == 6 || toppingIndex == 8)
            {
                stickySpawn.Play();
            }

            if (SceneManager.GetActiveScene().buildIndex == 3)
            {
                toppingsAdded.Add(toppingIndex);
                if (toppingsAdded.Count == 5)
                {
                    PrintList();
                    CompareLists();
                }

                
            }
        }
        
    }

    public void PrintList()
    {
        foreach(int toppingIndex in toppingsAdded)
        {
            Debug.Log(toppingIndex);
        }
    }

    public void CompareLists()
    {
        int sameValues = 0;

        for (int i = 0; i < liistGenerator.randomValues.Count; i++)
        {
            if (toppingsAdded[i] == liistGenerator.randomValues[i])
            {
                sameValues++;
            }
        }

        if (sameValues == 5)
        {
            done.DoneWithSandwich();
            Say("Correct!");
        }
        if (sameValues <= 5)
        {
            done.IncorrectSandwich();
        }

        toppingsAdded.Clear();
        liistGenerator.randomValues.Clear();
        liistGenerator.GenerateList();
    }
}
