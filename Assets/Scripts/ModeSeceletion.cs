using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModeSeceletion : MonoBehaviour
{
    public int mode;

    public GameObject checkBoxForOrginal;
    public GameObject checkBoxForList;
    public GameObject checkBoxForTimer;

    void Start()
    {
        Mode(0);
    }

    public void Mode(int modeIndex)
    {
        mode = modeIndex;
        if (mode == 0) // 0 means Orginal Mode
        {
            checkBoxForOrginal.SetActive(true);
            checkBoxForList.SetActive(false);
            checkBoxForTimer.SetActive(false);
        }

        if (mode == 1) // 1 means List Mode
        {
            checkBoxForOrginal.SetActive(false);
            checkBoxForTimer.SetActive(false);
            checkBoxForList.SetActive(true);
        }

        if (mode == 2) // 2 means Timer Mode
        {
            checkBoxForOrginal.SetActive(false);
            checkBoxForList.SetActive(false);
            checkBoxForTimer.SetActive(true);
        }
    }

    
}
