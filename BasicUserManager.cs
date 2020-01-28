using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicUserManager : MonoBehaviour
{
    /// <summary>
    /// stores basic player data like
    /// score
    /// health
    /// state
    /// etc
    /// </summary>
    int score;
    int highScore;
    int level;
    int health;
    bool isFinished;

    string playerName;

    public virtual void GetDefaultData()
    {
        playerName = "Anonymous";
        score = 0;
        level = 0;
        health = 0;
        highScore = 0;
        isFinished = false;
    }
    public string GetName()
    {
        return playerName;
    }
    public void SetName (string aName)
    {
        playerName = aName;
    }
    public int GetLevel()
    {
        return level;
    }
    public void SetLevel (int num)
    {
        level = num;
    }
    public int GetHighScore()
    {
        return highScore;
    }
    public int GetScore()
    {
        return score;
    }
    public virtual void AddScore(int anAmount)
    {
        score += anAmount;
    }
    public void lostScore(int num)
    {
        score -= num;
    }
    public void SetScore(int num)
    {
        score = num;
    }
    public int GetHealth()
    {
        return health;
    }
    public void AddHealth(int num)
    {
        health += num;
    }
    public void ReduceHealth(int num)
    {
        health -= num;
    }
    public void SetHealth(int num)
    {
        health = num;
    }
    public bool GetIsFinished()
    {
        return isFinished;
    }
    public void SetIsFinished(bool aVal)
    {
        isFinished = aVal;
    }
}
