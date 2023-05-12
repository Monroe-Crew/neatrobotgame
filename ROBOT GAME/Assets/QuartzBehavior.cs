using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuartzBehavior : MonoBehaviour
{
    public float startingHealth = 10.0f;
    private float health;
    public GameObject gear;

    void Start()
    {
        health = startingHealth;
    }

    // Update is called once per frame
    void Update()
    {
        if (health <= 0.0f)
        {
            dropItem(transform.position);
            Destroy(this.gameObject);
        }
    }

    public void AddHealth(float num)
    {
        health += num;
    }

    public void dropItem(Vector3 spawnPosition)
    {
        Instantiate(gear, spawnPosition, Quaternion.identity);
    }
}
