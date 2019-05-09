using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float Speed;

    private Rigidbody2D rb;
    private Vector2 moveVelocity;

    //singelton af playerController
    public static PlayerController instance;

    //singelton
    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        rb = GetComponent <Rigidbody2D>();
    }

    void Update()
    {
        //gets input form arrow keys
        Vector2 moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        //nomelize makes walking digonal same speed as if walking left and right
        moveVelocity = moveInput.normalized * Speed;
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + moveVelocity * Time.fixedDeltaTime);
    }

}
