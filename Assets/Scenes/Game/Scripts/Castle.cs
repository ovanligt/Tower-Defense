using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Castle : MonoBehaviour
{
    public int MaxHealth = 100;
    public int CurrentHealth;
    public GameObject i;
    //public HealthBar healthBar;

    private void Start()
    {
        CurrentHealth = MaxHealth;
       // healthBar.SetHealth(MaxHealth);
    }

    public void TakeDamage(int damage)
    {
        Debug.Log("hit");
        CurrentHealth -= damage;

        //healthBar.SetHealth(CurrentHealth);

        if (CurrentHealth <= 0)
        {
            DemolutionofCastle();
        }
    }
    private void DemolutionofCastle()
    {
        Destroy(i);
    }
}
