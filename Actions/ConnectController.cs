using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using InnScripts;
using System;

public class ConnectController : MonoBehaviour
{
    public List<GameObject> Conneced = new List<GameObject>();

    [SerializeField]
    Transform DefaultParent = null;
    [SerializeField]
    Tag ConectedTag;


    public event Action<GameObject> AfterConnect = delegate { };
    public event Action<GameObject> AfterDisconnect = delegate { };

    private void Awake()
    {
        foreach (GameObject obj in Conneced)
        {
            if (obj != null)
            {
                obj.name = $"Conected{obj.name}";
                obj.AddTag(ConectedTag);
                obj.transform.parent = transform;
            }
        }
    }

    public bool Connect(GameObject _object)
    {
        if (_object != null && !Conneced.Contains(_object))
        {
            _object.name = $"Conected{_object.name}";
            Conneced.Add(_object);
            _object.transform.parent = transform;
            AfterConnect(_object);
        }
        else return false;
        return true;
    }

    public void Disconnect(GameObject _object)
    {
        if (_object != null && Conneced.Contains(_object))
        {            
            Conneced.Remove(_object);
            _object.transform.parent = DefaultParent;
            AfterDisconnect(_object);
        }
    }
}
