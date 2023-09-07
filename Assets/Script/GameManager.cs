using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    // Write down your variables here
    int score = 0;

    private void Awake()
    {
        Instance = this;
    }

    public void IncrementScore()
    {
        if(score <= 4)
        {
            Debug.Log("You Win");
        }
    }
}