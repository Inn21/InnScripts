using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using InnScripts.Actions;
using UnityEngine.SceneManagement;

public class RelaodScene : InnAction
{
    public override void Activate()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
