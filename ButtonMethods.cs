using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class ButtonMethods : MonoBehaviour
{
    public void CloseGame()
    {
        //closes app. 
        Application.Quit(); 
    }

    public void LoadLevelOne()
    {
        //loads scene "levelOne". 
        SceneManager.LoadScene("LevelOne"); 
    }
}
