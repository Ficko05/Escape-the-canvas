using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedBoost : MonoBehaviour {

    
    PlayerController _PlayerController;


    void Start()
    {
        _PlayerController = PlayerController.instance;
        print(PlayerController.instance.Speed);

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Player")) {

            float _PlayerController = PlayerController.instance.Speed += 2f;
            print(PlayerController.instance.Speed);



            Destroy(gameObject);
        }
    }



}
