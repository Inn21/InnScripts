using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleByTween: InnScripts.Actions.InnAction
{
    [SerializeField] GameObject Target;
    [SerializeField] Vector3 ChangeOn = new Vector3(1,1,1);
    [SerializeField] float duration = 1f;
    [SerializeField] Ease ScaleEase;


    private void Start()
    {
        if (Target == null)
            Target = gameObject;
    }
    public override void Activate()
    {
        Target.transform.DOScale(Target.transform.localScale + ChangeOn, duration).SetEase(ScaleEase);            
    }
}
