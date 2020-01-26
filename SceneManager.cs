using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManager : MonoBehaviour
{
    public string[] levelNames;
    public int gameLevelNumber;
    public GameObject gameManager;


    // Start is called before the first frame update
    void Start()
    {
        
        gameManager = GameObject.Find("GameManger");
        if (gameManager == null)
        {
            DontDestroyOnLoad(this.gameObject);
        }
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void LoadLevel(string sceneName)
    {
        Application.LoadLevel(sceneName);
    }
    private void LoadLevel(int indexNum) //alternative
    {
        LoadLevel(levelNames[indexNum]);
    }
    public void loadNextLevel()
    {
        if (gameLevelNumber >= levelNames.Length)
            gameLevelNumber = 0;

        LoadLevel(gameLevelNumber);
        gameLevelNumber++;
    }
    public void ResetGame()
    {
        gameLevelNumber = 0;
    }

}
    
