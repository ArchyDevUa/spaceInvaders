using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnAsteroids : MonoBehaviour
{
    [SerializeField] private GameObject asteroid;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnAsteroid",2f,2f);
    }

    // Update is called once per frame
    void SpawnAsteroid()
    {
        Instantiate(asteroid, new Vector2(Random.Range(-6.5f, 6.5f), 10f), quaternion.identity);
    }
}
