using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Player_Movement : MonoBehaviour
{
    public float speed;
    private float Move;
    public float jump;
    public bool isJumping;
    private float rt;
    public float rotationSpeed = 900000f;

    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();        
        rt = 0.0f;
        //rt.ConvertTo<UnityEngine.Quaternion>();
        //rt = GetComponent<Transform>().rotation;
        
    }

    // Update is called once per frame
    void Update()
    {
        Move = Input.GetAxis("Horizontal");

        rb.velocity = new Vector2(speed * Move, rb.velocity.y);

        if (Input.GetButtonDown("Jump") && isJumping == false)
        {   
            rb.AddForce(new Vector2(rb.velocity.x, jump));

            rt =+ 45f;
            //Quaternion targetQuaternion = Quaternion.Euler(0f, 0f, rt);
            //transform.rotation = targetQuaternion;
            //float targetRotation = transform.rotation.eulerAngles.z + rotationSpeed * Time.deltaTime;           
            Quaternion targetQuaternion = Quaternion.Euler(0f, 0f, rt);            
            transform.rotation = Quaternion.RotateTowards(transform.rotation, targetQuaternion, rotationSpeed * Time.deltaTime);
        }
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            isJumping = false;
        }
    }
    private void OnCollisionExit2D(Collision2D other)
    {
        isJumping = true;
    }

}
