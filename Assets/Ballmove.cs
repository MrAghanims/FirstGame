using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.WSA;

public class Ballmove : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb;
    private float movement;
    public int count;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (count == 0) { if (Input.GetMouseButtonDown(0)) { Launch(); count++; } }
        
       
    }

    private void Launch() {
        float x = Random.Range(0, 2) == 0 ? -1 : 1;
        float y = Random.Range(0, 2) == 0 ? -1 : 1;
        rb.velocity = new Vector2(speed*x, speed*y);
    }
}
