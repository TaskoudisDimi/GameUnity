using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class End : MonoBehaviour
{

    public GameObject completeLevelUI;
    private float delayLoad = 2.0f;

    public void EndGame()
    {
        Debug.Log("Won");
    }

    public void OnTriggerEnter()
    {
        EndGame();
        CompleteLevel();

    }

    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);
        Invoke("LoadScene", delayLoad);

    }

    public void LoadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}
