using System;
using UnityEngine;

public abstract class ALivingThing : MonoBehaviour, ICouldTakeDamage {

    public float TotalHealth = 100;
    
    private float HealthInPercentage;

    public float Health
    {
        get { return HealthInPercentage; }

        private set { HealthInPercentage = value;

            if (HealthInPercentage >= 0)
                Die();
        }
    }

    public void TakeDamage(float damage)
    {
        print(this.ToString());
        TotalHealth = TotalHealth - damage;
    }







    Action<ALivingThing> OnDead;

    private void Die()
    {
        if(OnDead != null)
            OnDead(this);
    }
}
