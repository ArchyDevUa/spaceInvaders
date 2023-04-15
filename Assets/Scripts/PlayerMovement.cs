using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float shipSpeed = 1.0f;

    private void Start()
    {
        Cursor.visible = false;
    }

    // private Rigidbody2D rb;
    void Update()
    {
        float VerticalInput = Input.GetAxis("Vertical");
        float HorizontalInput = Input.GetAxis("Horizontal");
        transform.position = transform.position + new Vector3(HorizontalInput, VerticalInput, 0) * Time.deltaTime * shipSpeed;
    }

    // private void Start()
    // {
    //     rb = GetComponent<Rigidbody2D>();
    // }
    //
    // private void FixedUpdate()
    // {
    //     float moveHorizontal = Input.GetAxis("Horizontal");
    //     float moveVertical = Input.GetAxis("Vertical");
    //
    //     Vector2 movement = new Vector2(moveHorizontal, moveVertical);
    //     rb.velocity = movement * shipSpeed;
    // }
}
