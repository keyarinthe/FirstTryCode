using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour
{
    [SerializeField]
    public int healthAmount;
    public int damageAmount;
    public int attackSpeed;
    public int attackDelay;
    public int shieldAmount;

    public bool ally;
    public GameObject projectile;

    // Start is called before the first frame update
    void Start()
    {
        // Set colors of units
        if (ally == false)
        {
            // Get the Renderer component from the  cube
            var cubeRenderer = GetComponent<Renderer>();

            // Call SetColor using the shader property name "_Color" and setting the color to red
            cubeRenderer.material.SetColor("_Color", Color.red);
        }
        else
        {
            // Get the Renderer component from the  cube
            var cubeRenderer = GetComponent<Renderer>();

            // Call SetColor using the shader property name "_Color" and setting the color to red
            cubeRenderer.material.SetColor("_Color", Color.blue);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        if (healthAmount <= 0)
        {
            Destroy(gameObject);
        }
    }

    public void GetDamage(int damage)
    {
        if (shieldAmount != 0 && shieldAmount < damage)
        {
            healthAmount -= damage - shieldAmount;
        }
        else if (shieldAmount >= damage)
        {
            healthAmount -= 10;
        }
        else
        {
            healthAmount -= damage;
        }
        
    }

   
}
