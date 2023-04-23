using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Falling : MonoBehaviour
{
    [SerializeField]
    private float forceAmount = 10f;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        { 
            rb.velocity = new Vector2(0f,forceAmount);
        }
    }
}
