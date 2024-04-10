using System;
using UnityEngine;
using UnityEngine.Events;

[Serializable] public class includedInteract
{
    [field: SerializeField]
    UnityEvent activate;
    public void Activate()
    {
        activate?.Invoke();
    }
}
