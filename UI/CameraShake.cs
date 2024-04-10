using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour
{
    [SerializeField] float duration;
    [SerializeField] float strength = 3;
    [SerializeField] int vibratio = 10;
    public void Shake()
    {
        Camera.main.DOShakePosition(duration, strength, vibratio);
    }
}
