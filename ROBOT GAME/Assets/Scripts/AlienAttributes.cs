using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienAttributes : MonoBehaviour
{
    public float startingHealth = 100.0f;
    private float health;

    void Start()
    {
        health = startingHealth;
    }

    // Update is called once per frame
    void Update()
    {
        if (health <= 0.0f)
        {
            Destroy(this.gameObject);
        }
    }

    public void AddHealth(float num)
    {
        health += num;
    }
}
