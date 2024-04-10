using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Save_LoadBase : MonoBehaviour
{
    [SerializeField]protected string Key;
    public abstract void Load();

    public abstract void Save();

}
