
using System;
using UnityEngine;
using Random = UnityEngine.Random;

namespace InnScripts.Actions
{
    [AddComponentMenu("InnScrips/Actions/Spawner/-=Spawner=-")]
    public class Spawner : InnAction
    {
        [SerializeField]
        public GameObject spawnObject;
        [SerializeField]
        public Transform spawnPoint;
        [SerializeField]
        Transform spawnParent;
        public event Action<GameObject> AfterSpawn = delegate { };


        private void Awake()
        {
            if (spawnPoint == null) spawnPoint = transform;
        }

        public override void Activate()
        {
            if (spawnObject != null)
            {
                GameObject result = Instantiate(spawnObject, spawnPoint.position, spawnObject.transform.rotation, spawnParent);

                AfterSpawn(result);                
            }
        }

    }

    public abstract class InnAction : MonoBehaviour
    {
        virtual public void Activate()
        {
            
        }
    }

}
   
    
