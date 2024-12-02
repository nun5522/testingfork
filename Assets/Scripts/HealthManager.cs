using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthManager : MonoBehaviour
{
    pubilc int IncreaseHealth(int currentHealth, int increseAmount, int maxHealth)
    {
        int newHealth = currentHealth + increseAmount;
        return ClampHealth(currentHealth, newHealth);
    }

    public int ClampHealth(int currentHealth, int newHealth)
    {
        if (currentHealth > maxHealth)
        {
            return maxHealth;
        }
        else
        {
            return currentHealth;
        }
    }
    
}
