using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingScript : MonoBehaviour {

    public float fireRate; //1
    public float damage;

    public float timeUntilFire; //1
    

    public Transform firePointUP;
    public Transform firePointDown;
    public Transform firePointLeft;
    public Transform firePointRight;

    public GameObject bulletUp;
    public GameObject bulletDown;
    public GameObject bulletLeft;
    public GameObject bulletRight;


    void Update () {
        if (Input.GetKeyDown(KeyCode.UpArrow) && Time.time > timeUntilFire)
        {
            timeUntilFire = Time.time + 1 / fireRate;
            shootUp();
        }
        if (Input.GetKeyDown(KeyCode.DownArrow) && Time.time > timeUntilFire)
        {
            timeUntilFire = Time.time + 1 / fireRate;
            shootDown();
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow) && Time.time > timeUntilFire)
        {
            timeUntilFire = Time.time + 1 / fireRate;
            shootLeft();
        }
        if (Input.GetKeyDown(KeyCode.RightArrow) && Time.time > timeUntilFire)
        {
            timeUntilFire = Time.time + 1 / fireRate;
            shootRight();
        }
    }

    void shootUp()
    {
        Instantiate(bulletUp, firePointUP.position, firePointUP.rotation);
    }
    void shootDown()
    {
        Instantiate(bulletDown, firePointDown.position, firePointDown.rotation);
    }
    void shootLeft()
    {
        Instantiate(bulletLeft, firePointLeft.position, firePointLeft.rotation);
    }
    void shootRight()
    {
        Instantiate(bulletRight, firePointRight.position, firePointRight.rotation);
    }

}
