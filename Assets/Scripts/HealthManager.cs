using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Project.GameManager;
{
    public class HealthManager : MonoBehaviour
    {
        pubilc int IncreaseHealth(int currentHealth, int increseAmount, int maxHealth)
        {
        int newHealth = currentHealth + increseAmount;
        return Mathf.Clamp(newHealth, 0, maxHealth);
        }
    }
}
