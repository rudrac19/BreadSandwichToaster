using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ListTranslater : MonoBehaviour
{
    public GameObject[] spaceOne;
    public GameObject[] spaceTwo;
    public GameObject[] spaceThree;
    public GameObject[] spaceFour;
    public GameObject[] spaceFive;

    public void Translate(List<int> toppingList)
    {
        spaceOne[0].SetActive(false);
        spaceOne[1].SetActive(false);
        spaceOne[2].SetActive(false);
        spaceOne[3].SetActive(false);
        spaceOne[4].SetActive(false);
        spaceOne[5].SetActive(false);
        spaceOne[6].SetActive(false);
        spaceOne[7].SetActive(false);
        spaceOne[8].SetActive(false);
        spaceOne[9].SetActive(false);

        spaceTwo[0].SetActive(false);
        spaceTwo[1].SetActive(false);
        spaceTwo[2].SetActive(false);
        spaceTwo[3].SetActive(false);
        spaceTwo[4].SetActive(false);
        spaceTwo[5].SetActive(false);
        spaceTwo[6].SetActive(false);
        spaceTwo[7].SetActive(false);
        spaceTwo[8].SetActive(false);
        spaceTwo[9].SetActive(false);

        spaceThree[0].SetActive(false);
        spaceThree[1].SetActive(false);
        spaceThree[2].SetActive(false);
        spaceThree[3].SetActive(false);
        spaceThree[4].SetActive(false);
        spaceThree[5].SetActive(false);
        spaceThree[6].SetActive(false);
        spaceThree[7].SetActive(false);
        spaceThree[8].SetActive(false);
        spaceThree[9].SetActive(false);

        spaceFour[0].SetActive(false);
        spaceFour[1].SetActive(false);
        spaceFour[2].SetActive(false);
        spaceFour[3].SetActive(false);
        spaceFour[4].SetActive(false);
        spaceFour[5].SetActive(false);
        spaceFour[6].SetActive(false);
        spaceFour[7].SetActive(false);
        spaceFour[8].SetActive(false);
        spaceFour[9].SetActive(false);

        spaceFive[0].SetActive(false);
        spaceFive[1].SetActive(false);
        spaceFive[2].SetActive(false);
        spaceFive[3].SetActive(false);
        spaceFive[4].SetActive(false);
        spaceFive[5].SetActive(false);
        spaceFive[6].SetActive(false);
        spaceFive[7].SetActive(false);
        spaceFive[8].SetActive(false);
        spaceFive[9].SetActive(false);
        
        int top1 = toppingList[0];
        int top2 = toppingList[1];
        int top3 = toppingList[2];
        int top4 = toppingList[3];
        int top5 = toppingList[4];

        DisplaySpaceOne(top1);
        DisplaySpaceTwo(top2);
        DisplaySpaceThree(top3);
        DisplaySpaceFour(top4);
        DisplaySpaceFive(top5);
    }

    public void DisplaySpaceOne(int toppingOneIndex)
    {
        spaceOne[toppingOneIndex].SetActive(true);
    }
    public void DisplaySpaceTwo(int toppingTwoIndex)
    {
        spaceTwo[toppingTwoIndex].SetActive(true);
    }
    public void DisplaySpaceThree(int toppingThreeIndex)
    {
        spaceThree[toppingThreeIndex].SetActive(true);
    }
    public void DisplaySpaceFour(int toppingFourIndex)
    {
        spaceFour[toppingFourIndex].SetActive(true);
    }
    public void DisplaySpaceFive(int toppingFiveIndex)
    {
        spaceFive[toppingFiveIndex].SetActive(true);
    }



}
