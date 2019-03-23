using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpMove : MonoBehaviour
{
    [SerializeField] Rigidbody2D rb;
    protected bool isMovingLeft = true;
    protected bool isMovingRight = false;
    protected bool bumpedIntoSomething = false;
    [SerializeField] Vector2 leftVel;
    [SerializeField] Vector2 rightVel;

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag != "Ground" && col.gameObject.tag != "Block")
        {
            bumpedIntoSomething = true;
        }
        if(col.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            Player.firePower = true; 
        }
    }

    private void FixedUpdate()
    {
        if (bumpedIntoSomething && isMovingLeft == true)
        {
            isMovingLeft = false;
            isMovingRight = true;
            bumpedIntoSomething = false;
        }
        if (bumpedIntoSomething && isMovingRight == true)
        {
            isMovingLeft = true;
            isMovingRight = false;
            bumpedIntoSomething = false;
        }
        if (isMovingLeft)
        {
            rb.MovePosition(rb.position + leftVel * Time.fixedDeltaTime);
        }
        if (isMovingRight)
        {
            rb.MovePosition(rb.position + rightVel * Time.fixedDeltaTime);
        }

    }
}
