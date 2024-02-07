using InnScripts.Actions;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FailControll : MonoBehaviour
{
    [SerializeField] Interact interact;

    private void Awake()
    {
        FailScript.interact = interact;
    }
}

public static class FailScript
{
    public static Interact interact;

    public static bool failed = false;
    public static void Fail()
    {
        if (!failed) {
            Debug.Log("-=Inn Script=-:  Fail");
            interact?.Activate();
            failed = true;
        }
    }
}
