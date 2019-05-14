using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomTemplate : MonoBehaviour {

    public GameObject[] TopDoor;
    public GameObject[] BottomDoor;
    public GameObject[] RightDoor;
    public GameObject[] LeftDoor;
    public GameObject ClosedRoom;
    public List<GameObject> Rooms;
    public float waitTime = 1.5f;
    private bool spawnedBoss;
    public GameObject Boss;

    void Update()
    {
    if (waitTime <= 0 && spawnedBoss == false)
        {
            for (int i = 0; i < Rooms.Count; i++)
            {
                if (i==Rooms.Count - 1)
                { 
                    Instantiate(Boss, Rooms[i].transform.position, Quaternion.identity);
                    spawnedBoss = true;
                }
            }
        }
        else
        {
            waitTime -= Time.deltaTime;
        }    
    }

}   
