using System.Collections;
using System.Collections.Generic;
using Unity.PlasticSCM.Editor.WebApi;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class Script : MonoBehaviour
{
    private Rigidbody2D rigibody;
    public float Speed;
    private float axisHorizontal;
    public float jumpForce;
    public float groundDistance;
    private bool grounded;


    void Awake()
    {
        rigibody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        axisHorizontal = Input.GetAxis("Horizontal");

        Debug.DrawRay(transform.position, Vector3.down * groundDistance, Color.blue);
        if (Physics2D.Raycast(transform.position, Vector3.down, groundDistance))
        {
            grounded = true;
        }

        else grounded = false;

        if (Input.GetKeyDown(KeyCode.W) && grounded)
        {
            rigibody.AddForce(Vector2.up * jumpForce);
        }

    }

    private void FixedUpdate()
    {
        rigibody.velocity = new Vector2(axisHorizontal * Speed, rigibody.velocity.y);
    }

}
