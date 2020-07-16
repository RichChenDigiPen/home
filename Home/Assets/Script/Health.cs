using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int curHealth = 0;
    public int maxHealth = 10000;

    //for actions
    public int currentChange = 0;

    public HealthBar healthBar;

    // Start is called before the first frame update
    void Start()
    {
        curHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        change(currentChange);
        currentChange = 0;
        DamagePlayer(10);
        if(curHealth <= 0)
        {
            Debug.Log("LOSE CONDITION");
            //you lose
        }
    }

    //set change in health
    public void setChange(int setTo) 
    {
        currentChange = setTo;
    }

    //health always dropping
    public void DamagePlayer( int damage )
    {
        curHealth -= damage;

        healthBar.SetHealth( curHealth );
    }

    //modify their health
    public void change( int value )
    {
        curHealth += value;

        healthBar.SetHealth( curHealth );
    }
}