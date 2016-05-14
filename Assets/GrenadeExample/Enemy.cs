using UnityEngine;
using System.Collections;
using System;

public class Enemy : MonoBehaviour, ICouldTakeDamage {

	public float TotalHealth = 100;

	private float HealthInPercentage;
	public void TakeDamage(float damage)
	{
		print("Enemy took damage: " + damage);

		TotalHealth = TotalHealth - damage;
		
	}

// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
