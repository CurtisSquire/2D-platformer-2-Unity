using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWalker : Enemy
{
    private void Update()
    {
        Movement();
        Attack(); 
    }

    public void OnCollisionEnter2D(Collision2D c)
    {
        if(c.gameObject.tag != "Ground")
        {
            Flip(); 
        }
        if(c.gameObject.tag == "MyBall")
        {
            Destroy(this.gameObject); 
        }
    }
}
