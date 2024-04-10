
using UnityEngine;

namespace InnScripts.Damage {
    public abstract class Attack: MonoBehaviour
    {
        [SerializeField]
        float atackDamage;

        public void Atack(Health health)
        {
            PreAtack();
            float damage = health is IDamageMultipleyer ? 
                atackDamage : 
                atackDamage * health.GetComponent<IDamageMultipleyer>().Multipleyer;            
            health.Damage(damage);
            AfterAtack();
        }

        protected virtual void PreAtack()
        {

        }
        protected virtual void AfterAtack()
        {

        }

    }

    
}
