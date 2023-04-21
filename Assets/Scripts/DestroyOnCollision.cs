using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class DestroyOnCollision : MonoBehaviour
{
    [SerializeField] private ParticleSystem explosion;
    private void OnCollisionEnter2D(Collision2D col)
    {   
        Destroy(gameObject);
        Debug.Log("Collision");
        Instantiate(explosion,transform.position,quaternion.identity);
        
        
    }
}
