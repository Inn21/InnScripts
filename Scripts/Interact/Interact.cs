using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace InnScripts.Actions
{
    [AddComponentMenu("InnScrips/Actions/Activators/-=Interact=-")]
    public class Interact : MonoBehaviour
    {
        [SerializeField]
        bool ActivateAtStart;
        [field: SerializeField]
        UnityEvent[] activate;


        private void Start()
        {
            if (ActivateAtStart)
            {
                Activate();
            }
        }

        public void Activate()
        {
            foreach (var action in activate)
                action?.Invoke();
        }
    }

    //interface IActivator
    //{
    //    bool Check();
    //    enum updateType
    //    {
    //        Update,
    //        FixedUpdate
    //    }
    //    updateType UpdateType { get; set; }

    //}   

    abstract public class Activator : MonoBehaviour
    {
        [SerializeField]
        protected Interact Interact;

        [field: SerializeField]
        protected updateType UpdateType = updateType.FixedUpdate;
        protected enum updateType
        {
            Update,
            FixedUpdate
        }


        [SerializeField]
        protected float activateDelay;

        private float lastActivateTime = 0;

        [SerializeField] bool StopAtFail;




        private void Start()
        {
            lastActivateTime = -activateDelay;
        }

        protected virtual bool Check() 
        {
            return false;
        }

        bool WaitToNextActivation()
        {
           return Time.time  >= lastActivateTime + activateDelay; 
        }

        protected virtual void Activate() 
        {
            Interact.Activate();           
        }
        

        private void FixedUpdate()
        {
            if (UpdateType == updateType.FixedUpdate &&
                WaitToNextActivation() && 
                Check())
            {
                if (!StopAtFail || !FailScript.failed)
                {
                    Activate();
                    lastActivateTime = Time.time;
                }
            }
        }
        private void Update()
        {
            if (UpdateType == updateType.Update &&
                WaitToNextActivation() &&
                Check())
            {
                if (!StopAtFail || !FailScript.failed)
                {
                    Activate();
                    lastActivateTime = Time.time;
                }
            }
        }

    }

    public interface ICheckUITap
    {
        Vector3 screanPos  { get; set; }
        GraphicRaycaster UICanvas { get; set; }
        PointerEventData m_PointerEventData { get; set; }
        EventSystem m_EventSystem { get; set; }
    }
}