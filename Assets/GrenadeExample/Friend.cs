using UnityEngine;
using System.Collections;
using System;

public class Friend : MonoBehaviour, ICouldTakeDamage {
	public void TakeDamage(float damage)
	{
		print("Friend took damage: " + damage);
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
