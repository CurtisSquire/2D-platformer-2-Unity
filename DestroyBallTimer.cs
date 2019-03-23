using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBallTimer : MonoBehaviour
{
    //lets me set timer in unity editor. 
    [SerializeField] float timer;

    private void Start()
    {
        //sets object to be destroyed after time passes. 
        Destroy(gameObject, timer); 
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        //destroys when it collides with something other than the ground or player. 
        //if it collides with an enemy it and the enemy will be destroyed. 
        if(col.gameObject.tag != "Ground" && col.gameObject.tag != "Player")
        {
            Destroy(gameObject); 
        }
        else if(col.gameObject.tag == "Enemy")
        {
            Destroy(col.gameObject);
            Destroy(gameObject); 
        }
    }
}
