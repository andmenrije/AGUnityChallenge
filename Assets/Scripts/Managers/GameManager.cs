﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        AudioManager.Instance.PlayAudio(AudioManager.AudioType.Background);
        CounterManager.Instance.ResetScore();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
