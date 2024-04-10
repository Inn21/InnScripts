using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Timer : MonoBehaviour
{
    [SerializeField] List<TimePoint> TimePoints;

    private void Update()
    {
        foreach (TimePoint point in TimePoints)
        {
            if (point != null && point.used == false)
            {
                if (Time.time >= point.Sec)
                {
                    Print.Log($"InnTimer: {point.Message}");
                    point.Action?.Invoke();
                    point.used = true;
                }
            }
        }
    }


}

[Serializable]
public class TimePoint
{
    public float Sec;
    public string Message;
    public UnityEvent Action;
    [HideInInspector] public bool used = false;
}
