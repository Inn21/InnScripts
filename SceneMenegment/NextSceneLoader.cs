using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using InnScripts.Actions;
using UnityEngine.SceneManagement;
using Unity.Mathematics;

public class NextSceneLoader : InnAction
{
    enum LastScene
    {
        LoadFirst,
        LoadLast
    }

    [SerializeField]
    private LastScene LastSceneLoadType;

    [SerializeField]
    uint FirstSceneIndex = 0;
    
    public override void Activate()
    {
        int nextIndex = 0;
        nextIndex = math.clamp(SceneManager.GetActiveScene().buildIndex + 1, 0, SceneManager.sceneCountInBuildSettings);
        switch (LastSceneLoadType)
        {
            case LastScene.LoadLast:
               
                break;
            case LastScene.LoadFirst:
                if (SceneManager.GetActiveScene().buildIndex == SceneManager.sceneCountInBuildSettings-1)
                {
                    nextIndex = (int)FirstSceneIndex;
                }
                break;
            default:
                break;
        }

       
        SceneManager.LoadScene(nextIndex);
    }
}
