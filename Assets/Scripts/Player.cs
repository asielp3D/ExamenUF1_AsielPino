using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    float horizontal;
    public float _plyerSpeed = 5;
    public float _jumpForce = 5;
    Rigidbody2D _rbody;
    Animator _animator;

    // Start is called before the first frame update
    void Start()
    {
        _rbody = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    
    void Update()
    {
        Movement();
    }

    void FixedUpdate()
    {
        _rbody.velocity = new Vector2 (horizontal * _plyerSpeed, _rbody.velocity.y);
    }

    void Movement()
    {
        horizontal = Input.GetAxis("Horizontal");
        
        if(horizontal < 0)
        {
            transform.rotation = Quaternion.Euler(0, 180, 0);
        }

        if(horizontal > 0)
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
    }

    void Jump()
    {
        //_rbody.Addforce
    }

    // Victor te quiero no me suspendas <3
}
