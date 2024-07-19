using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HGR : MonoBehaviour
{

    [SerializeField] private PlayerMovementAdvanced Player;

    public bool isOnCooldown = false;
    public bool isOnCooldownSpeed = false;
    public bool isOnCooldownHealth = false;



    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            if (!isOnCooldown)
            {
                StartCoroutine(HGRDamage());
            }
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            if (!isOnCooldownSpeed)
            {
                StartCoroutine(HGRVelocity());
            }
        }

        if (Input.GetKeyDown(KeyCode.G))
        {
            if (!isOnCooldownHealth)
            {
                StartCoroutine(HGRHealth());
            }
        }

    }
    public IEnumerator HGRDamage()
    {
        isOnCooldown = true;

        float valorAleatorio = Random.value * 100f;

        if (valorAleatorio < 25f)
        {
            Player.ModifyDamage(25);
        }
        else if (valorAleatorio < 45f)
        {
            Player.ModifyDamage(20);
        }
        else if (valorAleatorio < 60f)
        {
            Player.ModifyDamage(15);
        }
        else if (valorAleatorio < 85f)
        {
            Player.ModifyDamage(10);
        }
        else if (valorAleatorio < 95f)
        {
            Player.ModifyDamage(15);
        }
        else if (valorAleatorio < 100f)
        {
            Player.ModifyDamage(1);
        }
        else 
        {
            Player.ModifyDamage(0);
            Debug.Log("0 de daño");
        }

        yield return new WaitForSeconds(24f);

        isOnCooldown = false;
    }

    public IEnumerator HGRVelocity()
    {
        isOnCooldownSpeed = true;

        float valorAleatorio = Random.value * 100f;

        if (valorAleatorio < 25f)
        {
            Player.ModifySpeed(10);
        }
        else if (valorAleatorio < 45f)
        {
            Player.ModifySpeed(10);
        }
        else if (valorAleatorio < 60f)
        {
            Player.ModifySpeed(10);
        }
        else if (valorAleatorio < 85f)
        {
            Player.ModifySpeed(10);
        }
        else if (valorAleatorio < 95f)
        {
            Player.ModifySpeed(10);
        }
        else if (valorAleatorio < 100f)
        {
            Player.ModifySpeed(10);
        }
        else
        {
            Player.ModifySpeed(0);
        }

        yield return new WaitForSeconds(25f);

        isOnCooldownSpeed = false;
    }

    public IEnumerator HGRHealth()
    {
        isOnCooldownHealth = true;

        float valorAleatorio = Random.value * 100f;

        if (valorAleatorio < 25f)
        {
            Player.ModifyHealth(50);
            Debug.Log("recuperas 50 de vida");

        }
        else if (valorAleatorio < 45f)
        {
            Player.ModifyHealth(30);
            Debug.Log("recuperas 30 de vida");
        }
        else if (valorAleatorio < 60f)
        {
            Player.ModifyHealth(25);
            Debug.Log("recuperas 25 de vida");
        }
        else if (valorAleatorio < 85f)
        {
            Player.ModifyHealth(20);
            Debug.Log("recuperas 20 de vida");
        }
        else if (valorAleatorio < 95f)
        {
            Player.ModifyHealth(15);
            Debug.Log("recuperas 15 de vida");
        }
        else if (valorAleatorio < 100f)
        {
            Player.ModifyHealth(5);
            Debug.Log("recuperas 5 de vida");
        }
        else
        {
           
            Debug.Log("Moriste");
        }

        yield return new WaitForSeconds(18f);

        isOnCooldownHealth = false;
    }





}
