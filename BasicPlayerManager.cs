using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicPlayerManager : MonoBehaviour
{
    /// <summary>
    /// is supposed to sit between user manager and input managers
    /// cement script
    /// 
    /// has to be accessible by other scripts right away
    /// caching references for higher performance
    /// </summary>
    public bool didInit; //did initialized
    public BasicUserManager DataManager;

    public virtual void Awake()
    {
        didInit = false;
        Init();
    }
    public virtual void Init()
    {
        //caching
        DataManager = gameObject.GetComponent<BasicUserManager>();
        if (DataManager == null)
            DataManager = gameObject.AddComponent<BasicUserManager>();

        didInit = true;
    }
    public virtual void GameFinished()
    {
        //Game over
        //changed by GameManager or GameStateManager or anything
        DataManager.SetIsFinished(true);
    }
    public virtual void GameStart()
    {
        DataManager.SetIsFinished(false);
    }
}
