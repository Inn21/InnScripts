using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Save_Load_DeleteKeys : MonoBehaviour
{
    [SerializeField] List<string> keys = new List<string>();
    public void DeleteSavedValues()
    {
        foreach (string key in keys)
        {
            if (PlayerPrefs.HasKey(key))
            {
                PlayerPrefs.DeleteKey(key);
            }
        }
    }
}
