using InnScripts.Actions;
using UnityEngine;

public class TimeDelay : RepetebleActivator
{
    bool active = false;

    public void SetActive(bool setLastTime = false)
    {
        active = true;
        if (setLastTime) lastActivateTime = Time.time;
    }


    public override void Activate()
    {
        base.Activate();
        active = false;        
    }
       

    protected override bool Check()
    {
        return active;
    }  


}
