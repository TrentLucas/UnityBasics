using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player2 : MonoBehaviour
{

    private float speed = 7f;
    private Rigidbody2D rb2d;
    public Transform firePoint;
    public GameObject bulletPrefab;
    private float bulletSpeed = 10f;
    private float cooldown = 0.5f;
    private float nextFire = 0f;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        UpdateMotion();
        ProcessBulletSpwan();
    }

    private void UpdateMotion()
    {
        Vector3 pos = transform.position;

        if (Input.GetKey("w"))
        {
            pos.y += speed * Time.deltaTime;
        }

        if (Input.GetKey("s"))
        {
            pos.y -= speed * Time.deltaTime;
        }

        if (Input.GetKey("d"))
        {
            pos.x += 2 * speed * Time.deltaTime;
        }

        if (Input.GetKey("a"))
        {
            pos.x -= 2 * speed * Time.deltaTime;
        }

        transform.position = pos;
    }

    private void ProcessBulletSpwan()
    {
        if ((Input.GetKey(KeyCode.Space) || Input.GetKey(KeyCode.Mouse0)) && Time.time > nextFire)
        {
            GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
            Rigidbody2D re = bullet.GetComponent<Rigidbody2D>();
            int a = Random.Range(1, 5);
            if (a == 1)
            {
                re.velocity = firePoint.up * bulletSpeed;
            }
            if (a == 2)
            {
                re.velocity = -firePoint.up * bulletSpeed;
            }
            if (a == 3)
            {
                re.velocity = -firePoint.right * bulletSpeed;
            }
            if (a == 4)
            {
                re.velocity = firePoint.right * bulletSpeed;
            }
            nextFire = Time.time + cooldown;
        }
    }
}