using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

namespace InnScripts.Damage
{ 
    public abstract class Health : MonoBehaviour 
    {
        [SerializeField]
        protected float MaxHealth;

        protected float health;

        protected bool alive = true;

       
        virtual protected void Start()
        {
            health = MaxHealth;
        }

        public void Damage(float value)
        {
            if (alive)
            {
                health = math.clamp(health - value, 0, MaxHealth);
                AfterDamage(value);
                if (health <= 0) Kill();
            }
        } 

        protected virtual void AfterDamage(float value)
        {

        }
        public void Heal(int value)
        {
            if (alive)
            {
                health = math.clamp(health + value, 0, MaxHealth);
                AfterHeal(value);
            }
        }

        protected virtual void AfterHeal(float value)
        {

        }
        public virtual void Kill()
        {
            alive = false;
        }
    }

    public interface IDamageMultipleyer
    {        
        float Multipleyer { get; set; }
    }
}
