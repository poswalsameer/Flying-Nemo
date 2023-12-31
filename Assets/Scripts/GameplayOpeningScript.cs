using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameplayOpeningScript : MonoBehaviour
{
    //this function is run when the play button is clicked in the main menu screen

    public GameObject playBtn;

    public void changeSceneToGameplay()
    {
        SceneManager.LoadScene(1);
    } 
   
    
    
    
}
