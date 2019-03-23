using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseGame : MonoBehaviour
{
    //allows me to attach a canvas group to this script and place it in the canGroup variable
    [SerializeField] CanvasGroup canGroup;

    private void Update()
    {
        //if the player presses Escape or P the pause will toggle on or off. 
        if(Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.P))
        {
            Pause(); 
        }
    }
    //Pause function makes the pause canvase visable through the canvase group 
    //if it is not paused already and if it is it makes the pause canvase invisible to the player.
    //Time is also frozen when pause is toggled on and set back to normal when pause is taggled off. 
    public void Pause()
    {
        if(canGroup.alpha == 0.0f)
        {
            canGroup.alpha = 1.0f;
            Time.timeScale = 0.0f; 
        }
        else
        {
            canGroup.alpha = 0.0f;
            Time.timeScale = 1.0f; 
        }
    }

}
