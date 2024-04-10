using InnScripts.Actions;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class FailControll : MonoBehaviour
{
    [SerializeField] includedInteract interact;

    private void Awake()
    {
        Fail.interact = interact;
        Fail.failed = false;
    }
}

public static class Fail
{
    public static includedInteract interact;

    public static bool failed = false;
    public static void End()
    {
        if (!failed) {
            Print.Log("-=Inn Script=-:  Fail");
            interact?.Activate();
            failed = true;
        }
    }
}

