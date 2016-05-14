using UnityEngine;
using System.Collections;
using System;

public class Building : MonoBehaviour, ICouldTakeDamage {

    public void TakeDamage(float damage)
    {
        gameObject.SetActive(false);
    }
}
