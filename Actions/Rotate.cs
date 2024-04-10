using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using InnScripts.Movement;
using Unity.Mathematics;

[AddComponentMenu("InnScrips/Move/Rotare")]
[RequireComponent(typeof(Move))]
public class Rotate : MonoBehaviour, IRepetebleMovement
{    

    [field: SerializeField]
    public float movementSpead { get; set; } = 0;
    public bool PlayOnStart { get; set; }

    public void Move()
    {
        transform.Rotate(new Vector3(0, 0.5f, 0), movementSpead);
    }

    public void StartMove()
    {
    }

    public void StopMove()
    {

    }
}

