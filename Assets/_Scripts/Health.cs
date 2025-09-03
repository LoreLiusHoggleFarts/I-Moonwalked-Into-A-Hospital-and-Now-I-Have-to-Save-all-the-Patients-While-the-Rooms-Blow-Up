using System;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] public float maxHealth;
    [SerializeField] public float currentHealth;
    public GameObject ggs;

    private void Awake()
    {
        currentHealth = maxHealth;
    }

    private void Death()
    {
        if (currentHealth <= 0)
        {
            Time.timeScale = 0;
            Destroy(gameObject);
            ggs.SetActive(true);
        }
    }

    private void Update()
    {
        Death();
    }
}
