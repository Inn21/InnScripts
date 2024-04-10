using UnityEngine;

public static class Print
{
    public static void Log(string text)
    {
    #if UNITY_EDITOR
            Debug.Log(text);
    #endif
    } public static void Warning(string text)
    {
    #if UNITY_EDITOR
            Debug.LogWarning(text);
    #endif
    }
    public static void Eror(string text)
    {
    #if UNITY_EDITOR
            Debug.LogError(text);
    #endif
    }
}
