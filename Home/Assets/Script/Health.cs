using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int curHealth = 0;
    public int maxHealth = 10000;

    public HealthBar healthBar;

    // Start is called before the first frame update
    void Start()
    {
        curHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        DamagePlayer(10);
        if(curHealth <= 0)
        {
            Debug.Log("LOSE CONDITION");
            //you lose
        }
    }

    public void DamagePlayer( int damage )
    {
        curHealth -= damage;

        healthBar.SetHealth( curHealth );
    }
}