using System.Collections.Generic;
using UnityEngine;
using InnScripts.Actions;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using System;

[AddComponentMenu("InnScrips/Actions/Activators/Old/KeyPress(old)")]
[RequireComponent(typeof(NoRepActivator))]
public class OldKeyPress : InnScripts.Actions.RepetebleOutInteractActivator, ICheckUITap
{
    enum pressType
    {
        GetUp,
        GetDown,
        GetKey
    }

    [Space(10)]
    [SerializeField] KeyCode Key = KeyCode.Space;
    [SerializeField] pressType PressType = pressType.GetKey;

    [Header("UICheck")]
    [SerializeField] bool ChechUI;

    public Vector3 screanPos { get; set; }
    [field: SerializeField] public GraphicRaycaster UICanvas { get; set; }
    public PointerEventData PointerEventData { get; set; }
    [field: SerializeField] public EventSystem EventSystem { get; set; }



    Vector2 GetTouchPoint()
    {
        Vector2 result = Vector2.zero;
        if (SystemInfo.deviceType == DeviceType.Handheld)
            result = Input.GetTouch(0).position;
        else
            result = Input.mousePosition;
        return result;
    }

    protected override bool Check()
    {
        if (ChechUI == true)
        {
            Vector2 screanPos = GetTouchPoint();

            PointerEventData = new PointerEventData(EventSystem);
            PointerEventData.position = screanPos;

            List<RaycastResult> results = new List<RaycastResult>();

            UICanvas.Raycast(PointerEventData, results);

            bool count = results.Count == 0;
            



            foreach (RaycastResult r in results)
            {
                if (r.gameObject.layer == LayerMask.NameToLayer("UI"))
                {
                    return false;
                }
            }
        }


        switch (PressType)
        {
            case pressType.GetUp:                
                return Input.GetKeyUp(Key);
            case pressType.GetDown:                
                return Input.GetKeyDown(Key);
            case pressType.GetKey:                
                return Input.GetKey(Key);
            default: return false;
        }
    }


}
