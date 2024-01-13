using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    public Animator transition;
    public ModeSeceletion modeSeceletion;

    public float transitionTime = 1f;

    // Update is called once per frame
    void Update()
    {
        if (SceneManager.GetActiveScene().buildIndex == 0)
        {
            if (Input.GetKey(KeyCode.S))
            {
                LoadNextLevel();
            }
        }
        
    }

    public void HomeButton()
    {
        StartCoroutine(LoadLevelString("MainMenu"));
    }

    public void LoadStringLevel(string sceneName)
    {
        StartCoroutine(LoadLevelString(sceneName));
    }

    public void PlayButton()
    {
        if (modeSeceletion.mode == 0)
        {
            Debug.Log("Go to " + modeSeceletion.mode.ToString());
            LoadStringLevel("Game");
        }

        if (modeSeceletion.mode == 1)
        {
            Debug.Log("Go to " + modeSeceletion.mode);
            LoadStringLevel("List Mode");
        }
    }

    public void LoadNextLevel()
    {
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));
    }

    IEnumerator LoadLevel(int levelIndex)
    {
        transition.SetTrigger("Start");

        yield return new WaitForSeconds(transitionTime);

        SceneManager.LoadScene(levelIndex);
    }

    IEnumerator LoadLevelString(string levelName)
    {
        transition.SetTrigger("Start");

        yield return new WaitForSeconds(transitionTime);

        SceneManager.LoadScene(levelName);
    }
}
