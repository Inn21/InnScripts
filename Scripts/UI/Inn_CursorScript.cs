
//using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inn_CursorScript : MonoBehaviour
{
    [SerializeField] KeyCode EnableCursorKey;
    [SerializeField][Range(0,3)] float  ScaleOnTime= 0.5f;
    [SerializeField][Range(0, 3)] float ScaleOffTime = 0.25f;
    [SerializeField][Range(0, 2)] float ScaleRange = 0.7f;
    bool enableCursor = true;
    Image cursorImage;
    Vector3 StartScale;

    private void Start()
    {
        cursorImage = GetComponent<Image>();
        StartScale = cursorImage.rectTransform.localScale;
    }

    

    private void Update()
    {
        cursorImage.rectTransform.position = Input.mousePosition;

        if (Input.GetKeyDown(EnableCursorKey))
        {
            enableCursor = !enableCursor;
            cursorImage.enabled = enableCursor;
        }

        // ---=IF DoTween USED:=---

        //if (Input.GetMouseButton(0) || Input.touchCount != 0)
        //{
        //    Sequence sequence = DOTween.Sequence();

        //    sequence.Append(cursorImage.rectTransform.DOScale(StartScale * ScaleRange, ScaleOnTime));
        //    sequence.Append(cursorImage.rectTransform.DOScale(StartScale, ScaleOffTime));
        //    sequence.Play();
        //}


    }

}
