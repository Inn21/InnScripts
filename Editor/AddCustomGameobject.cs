using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using InnScripts;

public class AddCustomGameobject
{
    /// <summary>
    /// Add a object with InnScript.Tags component.
    /// </summary>
    [MenuItem("GameObject/Create Empty with custom Tag", false, 0)]
    static void CreateCustomGameObject(MenuCommand menuCommand)
    {
        // Create a custom game object
        GameObject go = new GameObject("MyObject");
        go.AddComponent<Tags>();

        // Ensure it gets reparented if this was a context click (otherwise does nothing)
        GameObjectUtility.SetParentAndAlign(go, menuCommand.context as GameObject);

        // Register the creation in the undo system
        Undo.RegisterCreatedObjectUndo(go, "Create " + go.name);
        Selection.activeObject = go;
    }
}
