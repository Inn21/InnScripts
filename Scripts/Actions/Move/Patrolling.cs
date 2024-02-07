using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using InnScripts.Movement;
using Unity.Mathematics;
using System;

[AddComponentMenu("InnScrips/Move/Patrolling")]
[RequireComponent(typeof(Move))]
public class Patrolling : MonoBehaviour, IRepetebleMovement
{   


    [field: SerializeField] public float movementSpead { get; set; } = 0;

    [field: SerializeField] public bool PlayOnStart { get; set; }

    [SerializeField] List<PatrolPoint> patrolPoints = new List<PatrolPoint>();

    int curentPointIndex = 0;
    [SerializeField] PatrolPoint NextPoint;

    [SerializeField] bool move = false;
    public void StartMove()
    {
        NextPoint = patrolPoints[0];
        move = true;
    }
    public void StopMove()
    {
        movementSpead = 0;
    }

    public void Move()
    {
        CheckDistanceToNextPoint();
        if (move)
            transform.position = Vector3.MoveTowards(transform.position, NextPoint.position, movementSpead*Time.fixedDeltaTime);
    }

    

    public void GetNextPoint()
    {
        curentPointIndex = (curentPointIndex + 1) % patrolPoints.Count;
        NextPoint = patrolPoints[curentPointIndex];
    }

    float StartPauseTime = 0;

    private void CheckDistanceToNextPoint()
    {
        if (Vector3.Distance(transform.position, NextPoint.position) < 0.01f)
        {
            if (move == true)
            {
                StartPauseTime = Time.time;
                move = false;
            }
            else if (Time.time > StartPauseTime + NextPoint.stayTime)
            {
                GetNextPoint();
                move = true;
            }
        }
    }
   


}
[Serializable]
public class PatrolPoint
{
    public Transform WorldPoint;

    [HideInInspector]public Vector3 position { get => WorldPoint.position; protected set {} }

    public float stayTime;
}

