using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour {
    private void Start()
    {
        Invoke("kill",2f);
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        print("bum");
        Destroy(other.gameObject);
    }
    void kill()
    {
        Destroy(gameObject);
    }
}
