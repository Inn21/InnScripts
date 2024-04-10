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
        // !!!remove array
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
    public abstract class ActivatorBase : MonoBehaviour
    {     
        protected virtual bool Check()
        {
            return false;
        }     

        public virtual void Activate()
        {   
            
        }
    }

    public abstract class RepetebleActivatorBase : ActivatorBase
    {
        private void Start()
        {
            lastActivateTime = -activateDelay;
        }

        [field: SerializeField]
        protected updateType UpdateType = updateType.FixedUpdate;
        protected enum updateType
        {
            Update,
            FixedUpdate
        }


        [SerializeField]
        protected float activateDelay;

        protected float lastActivateTime = 0;
        [Tooltip("On  - Активатор не працює під час фейлу" +
               "\nOff - Активатор працює завжди" +
               "\n" +
               "\nOn - The activator does not work on fail" +
               "\nOff - The activator always works")]
        [SerializeField] bool ActiveOnlyDuringTheGame = false;

        bool WaitToNextActivation()
        {
            return Time.time >= lastActivateTime + activateDelay;
        }
        private void FixedUpdate()
        {
            if (UpdateType == updateType.FixedUpdate &&
                WaitToNextActivation() &&
                Check())
            {
                if (!ActiveOnlyDuringTheGame || (Game.playing))
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
                if (!ActiveOnlyDuringTheGame || (Game.playing))
                {
                    Activate();
                    lastActivateTime = Time.time;
                }
            }
        }
    }

    public class RepetebleOutInteractActivator : RepetebleActivatorBase
    {
        [SerializeField]
        protected Interact Interact;
        public override void Activate()
        {
            Interact.Activate();
        }
       
    }
    public class RepetebleActivator : RepetebleActivatorBase
    {
        [SerializeField]
        protected includedInteract Interact;
        public override void Activate()
        {            
            Interact.Activate();
        }
       
    }

    public class NoRepActivator : ActivatorBase
    {
        [SerializeField]
        protected includedInteract interact;
        public override void Activate()
        {
            interact.Activate();
        }
    }

    public interface ICheckUITap
    {
        Vector3 screanPos  { get; set; }
        GraphicRaycaster UICanvas { get; set; }
        PointerEventData PointerEventData { get; set; }
        EventSystem EventSystem { get; set; }
    }
}