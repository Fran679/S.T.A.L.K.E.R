using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    //variables
    public float maxHealth, maxThirst, MaxHunger;
    public float thirstIncreaseRate, hungerIncreaseRate;
    public float health, thirst, hunger;

    public bool dead=false;
    
    
    private void Start()
    {
        health = maxHealth;

    }

    private void Update()
    {
        if ( thirst < maxThirst)
        {
            thirst += thirstIncreaseRate * Time.deltaTime;    
        }
        if (hunger < MaxHunger)
        {
            hunger += hungerIncreaseRate * Time.deltaTime;  
        }

        if (thirst >= maxThirst)
            Die();

        if (hunger >= MaxHunger)
            Die();


    }

    public void Die()
    {
        print("U died cause of thirst or hunger");
        dead = true;
    }
}
