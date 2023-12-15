using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class PlayTutorial : MonoBehaviour
{
    public PlayableDirector timeline;
    public GameObject tutorial;

    public void PlayHowTo()
    {
        timeline.Play();
    }
}
