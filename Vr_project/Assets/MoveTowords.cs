using UnityEngine;

public class Gunshoot : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform firePoint;
    public float bulletSpeed = 20f;

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // Left Mouse Button
        {
            Shoot();
        }
    }

    void Shoot()
    {
        // Create the bullet
        GameObject bullet = Instantiate(bulletPrefab,firePoint.position, firePoint.rotation);

        // Give it speed
        Rigidbody rb = bullet.GetComponent<Rigidbody>();

        rb.linearVelocity = firePoint.forward * bulletSpeed;
    }
}