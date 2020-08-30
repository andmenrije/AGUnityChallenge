using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using TMPro;
using UnityEngine;

public class CounterManager : MonoBehaviour
{

    private static CounterManager instance;
    public static CounterManager Instance
    {
        get
        {
            if(instance == null)
            {
                instance = FindObjectOfType<CounterManager>();
                if(instance == null)
                {
                    instance = new GameObject("CounterManager", typeof(AudioManager)).GetComponent<CounterManager>();
                }
            }
            return instance;
        }
    }

    private TextMeshProUGUI scoreTextComponent;
    private uint currentScore = 0;
    // Start is called before the first frame update
    void Start()
    {
        scoreTextComponent = GetComponent<TextMeshProUGUI>();
        if(scoreTextComponent)
        {
            Debug.Log("Updated score in start");
            scoreTextComponent.SetText("0");
        }
    }


    public void AddOneToScore()
    {
        // if player reached 10000000, need to celebrate the player's tapping greatness
        if (currentScore <= 1000000)
        {
            currentScore += 1;
        }
        scoreTextComponent.SetText(currentScore.ToString());
        
    }

    public void ResetScore()
    {
        currentScore = 0;
        scoreTextComponent.SetText(currentScore.ToString());
    }


}
