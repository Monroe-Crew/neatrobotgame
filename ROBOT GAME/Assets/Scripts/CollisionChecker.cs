using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionChecker : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Enemy")) other.gameObject.GetComponent<AlienAttributes>().AddHealth(-10);

        if (other.CompareTag("Quartz")) other.gameObject.GetComponent<QuartzBehavior>().AddHealth(-10);

        if (!other.CompareTag("player")) Destroy(this.gameObject);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
