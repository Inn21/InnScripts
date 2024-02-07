using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtObjectScript : MonoBehaviour
{
    [SerializeField] Transform Target ;

    private void Start()
    {
        Target = Camera.main.transform;
    }

    private void FixedUpdate()
    {
        Vector3 pos = new Vector3(transform.position.x, Target.position.y, Target.position.z);
        transform.LookAt(pos);
    }

}
