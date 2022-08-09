using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackOrder : MonoBehaviour
{
    private bool ally;
    private int attackSpeed;
    private int attackDelay;
    private GameObject projectile;

    // Start is called before the first frame update
    void Start()
    {
        TryGetComponent(out Unit unitComponent);
        ally = unitComponent.ally;
        attackSpeed = unitComponent.attackSpeed;
        projectile = unitComponent.projectile;
        attackDelay = unitComponent.attackDelay;

        // Attack order for allied units (spawn projectiles in targets)
        if (ally == true)
        {
            if (gameObject.tag == "Zone 1 Melee" || gameObject.tag == "Zone 1 Range")
            {
                InvokeRepeating("AttackForZone1", attackDelay, attackSpeed);
            }

            else if (gameObject.tag == "Zone 2 Melee" || gameObject.tag == "Zone 2 Range")
            {
                InvokeRepeating("AttackForZone2", attackDelay, attackSpeed);
            }

            else if (gameObject.tag == "Zone 3 Melee" || gameObject.tag == "Zone 3 Range")
            {
                InvokeRepeating("AttackForZone3", attackDelay, attackSpeed);
            }

            else if (gameObject.tag == "Zone 4 Melee" || gameObject.tag == "Zone 4 Range")
            {
                InvokeRepeating("AttackForZone4", attackDelay, attackSpeed);
            }

        }

        // Attack order for enemies units (spawn projectiles in targets)
        else
        {
            if (gameObject.tag == "Melee 1 Enemy" || gameObject.tag == "Range 1 Enemy")
            {
                InvokeRepeating("AttackForZone1Enemy", attackDelay, attackSpeed);
            }

            else if (gameObject.tag == "Melee 2 Enemy" || gameObject.tag == "Range 2 Enemy")
            {
                InvokeRepeating("AttackForZone2Enemy", attackDelay, attackSpeed);
            }

            else if (gameObject.tag == "Melee 3 Enemy" || gameObject.tag == "Range 3 Enemy")
            {
                InvokeRepeating("AttackForZone3Enemy", attackDelay, attackSpeed);
            }

            else if (gameObject.tag == "Melee 4 Enemy" || gameObject.tag == "Range 4 Enemy")
            {
                InvokeRepeating("AttackForZone4Enemy", attackDelay, attackSpeed);
            }
        }
    }

    void AttackForZone1 ()
    {
        if (GameObject.FindWithTag("Melee 1 Enemy") != null)
        {
            Instantiate(projectile, GameObject.FindWithTag("Melee 1 Enemy").transform.position, transform.rotation);
        }

        else if (GameObject.FindWithTag("Range 1 Enemy") != null)
        {
            Instantiate(projectile, GameObject.FindWithTag("Range 1 Enemy").transform.position, transform.rotation);
        }

        else if (GameObject.FindWithTag("Melee 2 Enemy") != null)
        {
            Instantiate(projectile, GameObject.FindWithTag("Melee 2 Enemy").transform.position, transform.rotation);
        }

        else if (GameObject.FindWithTag("Range 2 Enemy") != null)
        {
            Instantiate(projectile, GameObject.FindWithTag("Range 2 Enemy").transform.position, transform.rotation);
        }

        else if (GameObject.FindWithTag("Melee 3 Enemy") != null)
        {
            Instantiate(projectile, GameObject.FindWithTag("Melee 3 Enemy").transform.position, transform.rotation);
        }

        else if (GameObject.FindWithTag("Range 3 Enemy") != null)
        {
            Instantiate(projectile, GameObject.FindWithTag("Range 3 Enemy").transform.position, transform.rotation);
        }

        else if (GameObject.FindWithTag("Melee 4 Enemy") != null)
        {
            Instantiate(projectile, GameObject.FindWithTag("Melee 4 Enemy").transform.position, transform.rotation);
        }

        else if (GameObject.FindWithTag("Range 4 Enemy") != null)
        {
            Instantiate(projectile, GameObject.FindWithTag("Range 4 Enemy").transform.position, transform.rotation);
        }
    }

    void AttackForZone2()
    {
        if (GameObject.FindWithTag("Melee 2 Enemy") != null)
        {
            Instantiate(projectile, GameObject.FindWithTag("Melee 2 Enemy").transform.position, transform.rotation);
        }

        else if (GameObject.FindWithTag("Range 2 Enemy") != null)
        {
            Instantiate(projectile, GameObject.FindWithTag("Range 2 Enemy").transform.position, transform.rotation);
        }

        else if (GameObject.FindWithTag("Melee 3 Enemy") != null)
        {
            Instantiate(projectile, GameObject.FindWithTag("Melee 3 Enemy").transform.position, transform.rotation);
        }

        else if (GameObject.FindWithTag("Range 3 Enemy") != null)
        {
            Instantiate(projectile, GameObject.FindWithTag("Range 3 Enemy").transform.position, transform.rotation);
        }

        else if (GameObject.FindWithTag("Melee 4 Enemy") != null)
        {
            Instantiate(projectile, GameObject.FindWithTag("Melee 4 Enemy").transform.position, transform.rotation);
        }

        else if (GameObject.FindWithTag("Range 4 Enemy") != null)
        {
            Instantiate(projectile, GameObject.FindWithTag("Range 4 Enemy").transform.position, transform.rotation);
        }

        else if (GameObject.FindWithTag("Melee 1 Enemy") != null)
        {
            Instantiate(projectile, GameObject.FindWithTag("Melee 1 Enemy").transform.position, transform.rotation);
        }

        else if (GameObject.FindWithTag("Range 1 Enemy") != null)
        {
            Instantiate(projectile, GameObject.FindWithTag("Range 1 Enemy").transform.position, transform.rotation);
        }
    }

    void AttackForZone3()
    {
        if (GameObject.FindWithTag("Melee 3 Enemy") != null)
        {
            Instantiate(projectile, GameObject.FindWithTag("Melee 3 Enemy").transform.position, transform.rotation);
        }

        else if (GameObject.FindWithTag("Range 3 Enemy") != null)
        {
            Instantiate(projectile, GameObject.FindWithTag("Range 3 Enemy").transform.position, transform.rotation);
        }

        else if (GameObject.FindWithTag("Melee 4 Enemy") != null)
        {
            Instantiate(projectile, GameObject.FindWithTag("Melee 4 Enemy").transform.position, transform.rotation);
        }

        else if (GameObject.FindWithTag("Range 4 Enemy") != null)
        {
            Instantiate(projectile, GameObject.FindWithTag("Range 4 Enemy").transform.position, transform.rotation);
        }

        else if (GameObject.FindWithTag("Melee 1 Enemy") != null)
        {
            Instantiate(projectile, GameObject.FindWithTag("Melee 1 Enemy").transform.position, transform.rotation);
        }

        else if (GameObject.FindWithTag("Range 1 Enemy") != null)
        {
            Instantiate(projectile, GameObject.FindWithTag("Range 1 Enemy").transform.position, transform.rotation);
        }

        else if (GameObject.FindWithTag("Melee 2 Enemy") != null)
        {
            Instantiate(projectile, GameObject.FindWithTag("Melee 2 Enemy").transform.position, transform.rotation);
        }

        else if (GameObject.FindWithTag("Range 2 Enemy") != null)
        {
            Instantiate(projectile, GameObject.FindWithTag("Range 2 Enemy").transform.position, transform.rotation);
        }
    }

    void AttackForZone4()
    {
        if (GameObject.FindWithTag("Melee 4 Enemy") != null)
        {
            Instantiate(projectile, GameObject.FindWithTag("Melee 4 Enemy").transform.position, transform.rotation);
        }

        else if (GameObject.FindWithTag("Range 4 Enemy") != null)
        {
            Instantiate(projectile, GameObject.FindWithTag("Range 4 Enemy").transform.position, transform.rotation);
        }

        else if (GameObject.FindWithTag("Melee 1 Enemy") != null)
        {
            Instantiate(projectile, GameObject.FindWithTag("Melee 1 Enemy").transform.position, transform.rotation);
        }

        else if (GameObject.FindWithTag("Range 1 Enemy") != null)
        {
            Instantiate(projectile, GameObject.FindWithTag("Range 1 Enemy").transform.position, transform.rotation);
        }

        else if (GameObject.FindWithTag("Melee 2 Enemy") != null)
        {
            Instantiate(projectile, GameObject.FindWithTag("Melee 2 Enemy").transform.position, transform.rotation);
        }

        else if (GameObject.FindWithTag("Range 2 Enemy") != null)
        {
            Instantiate(projectile, GameObject.FindWithTag("Range 2 Enemy").transform.position, transform.rotation);
        }

        else if (GameObject.FindWithTag("Melee 3 Enemy") != null)
        {
            Instantiate(projectile, GameObject.FindWithTag("Melee 3 Enemy").transform.position, transform.rotation);
        }

        else if (GameObject.FindWithTag("Range 3 Enemy") != null)
        {
            Instantiate(projectile, GameObject.FindWithTag("Range 3 Enemy").transform.position, transform.rotation);
        }
    }

    void AttackForZone1Enemy()
    {
        if (GameObject.FindWithTag("Zone 1 Melee") != null)
        {
            Instantiate(projectile, GameObject.FindWithTag("Zone 1 Melee").transform.position, transform.rotation);
        }

        else if (GameObject.FindWithTag("Zone 1 Range") != null)
        {
            Instantiate(projectile, GameObject.FindWithTag("Zone 1 Range").transform.position, transform.rotation);
        }

        else if (GameObject.FindWithTag("Zone 2 Melee") != null)
        {
            Instantiate(projectile, GameObject.FindWithTag("Zone 2 Melee").transform.position, transform.rotation);
        }

        else if (GameObject.FindWithTag("Zone 2 Range") != null)
        {
            Instantiate(projectile, GameObject.FindWithTag("Zone 2 Range").transform.position, transform.rotation);
        }

        else if (GameObject.FindWithTag("Zone 3 Melee") != null)
        {
            Instantiate(projectile, GameObject.FindWithTag("Zone 3 Melee").transform.position, transform.rotation);
        }

        else if (GameObject.FindWithTag("Zone 3 Range") != null)
        {
            Instantiate(projectile, GameObject.FindWithTag("Zone 3 Range").transform.position, transform.rotation);
        }

        else if (GameObject.FindWithTag("Zone 4 Melee") != null)
        {
            Instantiate(projectile, GameObject.FindWithTag("Zone 4 Melee").transform.position, transform.rotation);
        }

        else if (GameObject.FindWithTag("Zone 4 Range") != null)
        {
            Instantiate(projectile, GameObject.FindWithTag("Zone 4 Range").transform.position, transform.rotation);
        }
    }

    void AttackForZone2Enemy()
    {
        if (GameObject.FindWithTag("Zone 2 Melee") != null)
        {
            Instantiate(projectile, GameObject.FindWithTag("Zone 2 Melee").transform.position, transform.rotation);
        }

        else if (GameObject.FindWithTag("Zone 2 Range") != null)
        {
            Instantiate(projectile, GameObject.FindWithTag("Zone 2 Range").transform.position, transform.rotation);
        }

        else if (GameObject.FindWithTag("Zone 3 Melee") != null)
        {
            Instantiate(projectile, GameObject.FindWithTag("Zone 3 Melee").transform.position, transform.rotation);
        }

        else if (GameObject.FindWithTag("Zone 3 Range") != null)
        {
            Instantiate(projectile, GameObject.FindWithTag("Zone 3 Range").transform.position, transform.rotation);
        }

        else if (GameObject.FindWithTag("Zone 4 Melee") != null)
        {
            Instantiate(projectile, GameObject.FindWithTag("Zone 4 Melee").transform.position, transform.rotation);
        }

        else if (GameObject.FindWithTag("Zone 4 Range") != null)
        {
            Instantiate(projectile, GameObject.FindWithTag("Zone 4 Range").transform.position, transform.rotation);
        }

        else if (GameObject.FindWithTag("Zone 1 Melee") != null)
        {
            Instantiate(projectile, GameObject.FindWithTag("Zone 1 Melee").transform.position, transform.rotation);
        }

        else if (GameObject.FindWithTag("Zone 1 Range") != null)
        {
            Instantiate(projectile, GameObject.FindWithTag("Zone 1 Range").transform.position, transform.rotation);
        }
    }

    void AttackForZone3Enemy()
    {
        if (GameObject.FindWithTag("Zone 3 Melee") != null)
        {
            Instantiate(projectile, GameObject.FindWithTag("Zone 3 Melee").transform.position, transform.rotation);
        }

        else if (GameObject.FindWithTag("Zone 3 Range") != null)
        {
            Instantiate(projectile, GameObject.FindWithTag("Zone 3 Range").transform.position, transform.rotation);
        }

        else if (GameObject.FindWithTag("Zone 4 Melee") != null)
        {
            Instantiate(projectile, GameObject.FindWithTag("Zone 4 Melee").transform.position, transform.rotation);
        }

        else if (GameObject.FindWithTag("Zone 4 Range") != null)
        {
            Instantiate(projectile, GameObject.FindWithTag("Zone 4 Range").transform.position, transform.rotation);
        }

        else if (GameObject.FindWithTag("Zone 1 Melee") != null)
        {
            Instantiate(projectile, GameObject.FindWithTag("Zone 1 Melee").transform.position, transform.rotation);
        }

        else if (GameObject.FindWithTag("Zone 1 Range") != null)
        {
            Instantiate(projectile, GameObject.FindWithTag("Zone 1 Range").transform.position, transform.rotation);
        }

        else if (GameObject.FindWithTag("Zone 2 Melee") != null)
        {
            Instantiate(projectile, GameObject.FindWithTag("Zone 2 Melee").transform.position, transform.rotation);
        }

        else if (GameObject.FindWithTag("Zone 2 Range") != null)
        {
            Instantiate(projectile, GameObject.FindWithTag("Zone 2 Range").transform.position, transform.rotation);
        }
    }

    void AttackForZone4Enemy()
    {
        if (GameObject.FindWithTag("Zone 4 Melee") != null)
        {
            Instantiate(projectile, GameObject.FindWithTag("Zone 4 Melee").transform.position, transform.rotation);
        }

        else if (GameObject.FindWithTag("Zone 4 Range") != null)
        {
            Instantiate(projectile, GameObject.FindWithTag("Zone 4 Range").transform.position, transform.rotation);
        }

        else if (GameObject.FindWithTag("Zone 1 Melee") != null)
        {
            Instantiate(projectile, GameObject.FindWithTag("Zone 1 Melee").transform.position, transform.rotation);
        }

        else if (GameObject.FindWithTag("Zone 1 Range") != null)
        {
            Instantiate(projectile, GameObject.FindWithTag("Zone 1 Range").transform.position, transform.rotation);
        }

        else if (GameObject.FindWithTag("Zone 2 Melee") != null)
        {
            Instantiate(projectile, GameObject.FindWithTag("Zone 2 Melee").transform.position, transform.rotation);
        }

        else if (GameObject.FindWithTag("Zone 2 Range") != null)
        {
            Instantiate(projectile, GameObject.FindWithTag("Zone 2 Range").transform.position, transform.rotation);
        }

        else if (GameObject.FindWithTag("Zone 3 Melee") != null)
        {
            Instantiate(projectile, GameObject.FindWithTag("Zone 3 Melee").transform.position, transform.rotation);
        }

        else if (GameObject.FindWithTag("Zone 3 Range") != null)
        {
            Instantiate(projectile, GameObject.FindWithTag("Zone 3 Range").transform.position, transform.rotation);
        }
    }
}
