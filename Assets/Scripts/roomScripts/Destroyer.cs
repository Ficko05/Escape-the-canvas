using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour {
    private void Start()
    {
        Invoke("kill",0.5f);
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        print("Destroyed Room");
        Destroy(other.gameObject);
    }
    void kill()
    {
        Destroy(gameObject);
    }
}
