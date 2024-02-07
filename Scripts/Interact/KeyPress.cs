using System.Collections.Generic;
using UnityEngine;
using InnScripts.Actions;
using UnityEngine.EventSystems;
using UnityEngine.UI;

[AddComponentMenu("InnScrips/Actions/Activators/KeyPress")]
[RequireComponent(typeof(Interact))]
public class KeyPress : Activator, ICheckUITap
{
    enum pressType
    {
        GetUp,
        GetDown,
        GetKey
    }
    [Space(10)]
    [SerializeField]
    KeyCode Key = KeyCode.Space;

    [SerializeField]
    pressType PressType = pressType.GetKey;


    [Header("UICheck")]
    [SerializeField]
    bool ChechUI;
    [SerializeField]
    Tag UITag;

    public Vector3 screanPos { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
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
