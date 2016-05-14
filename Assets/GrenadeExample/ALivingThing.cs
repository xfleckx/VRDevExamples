using System;
using UnityEngine;

public abstract class ALivingThing : MonoBehaviour {

    Action<ALivingThing> OnDead;

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

    private void Die()
    {
        if(OnDead != null)
            OnDead(this);
    }
}
