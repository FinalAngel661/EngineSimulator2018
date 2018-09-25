using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]

public class PlayerController : MonoBehaviour
{
    public Animator anim;
    public Rigidbody rb;
    public CapsuleCollider coll;
    public LayerMask groundLayers;

    // Movement
    public float speed = 5f;
    public float JHeight;
    public float RDistance;
    private float InputH;
    private float InputV;
    private bool Run;

    // Use this for initialization
    void Start ()
    {
       rb = GetComponent<Rigidbody>();
       anim = GetComponent<Animator>();
        Run = false;
	}

    // Update is called once per frame
    void FixedUpdate ()
    {

        if (Input.GetKey(KeyCode.LeftShift))
        {
            Run = true;
        }
        else
        {
            Run = false;
        }

        if (IsGrounded() && Input.GetKeyDown(KeyCode.Space))
        {
            anim.SetBool("Jump", true);
            rb.AddForce(Vector3.up * JHeight, ForceMode.Impulse);
            anim.SetBool("IsGrounded", false);
        }
        else
        {
            anim.SetBool("Jump", false);
            anim.SetBool("IsGrounded", true);
        }

        if (Input.GetKey(KeyCode.LeftControl))
        {
            anim.SetBool("Crouch", true);

        }
        else
        {
            anim.SetBool("Crouch", false);
        }

        if (Input.GetKey("z"))
        {
            anim.SetBool("Roll", true);
            rb.AddForce(Vector3.forward * RDistance, ForceMode.Impulse);
        }
        else
        {
            anim.SetBool("Roll", false);
        }

        InputH = Input.GetAxis("Horizontal");
        InputV = Input.GetAxis("Vertical");

        anim.SetFloat("InputH", InputH);
        anim.SetFloat("InputV", InputV);
        anim.SetBool("Run", Run);

        float moveX = InputH * speed * Time.deltaTime;
        float moveZ = InputV * speed * Time.deltaTime;

        if (Run)
        {
            moveX *= 3f;
            moveZ *= 3f;
        }

        Vector3 movement = new Vector3(moveX, 0f, moveZ);
        //Debug.LogFormat("{0}, {1}", moveX, moveZ);
        rb.MovePosition(transform.position + movement);
        
    }

    private bool IsGrounded()
    {
        return Physics.CheckCapsule(coll.bounds.center, new Vector3(coll.bounds.center.x, coll.bounds.min.y, coll.bounds.center.z), coll.radius * .9f, groundLayers);

    }

}
