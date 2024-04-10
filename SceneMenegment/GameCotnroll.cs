using InnScripts.Actions;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameCotnroll : MonoBehaviour
{
    [SerializeField] includedInteract SceneStartActions;
    [Header("GameStart")]
    [SerializeField] bool StartWithScene = false;
    [SerializeField] includedInteract GameStartActions;
    [Space]
    [SerializeField] includedInteract GamePauseActions;
    [SerializeField] includedInteract GameContinueActions;
    [Space]
    [SerializeField] includedInteract GameEndActions;


    private void Awake()
    {
        Game.StartActions = GameStartActions;
        Game.PauseActions = GamePauseActions;
        Game.ContinueActions = GameContinueActions;
        Game.EndActions = GameEndActions;
        Game.playing = false;
        Game.paused = true;

        SceneStartActions.Activate();

        if (StartWithScene)
            Game.Start();
    }

    public void StartGame()
    {
        if(!Game.playing)
            Game.Start();
    }

    public void Pause()
    {   
        if (!Game.paused)
            Game.Pause();
    }
    public void Continue()
    {
        if (Game.playing)
        {
            if (Game.paused)
                Game.Continue();
        }
        else
        {
            Game.Start();
        }
    }
    public void Pause_Continue()
    {
        if (Game.playing)
        {
            if (Game.paused)
            {
                Game.Continue();
            }
            else
            {
                Game.Pause();
            }
        }
        else
        {
            Game.Start();            
        }
    }
    public void EndGame()
    {
        if (!Game.playing)
            Game.End();
    }

    
}

