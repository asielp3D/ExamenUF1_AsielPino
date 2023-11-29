using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSensor : MonoBehaviour
{
    public static bool isGrounded;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.layer == 6 )
        {
            isGrounded = true;
        }
    }

    void OnTriggerStay2D(Collider2D other)
    {
         if(other.gameObject.layer == 6 )
        {
            isGrounded = true;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
         if(other.gameObject.layer == 6 )
        {
            isGrounded = false;
        }
    }
}
