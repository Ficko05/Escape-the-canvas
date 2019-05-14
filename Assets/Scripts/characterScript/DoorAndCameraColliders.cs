using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorAndCameraColliders : MonoBehaviour {
    public float movement = 5;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "T_Door")
        {

        }
        if (collision.gameObject.name == "B_Door")
        {

        }
        if (collision.gameObject.name == "R_Door")
        {

        }
        if (collision.gameObject.name == "L_Door")
        {

        }
    }