using InnScripts.Movement;

using System.Collections;
using UnityEngine;



[AddComponentMenu("InnScrips/Move/-=Move=-")]
public class Move : MonoBehaviour
{
    IRepetebleMovement[] repetebleMovement;
    IMovement movement;

    public void Awake()
    {
        repetebleMovement = GetComponents<IRepetebleMovement>();       
    }

    private void Start()
    {
        foreach (var m in repetebleMovement)
        {
            if (m.PlayOnStart)
            {
                m.StartMove();
            }
        }
    }


    private void FixedUpdate()
    {
        foreach (var m in repetebleMovement)
        {
            m?.Move();
        }
    }
}

namespace InnScripts.Movement
{
    interface IRepetebleMovement
    {
        float movementSpead { get; set; }
        void Move();
        bool PlayOnStart { get;  set; }
        void StartMove();
        void StopMove();

    }

    interface IMovement
    {
        float movementSpead { get; set; }
        void Move();
        void Stop();

    }
    
}

