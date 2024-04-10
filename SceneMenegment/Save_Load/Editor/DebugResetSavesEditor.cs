using UnityEditor;
using UnityEngine;
#if (UNITY_EDITOR) 
[CustomEditor(typeof(DebugResetSaves))] 
public class DebugResetSavesEditor : Editor
{
    public override void OnInspectorGUI()
    {
        EditorGUILayout.BeginHorizontal();
        DebugResetSaves resetSaves = (DebugResetSaves)target;

        if (GUILayout.Button("ClearPlayerPrefs"))
        {
            resetSaves.ClearPlayerPrefs();
        }
        EditorGUILayout.EndHorizontal();
    }
}
#endif
