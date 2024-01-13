using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class ShopScript : MonoBehaviour
{
    // 0 = false ; 1 = true
    public int sauceBuy = 0;
    public int mustardBuy = 0;
    public int cheeseBuy = 0;
    public int lettuceBuy = 0;
    public int blackOlivesBuy = 0;
    public int jamBuy = 0;
    public int chocRellaBuy = 0;

    public string[] toppingList;
    public int[] toppingPriceList;

    public Done done;
    public GameManagerScript gameManagerScript;

    void Start()
    {
        sauceBuy = PlayerPrefs.GetInt("sauceBuy", 0);
        mustardBuy = PlayerPrefs.GetInt("mustardBuy", 0);
        cheeseBuy = PlayerPrefs.GetInt("cheeseBuy", 0);
        lettuceBuy = PlayerPrefs.GetInt("lettuceBuy", 0);
        blackOlivesBuy = PlayerPrefs.GetInt("blackOlivesBuy", 0);
        jamBuy = PlayerPrefs.GetInt("jamBuy", 0);
        chocRellaBuy = PlayerPrefs.GetInt("chocRellaBuy", 0);
        if (sauceBuy == 1)
        {
            gameManagerScript.Unlock(toppingList[0]);
        }
        if (mustardBuy == 1)
        {
            gameManagerScript.Unlock(toppingList[1]);
        }
        if (cheeseBuy == 1)
        {
            gameManagerScript.Unlock(toppingList[2]);
        }
        if (lettuceBuy == 1)
        {
            gameManagerScript.Unlock(toppingList[3]);
        }
        if (blackOlivesBuy == 1)
        {
            gameManagerScript.Unlock(toppingList[4]);
        }
        if (jamBuy == 1)
        {
            gameManagerScript.Unlock(toppingList[5]);
        }
        if (chocRellaBuy == 1)
        {
            gameManagerScript.Unlock(toppingList[6]);
        }
    }

    void Say(string input)
    {
        Debug.Log(input);
    }

    public void Buy(string topping)
    {
        if (topping == toppingList[0])
        {
            int indexNumber = 0; 
            Say(toppingList[indexNumber]);
            Say("User Purchased " + topping + " Which Is Number #" + indexNumber + " On The List. The Price Was " + toppingPriceList[indexNumber] + " Points!");
            if (toppingPriceList[indexNumber] <= done.score && sauceBuy == 0)
            {
                Say("We can Buy!" + toppingList[indexNumber]);
                Say(done.score.ToString());

                done.score -= toppingPriceList[indexNumber];
                done.scoreText.text = done.score.ToString();
                done.scoreOptionsText.text = "Score: " + done.score.ToString();
                PlayerPrefs.SetInt("score", done.score);
                sauceBuy = 1;
                PlayerPrefs.SetInt("sauceBuy", sauceBuy);
                gameManagerScript.Unlock(toppingList[indexNumber]);
                // Unlocked It!!
            }
            
        }
        if (topping == toppingList[1])
        {
            int indexNumber = 1;
            Say(toppingList[indexNumber]);
            Say("User Purchased " + topping + " Which Is Number #" + indexNumber + " On The List. The Price Was " + toppingPriceList[indexNumber] + " Points!");
            if (toppingPriceList[indexNumber] <= done.score && mustardBuy == 0)
            {
                Say("We can Buy!" + toppingList[indexNumber]);
                Say(done.score.ToString());

                done.score -= toppingPriceList[indexNumber];
                done.scoreText.text = done.score.ToString();
                done.scoreOptionsText.text = "Score: " + done.score.ToString();
                PlayerPrefs.SetInt("score", done.score);
                mustardBuy = 1;
                PlayerPrefs.SetInt("mustardBuy", mustardBuy);
                
                gameManagerScript.Unlock(toppingList[indexNumber]);
                // Unlocked It!!
            }
        }
        if (topping == toppingList[2])
        {
            int indexNumber = 2;
            Say(toppingList[indexNumber]);
            Say("User Purchased " + topping + " Which Is Number #" + indexNumber + " On The List. The Price Was " + toppingPriceList[indexNumber] + " Points!");
            if (toppingPriceList[indexNumber] <= done.score && cheeseBuy == 0)
            {
                Say("We can Buy!" + toppingList[indexNumber]);
                Say(done.score.ToString());

                done.score -= toppingPriceList[indexNumber];
                done.scoreText.text = done.score.ToString();
                done.scoreOptionsText.text = "Score: " + done.score.ToString();
                PlayerPrefs.SetInt("score", done.score);
                cheeseBuy = 1;
                PlayerPrefs.SetInt("cheeseBuy", cheeseBuy);
                
                gameManagerScript.Unlock(toppingList[indexNumber]);
                // Unlocked It!!
            }
        }
        if (topping == toppingList[3])
        {
            int indexNumber = 3;
            Say(toppingList[indexNumber]);
            Say("User Purchased " + topping + " Which Is Number #" + indexNumber + " On The List. The Price Was " + toppingPriceList[indexNumber] + " Points!");
            if (toppingPriceList[indexNumber] <= done.score && lettuceBuy == 0)
            {
                Say("We can Buy!" + toppingList[indexNumber]);
                Say(done.score.ToString());

                done.score -= toppingPriceList[indexNumber];
                done.scoreText.text = done.score.ToString();
                done.scoreOptionsText.text = "Score: " + done.score.ToString();
                PlayerPrefs.SetInt("score", done.score);
                lettuceBuy = 1;
                PlayerPrefs.SetInt("lettuceBuy", lettuceBuy);
                
                gameManagerScript.Unlock(toppingList[indexNumber]);
                // Unlocked It!!
            }
        }
        if (topping == toppingList[4])
        {
            int indexNumber = 4;
            Say(toppingList[indexNumber]);
            Say("User Purchased " + topping + " Which Is Number #" + indexNumber + " On The List. The Price Was " + toppingPriceList[indexNumber] + " Points!");
            if (toppingPriceList[indexNumber] <= done.score && blackOlivesBuy == 0)
            {
                Say("We can Buy!" + toppingList[indexNumber]);
                Say(done.score.ToString());

                done.score -= toppingPriceList[indexNumber];
                done.scoreText.text = done.score.ToString();
                done.scoreOptionsText.text = "Score: " + done.score.ToString();
                PlayerPrefs.SetInt("score", done.score);
                blackOlivesBuy = 1;
                PlayerPrefs.SetInt("blackOlivesBuy", blackOlivesBuy);
                
                gameManagerScript.Unlock(toppingList[indexNumber]);
                // Unlocked It!!
            }
        }
        if (topping == toppingList[5])
        {
            int indexNumber = 5;
            Say(toppingList[indexNumber]);
            Say("User Purchased " + topping + " Which Is Number #" + indexNumber + " On The List. The Price Was " + toppingPriceList[indexNumber] + " Points!");
            if (toppingPriceList[indexNumber] <= done.score && jamBuy == 0)
            {
                Say("We can Buy!" + toppingList[indexNumber]);
                Say(done.score.ToString());

                done.score -= toppingPriceList[indexNumber];
                done.scoreText.text = done.score.ToString();
                done.scoreOptionsText.text = "Score: " + done.score.ToString();
                PlayerPrefs.SetInt("score", done.score);
                jamBuy = 1;
                PlayerPrefs.SetInt("jamBuy", jamBuy);
                
                gameManagerScript.Unlock(toppingList[indexNumber]);
                // Unlocked It!!
            }
        }
        if (topping == toppingList[6])
        {
            int indexNumber = 6;
            Say(toppingList[indexNumber]);
            Say("User Purchased " + topping + " Which Is Number #" + indexNumber + " On The List. The Price Was " + toppingPriceList[indexNumber] + " Points!");
            if (toppingPriceList[indexNumber] <= done.score && chocRellaBuy == 0)
            {
                Say("We can Buy!" + toppingList[indexNumber]);
                Say(done.score.ToString());

                done.score -= toppingPriceList[indexNumber];
                done.scoreText.text = done.score.ToString();
                done.scoreOptionsText.text = "Score: " + done.score.ToString();
                PlayerPrefs.SetInt("score", done.score);
                chocRellaBuy = 1;
                PlayerPrefs.SetInt("chocRellaBuy", chocRellaBuy);
                
                gameManagerScript.Unlock(toppingList[indexNumber]);
                // Unlocked It!!
            }
        }
    }
}
