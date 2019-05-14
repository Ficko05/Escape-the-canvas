using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddRoom : MonoBehaviour {

    private RoomTemplate roomtemplate;
    void Start()
    {
        roomtemplate = GameObject.FindGameObjectWithTag("Rooms").GetComponent<RoomTemplate>();
        roomtemplate.Rooms.Add(this.gameObject);
    }
}
