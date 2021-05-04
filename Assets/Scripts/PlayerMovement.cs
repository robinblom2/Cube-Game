using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rb;                                // This is a reference to the Rigidbody component called "rb". 

    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;

    // Update is called once per frame                  // We marked this as "Fixed" because we are using it to mess with physics.
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);       // Add a forward force. 

        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }

    }
}
