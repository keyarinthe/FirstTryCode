using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public int damageAmount;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out Unit unitComponent))
        {
            unitComponent.GetDamage(damageAmount);
            Debug.Log(unitComponent.healthAmount);
            Destroy(gameObject);
        }
    }
}
