
using UnityEngine;

public class DebugResetSaves : MonoBehaviour
{    public void ClearPlayerPrefs()
    {
        #if UNITY_EDITOR
            Save_Load.Clear();
        #endif
    }
}
