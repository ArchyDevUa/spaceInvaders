using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float shipSpeed = 1.0f;
    void Update()
    {
        float VerticalInput = Input.GetAxis("Vertical");
        float HorizontalInput = Input.GetAxis("Horizontal");
        transform.position = transform.position + new Vector3(HorizontalInput, VerticalInput, 0) * Time.deltaTime * shipSpeed;
    }
}
