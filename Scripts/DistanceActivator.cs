using InnScripts.Actions;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistanceActivator : Activator
{
    [SerializeField]
    bool OneTime;
    [SerializeField]
    float ActivateDistance;
    [SerializeField]
    Transform target;

    public void SetTarget(Transform _target)
    {
        this.target = _target;
    } public void SetInteract(Interact _interact)
    {
        this.Interact = _interact;
    }
    public void Restart()
    {
        activated = false;
    }

    bool activated = false;
    protected override bool Check()
    {
        bool result = Vector3.Distance(transform.position, target.transform.position) <= ActivateDistance;
       
        if (OneTime)
        {
            if (!activated)
            {
                if (result)
                {                
                    activated = true;
                    return true;
                }

            }
            return false;
        }
        else 
            return result;

    }
}
