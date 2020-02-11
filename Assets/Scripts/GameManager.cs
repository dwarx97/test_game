using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool isEnded = false;
    public float restartDelay = 1.5f;
    public GameObject completeLevelUI;
    public void EndGame()
    {
        if (this.isEnded == false)
        {
            this.isEnded = true;
            Debug.Log("Game over.");
            Invoke("Restart", restartDelay); //seconds
        }
    }
    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);
    }
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

}
