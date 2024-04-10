using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivatorWithCounter : InnScripts.Actions.NoRepActivator
{
    uint _count;
    [SerializeField] uint Count;

    public override void Activate()
    {
        Print.Log($"Activated {_count+1}/{Count}!");
        if (_count == Count-1)
        {
            _count = 0;
            base.Activate();
        }
        else
            _count++;
    }
}
