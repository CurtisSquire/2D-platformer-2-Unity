using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionBox : MonoBehaviour
{
    // I give the question box a spawn point, a metal box gameobject and powerup in the Unity editor. 
    [SerializeField] GameObject powerUp;
    [SerializeField] GameObject unbreakingBox;
    [SerializeField] Transform powerUpSpawn;

    private void OnCollisionEnter2D(Collision2D c)
    {
        //if it collides with the player it will destroy itself and replace itself with a metal box. 
        //it will also spawn a powerUp at the power up spawn. 
        if(c.gameObject.tag.Equals("Player"))
        {
            Instantiate(unbreakingBox, transform.position, transform.rotation);
            Instantiate(powerUp, powerUpSpawn.position, powerUpSpawn.rotation);
            Destroy(this.gameObject);
        }
    }
}
