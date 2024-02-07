

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using InnScripts.Actions;
using InnScripts;
using Unity.VisualScripting;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class TimeDelay : Activator
{
    bool active = false;

    public void SetActive()
    {
        active = true; 
    }


    protected override void Activate()
    {
        base.Activate();
        active = false;
    }
       

    protected override bool Check()
    {
        return active;
    }  


}
