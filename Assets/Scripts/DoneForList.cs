using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoneForList : MonoBehaviour
{
    public BreadSelector breadSelector;
    public ShopScript shopScript;
    public GameManagerScript gameManagerScript;
    public SpawnManager spawnManager;

    public Text scoreText;
    public Text scoreOptionsText;
    public GameObject ClosedOriginalBread;
    public GameObject OriginalBread;
    public GameObject[] breads;
    public GameObject[] breadClosed;
    public AudioSource coin;
    public Animator notDone;

    public int score;
    public int amountVaildToBeDone = 2;
    public int breadType;
    public float waitTime1 = .5f;
    public float waitTime2 = 1.5f;
    public bool spawnAllowed = true;


    // Start is called before the first frame update
    void Start()
    {
        score = PlayerPrefs.GetInt("score", 0);
        scoreText.text = score.ToString();
        scoreOptionsText.text = "Score: " + score.ToString();
    }

    public void DoneWithSandwich()
    {
        if (spawnManager.atLeastTwoToppings >= amountVaildToBeDone)
        {
            score++;
            scoreText.text = score.ToString();
            scoreOptionsText.text = "Score: " + score.ToString();
            PlayerPrefs.SetInt("score", score);

            breadClosed[breadType].SetActive(true);
            coin.Play();
            spawnManager.atLeastTwoToppings = 0;

            StartCoroutine(Cooldown());
        }
    }

    public void ResetScore()
    {
        PlayerPrefs.DeleteAll();
        score = 0;
        scoreText.text = "0";
        scoreOptionsText.text = "Score: 0";
        shopScript.sauceBuy = 0;
        shopScript.mustardBuy = 0;
        shopScript.cheeseBuy = 0;
        shopScript.lettuceBuy = 0;
        shopScript.blackOlivesBuy = 0;
        shopScript.jamBuy = 0;
        shopScript.chocRellaBuy = 0;
        gameManagerScript.isItShowen = false;
        gameManagerScript.Unlock(shopScript.toppingList[0]);
        gameManagerScript.Unlock(shopScript.toppingList[1]);
        gameManagerScript.Unlock(shopScript.toppingList[2]);
        gameManagerScript.Unlock(shopScript.toppingList[3]);
        gameManagerScript.Unlock(shopScript.toppingList[4]);
        gameManagerScript.Unlock(shopScript.toppingList[5]);
        gameManagerScript.Unlock(shopScript.toppingList[6]);
        gameManagerScript.isItShowen = true;

    }

    IEnumerator Cooldown()
    {
        yield return new WaitForSeconds(waitTime1);

        spawnManager.toppingUi[0].SetActive(false);
        spawnManager.toppingUi[1].SetActive(false);
        spawnManager.toppingUi[2].SetActive(false);
        spawnManager.toppingUi[3].SetActive(false);
        spawnManager.toppingUi[4].SetActive(false);
        spawnManager.toppingUi[5].SetActive(false);
        spawnManager.toppingUi[6].SetActive(false);
        spawnManager.toppingUi[7].SetActive(false);
        spawnManager.toppingUi[8].SetActive(false);
        spawnManager.toppingUi[9].SetActive(false);
        breadClosed[breadType].SetActive(false);
        breads[breadType].SetActive(false);
        spawnAllowed = false;

        yield return new WaitForSeconds(waitTime2);

        breads[breadType].SetActive(true);
        spawnAllowed = true;

    }



}
