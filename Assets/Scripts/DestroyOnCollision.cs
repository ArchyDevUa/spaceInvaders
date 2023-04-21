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
        if (col.gameObject.CompareTag("Enemy"))
        {
            Destroy(col.gameObject);
            Instantiate(explosion,col.transform.position,quaternion.identity);
        }
        
        
        
    }
}
