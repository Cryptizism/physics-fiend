using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float playerSpeed = 10;
    public float jumpForce = 1;
    private Rigidbody2D rb2D;

    // Start is called before the first frame update
    void Start(){
        rb2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update(){
        var movement = Input.GetAxisRaw("Horizontal");
        if(movement != 0){
            rb2D.velocity += new Vector2(movement, 0) * Time.deltaTime * playerSpeed;
        }
        else {
            rb2D.velocity = new Vector2(0, (rb2D.velocity.y * rb2D.gravityScale));
        }
        

        if((Input.GetButtonDown("Jump") || Input.GetKeyDown("w")) && Mathf.Abs(rb2D.velocity.y) < 0.01f){
            rb2D.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
        }
    }

    void FixedUpdate(){
        
    }
}
