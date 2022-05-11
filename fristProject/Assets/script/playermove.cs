using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermove : MonoBehaviour
{
    public Rigidbody rb;
    public float move = 1000f;
    public float speed = 500f;

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, move * Time.deltaTime);
        if (Input.GetKey("d"))
        {
            rb.AddForce( speed * Time.deltaTime,0,0,ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-speed*Time.deltaTime,0,0, ForceMode.VelocityChange);
        }
        if (rb.position.y <-1f)
        {
            FindObjectOfType<gameManger>().Endgame();
        }
    }
}
