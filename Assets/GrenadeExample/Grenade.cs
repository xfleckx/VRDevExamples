using UnityEngine;
using System.Collections;
using System;
using System.Linq;

public class Grenade : MonoBehaviour
{
    public GameObject explosionPrefab;

    public float InitialDamage = 5;

    public float effectiveDamageDistance = 2;

    private GameObject explosion;

    void OnCollisionEnter(Collision col)
    {
        explosion = Instantiate(explosionPrefab);

        var grenadeMesh = gameObject.GetComponent<MeshRenderer>();

        grenadeMesh.enabled = false;

        StartCoroutine(DeleteGrenade());

        distributeDamage();

    }

    IEnumerator DeleteGrenade()
    {
        yield return new WaitForSeconds(1.2f);

        Destroy(explosion);

        Destroy(gameObject);
    }

    private void distributeDamage()
    {
        Collider[] hits = Physics.OverlapSphere(transform.position, effectiveDamageDistance);
        
        foreach (var item in hits)
        {
            var damageTaker = item.GetComponent<ICouldTakeDamage>();

            if (damageTaker != null) { 
                float distance = Vector3.Distance(item.transform.position, transform.position);
                float percentageOfDamage = effectiveDamageDistance / 100 * distance;
                damageTaker.TakeDamage(InitialDamage * percentageOfDamage);
            }
        }

    }
}
