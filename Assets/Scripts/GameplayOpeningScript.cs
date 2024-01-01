using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameplayOpeningScript : MonoBehaviour
{
    
    //references to the buttons of Play, creditsScreen, howToPlayScreen, and Back button
    public GameObject playBtn;
    public GameObject creditsBtn;
    public GameObject howToPlayBtn;
    public GameObject backBtn;

    private void Start()
    {
        playBtn.SetActive(true);
        creditsBtn.SetActive(true);
        howToPlayBtn.SetActive(true);
        backBtn.SetActive(false);
    }

    //function that changes the screen when play button is clicked
    public void changeSceneToGameplay()
    {
        SceneManager.LoadScene(1);
    } 

    //function called when credits is clicked
    public void creditsButtonClicked()
    {
        playBtn.SetActive(false);
        creditsBtn.SetActive(false);
        howToPlayBtn.SetActive(false);
        backBtn.SetActive(true);
    }

    //function called when how to play is clicked
    public void howToPlayClicked()
    {
        playBtn.SetActive(false);
        creditsBtn.SetActive(false);
        howToPlayBtn.SetActive(false);
        backBtn.SetActive(true);
    }

    //function called when back button is clicked
    public void backBtnClicked()
    {
        playBtn.SetActive(true);
        creditsBtn.SetActive(true);
        howToPlayBtn.SetActive(true);
        backBtn.SetActive(false);
    }
   
    
    
    
}
