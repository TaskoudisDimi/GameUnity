using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerMovement : MonoBehaviour
{


    public Rigidbody rb;
    public float forwardForce = 10f;
    public float sideawayForce = 500f;
    private float delay = 2f;
    public Transform vrCamera;
    public float toggleAngle = 0.3f;

    // Update is called once per frame  
    void Update ()
    {

        rb.AddForce(0, 000, forwardForce * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            rb.AddForce(sideawayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sideawayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (rb.position.y < -1f)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            Invoke("Restart", delay);
        }

       


    } 
}



