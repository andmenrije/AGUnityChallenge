using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseActivatedHelper : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void HandlePauseClick()
    {
        AudioManager.Instance.StopAudio(AudioManager.AudioType.Background);
        AudioManager.Instance.PlayAudio(AudioManager.AudioType.Pause);
    }

    public void HandleReturnToGame()
    {
        AudioManager.Instance.StopAudio(AudioManager.AudioType.Pause);
        AudioManager.Instance.PlayAudio(AudioManager.AudioType.Background);
    }

}
