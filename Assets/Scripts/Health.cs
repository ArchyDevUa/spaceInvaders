using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    [SerializeField] private int health = 3;
    [SerializeField] private TextMeshProUGUI healthTExt;
    // Start is called before the first frame update
    private void Awake()
    {
        healthTExt.text = "X " + health;
    }

    public void ReduceHealth()
    {
        health--;
        healthTExt.text = "X " + health;
    }

    private void Update()
    {
        if (health == 0)
        {
            SceneManager.LoadScene(1);
        }
    }
}
