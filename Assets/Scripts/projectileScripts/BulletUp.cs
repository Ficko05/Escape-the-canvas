﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletUp : MonoBehaviour {

    public float bulletSpeed;
    public  float bulletDamage;

    //gives bulle velosety 
    void FixedUpdate()
    {
        this.transform.Translate(Vector2.up * bulletSpeed * Time.deltaTime);

    }

    //destroyes bullet on collision with wall
    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "wall")
        {
            Destroy(gameObject);
        }
    }

}
