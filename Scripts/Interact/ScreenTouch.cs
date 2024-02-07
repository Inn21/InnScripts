

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using InnScripts.Actions;
using InnScripts;
using Unity.VisualScripting;
using UnityEngine.EventSystems;
using UnityEngine.UI;

[AddComponentMenu("InnScrips/Actions/Activators/ScreenTouch")]
[RequireComponent(typeof(Interact))]
public class ScreenTouch : Activator, ICheckUITap
{
    [Space(10)]
    [SerializeField]
    bool AnyTouch;
    [SerializeField]
    TouchPhase PressType = TouchPhase.Began;



    [Header("UICheck")]
    [SerializeField]
    bool ChechUI;
    [SerializeField]
    Tag UITag;

    public Vector3 screanPos { get; set; }
    [field: SerializeField]
    public GraphicRaycaster UICanvas { get; set; }
    [field: SerializeField]
    public PointerEventData m_PointerEventData { get; set; }
    [field: SerializeField]
    public EventSystem m_EventSystem { get; set; }



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

            m_PointerEventData = new PointerEventData(m_EventSystem);
            m_PointerEventData.position = screanPos;
            List<RaycastResult> results = new List<RaycastResult>();

            UICanvas.Raycast(m_PointerEventData, results);

            bool count = results.Count == 0;


            foreach (RaycastResult r in results)
            {
                if (r.gameObject.layer == LayerMask.NameToLayer("UI"))
                {
                    return false;
                }
            }
        }

        if (Input.touchCount > 0)
        {
            if (!AnyTouch)
                return Input.GetTouch(0).phase == PressType;
            else
                return true;
        }
        return false;
    }


}
