using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Players : MonoBehaviour
{
    public float speed;
    public float intensity = 10.0f;
    public float velocity = 10.0f;

    private bool jumpFlag;
    private Rigidbody2D rb;

    public KeyCode pLeft;
    public KeyCode pRight;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        playerMove();
        
    }

    private void playerMove()
    {
        float xMove = Input.GetAxisRaw("Horizontal");

        

        if (Input.GetKey(pLeft))
        {
            transform.Translate(xMove * speed * Time.deltaTime, 0 , 0);
        }
        
        else if (Input.GetKey(pRight))
        {
            transform.Translate(xMove * speed * Time.deltaTime, 0, 0);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector2.up * intensity, ForceMode2D.Impulse);

            
            Vector2 newVelocity = new Vector2(rb.velocity.x, velocity);
            rb.velocity = newVelocity;
            
            jumpFlag = true;

        }
        else
        {
            jumpFlag = false;
        } 

    }


}
