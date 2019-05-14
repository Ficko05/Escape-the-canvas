using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float Speed = 8;

    private Rigidbody2D rb;
    private Vector2 moveVelocity;
    public Animator animator;

    //singelton af playerController
    public static PlayerController instance;

    //singelton
    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        //gets input form arrow keys
        Vector2 moveInput = new Vector2( Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        //nomelize makes walking digonal same speed as if walking left and right
        moveVelocity = moveInput.normalized * Speed;

        animator.SetFloat("UP", moveInput.y);
        animator.SetFloat("Down", -moveInput.y);

        animator.SetFloat("Right", moveInput.x);
        animator.SetFloat("Left", -moveInput.x);
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + moveVelocity * Time.fixedDeltaTime);
    }

}