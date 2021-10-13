using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerControllers : MonoBehaviour
{

    public int speed = 5;
    public float jumpForce = 5f;
    public Rigidbody2D rb;
    private float movement;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        movement = Input.GetAxisRaw("Horizontal");

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
        }

        rb.position = rb.position + new Vector2(movement * speed * Time.deltaTime, 0);
    }


}
