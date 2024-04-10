using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public static class Game
{
    public static includedInteract StartActions;
    public static includedInteract PauseActions;
    public static includedInteract ContinueActions;
    public static includedInteract EndActions;

    public static bool playing = false;
    public static bool paused = true;
    public static void Start()
    {
        if (!playing)
        {
            Debug.Log("-=Inn Script=-: Game Start");
            StartActions?.Activate();
            playing = true;
            paused = false;
        }
    }
    public static void End()
    {
        if (playing)
        {
            Debug.Log("-=Inn Script=-: Game End");
            EndActions?.Activate();
            playing = false;
        }
    }
    public static void Pause()
    {
        if (playing && !paused)
        {
            Print.Log("-=Inn Script=-: Game Pause");
            PauseActions?.Activate();
            paused = true;
        }

    }
    public static void Continue()
    {
        if (playing && paused)
        {
            Print.Log("-=Inn Script=-: Game Continue");
            ContinueActions?.Activate();
            paused = false;
        }
    }


}
