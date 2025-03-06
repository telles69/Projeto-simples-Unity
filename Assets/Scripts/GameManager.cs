using System;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    bool GameHasEnded = false;
    public float Delay = 1f;

    public GameObject CompleteLevelUI;

    public void CompleteLevel1 (){
        CompleteLevelUI.SetActive(true);
    }
    public void EndGame()
    {
        if (GameHasEnded == false)
        {
            GameHasEnded = true;
            Debug.Log("Game over!");
            Invoke("Restart", Delay);
        }
    }
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);  
    }
}
