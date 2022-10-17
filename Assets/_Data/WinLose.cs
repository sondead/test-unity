using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class WinLose : MonoBehaviour
{
    private bool gameEnded;
    public string nextLevelName;
    public int levelNumberSave;

    public GameObject winPanel;
    public void WinLevel()
    {
        if (!gameEnded)
        {
            Debug.Log("You Win!!!");

            winPanel.SetActive(true);
            gameEnded = true;

        }
    }

    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void LoseLevel()
    {
        if (!gameEnded)
        {
            Debug.Log("You Lose?");
            RestartLevel();
            gameEnded = true;

        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
