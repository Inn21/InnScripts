using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Save_LoadController : MonoBehaviour
{
   [SerializeField]List<Save_LoadBase> save_LoadScripts = new List<Save_LoadBase>();

    public void Load()
    {
        foreach (Save_LoadBase item in save_LoadScripts)
        {
            if (item == null) continue;

            item.Load();
        }
    } 
    public void Save()
    {
        foreach (Save_LoadBase item in save_LoadScripts)
        {
            if (item == null) continue;

            item.Save();
        }
    }
}
