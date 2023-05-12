using UnityEngine;
using System.Collections;

public class TURRET : MonoBehaviour
{
    public float bulletSpeed = 10.0f;
    public float bulletRate = 0.1f;
    public GameObject bullet;
    public AudioSource shootSound;

    private float lastShot = 0.0f;


    void Fire()
    {
        shootSound.Play();
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, 100))
        {

        GameObject bCopy = Instantiate(bullet, transform.position, transform.rotation);
            Vector3 point = hit.point;
            point.y = transform.position.y;
            bCopy.transform.LookAt(point);
        Rigidbody bCopyRigidBody = bCopy.AddComponent<Rigidbody>();
        bCopyRigidBody.velocity = bCopy.transform.forward * bulletSpeed;
        bCopyRigidBody.useGravity = false;
        Destroy(bCopy, 5);
        lastShot = Time.time;
        }
    }

    void Update()
    {
        if (Input.GetButton("Fire1") && Time.time > bulletRate + lastShot)
            Fire();
    }
}