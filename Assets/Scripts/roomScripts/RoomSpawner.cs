using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomSpawner : MonoBehaviour {


    private RoomTemplate roomTemplate;
    public int openingDirection;
    private int randNumber = 0;
    private bool Spawned = false;
    public float waitTime = 3f;
    //1 --> Needs Bottom Door
    //2 --> Needs Top Door
    //3 --> Needs Left Door
    //4 --> Needs Right Door


    private void Start()
    {
        Destroy(gameObject, waitTime);
        roomTemplate = GameObject.FindGameObjectWithTag("Rooms").GetComponent<RoomTemplate>();
        Invoke("Spawn",0.1f);
    }


    void Spawn() {
        if (Spawned == false)
        {
            if (openingDirection == 1)
            {
                //Spawn Room with Bottom Door
                randNumber = Random.Range(0, roomTemplate.BottomDoor.Length);
                Instantiate(roomTemplate.BottomDoor[randNumber], transform.position, roomTemplate.BottomDoor[randNumber].transform.rotation);
            }
            else if (openingDirection == 2)
            {
                //Spawn Room with Top Door
                randNumber = Random.Range(0, roomTemplate.TopDoor.Length);
                Instantiate(roomTemplate.TopDoor[randNumber], transform.position, roomTemplate.TopDoor[randNumber].transform.rotation);
            }
            else if(openingDirection == 3)
            {
                //Spawn Room with Left Door
                randNumber = Random.Range(0, roomTemplate.LeftDoor.Length);
                Instantiate(roomTemplate.LeftDoor[randNumber], transform.position, roomTemplate.LeftDoor[randNumber].transform.rotation);
            }
            else if(openingDirection == 4)
            {
                //Spawn Room with Right Door
                randNumber = Random.Range(0, roomTemplate.RightDoor.Length);
                Instantiate(roomTemplate.RightDoor[randNumber], transform.position, roomTemplate.RightDoor[randNumber].transform.rotation);
            }
            print("Spawn");
            
        }
        Spawned = true;
    }

    void OnTriggerEnter2D(Collider2D other){
        if (other.CompareTag("SpawnPoint")){
            if (other.GetComponent<RoomSpawner>().Spawned == false && Spawned == false){
                Instantiate(roomTemplate.ClosedRoom, transform.position, Quaternion.identity);
                print("Destroyed");
                Destroy(gameObject);
            }
            Spawned = true;
        }
    }
}
