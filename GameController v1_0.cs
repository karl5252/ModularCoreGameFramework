using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControllerv1_0 : MonoBehaviour
{   /// <summary>
/// Game manager purpose:
///1. Tracking and storing the game state
///a.Functions for changing the game state(StartGame() , PauseGame(), GameOver(), OnWinGame(), LoadCutscene(), LoadSomething())
///b.Changing the game state,
///
///2. Creating player/ players objects
///3. Camera Setup
///4. Communicating between manager scripts like: session , user, score etc etc

///There may also be several custom states that are applicable to particular types of
//games, such as a state for showing a cutscene or perhaps a state for playing a special audio
//clip.
/// </summary>
/// 
    bool paused;
    public GameObject explosionPrefab;

    public virtual void PlayerLostLife()
    {
        Debug.Log("You are dead Mr. Player");
        //player died; update UI etc
    }
    public virtual void SpawnPlayer()
    {
        Debug.Log("Welcome player!");
        //spawn playera
    }
    public virtual void RespawnPlayer()
    {
        Debug.Log("Welcome back player!");
    }
    public virtual void StartGame()
    {
        //start game
    }
    public virtual void RestartGame()
    {
        //restart currently loaded scene on keypress/buttonclick
        Application.LoadLevel(Application.loadedLevel);
        Debug.Log("Restarting level...");
    }

    public bool Paused //above paused is private 
    {
        get
        {
            //get paused
            return paused;
        }
        set
        {
            //set state
            paused = value;
            if(paused)
            {
                Time.timeScale = 0.0f;
                Debug.Log("Game Paused");
            } else
            {
                Time.timeScale = 1.0f;
            }
        }
    }

    public void Explode(Vector3 aPosition)
    {
        //Instantiate explosion at position passed
        Instantiate(explosionPrefab, aPosition, Quaternion.identity)
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
