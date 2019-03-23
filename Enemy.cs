using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float rateOfThrowing;
    public float lastThrowTime;
    public float throwForce = 100;
    public float timer = 0;
    public Vector2 leftVel;
    public Vector2 rightVel;
    public Rigidbody2D throwable;
    public Rigidbody2D attackRb;
    public Transform throwspawn;
    public bool isFacingRight = true;
    public Rigidbody2D rb;

    public void Movement()
    {
        if(isFacingRight)
        {
            rb.MovePosition(rb.position + leftVel * Time.fixedDeltaTime); 
        }
        if(!isFacingRight)
        {
            rb.MovePosition(rb.position + rightVel * Time.fixedDeltaTime); 
        }
    }

    public void Flip()
    {
        isFacingRight = !isFacingRight;
        transform.Rotate(0f, 180f, 0f);
        timer = 0; 
    }
    
    public void Attack()
    {
        if(throwspawn && throwable)
        {
            Rigidbody2D temp = Instantiate(throwable, throwspawn.position, throwspawn.rotation);
            Physics2D.IgnoreCollision(GetComponent<Collider2D>(), temp.GetComponent<Collider2D>(), true); 
            if(isFacingRight)
            {
                temp.AddForce(-throwspawn.right * throwForce, ForceMode2D.Impulse);
                lastThrowTime = Time.time; 
            }
            else if(!isFacingRight)
            {
                temp.transform.Rotate(0, 180, 0);
                temp.AddForce(-throwspawn.right * throwForce, ForceMode2D.Impulse);
                lastThrowTime = Time.time;
            }
        }
    }
}
