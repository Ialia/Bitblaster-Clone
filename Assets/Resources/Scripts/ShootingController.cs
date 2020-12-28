using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShootingController : MonoBehaviour
{
    public float shootingSpeed, bulletSpeed;
    public int amountAmmo;

    public GameObject playerBulletPrefab, bullets;

    public Transform spawnPoint;

    public Text ammoText;

    float nextShot = 0;


    private void Start()
    {
        this.ammoText.text = "AMMO "+this.amountAmmo;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && Time.time > this.nextShot && this.amountAmmo > 0)
        {
           this.Shoot();
        }
       

    }

    void Shoot()
    {
        this.nextShot = Time.time + this.shootingSpeed;

        GameObject newBullet = GameObject.Instantiate(this.playerBulletPrefab);
        newBullet.transform.position = this.spawnPoint.position;
        newBullet.transform.parent = this.bullets.transform;

        Rigidbody2D newBulletRigidbody = newBullet.GetComponent<Rigidbody2D>();
        newBulletRigidbody.AddForce(this.transform.up * this.bulletSpeed);

        this.amountAmmo--;

        this.ammoText.text = "AMMO " + this.amountAmmo.ToString();

    }

}
