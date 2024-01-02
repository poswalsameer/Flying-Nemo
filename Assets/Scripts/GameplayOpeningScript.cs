using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameplayOpeningScript : MonoBehaviour
{
    
    //references to the buttons of Play, creditsScreen, howToPlayScreen, and Back button
    public GameObject playBtn;
    public GameObject creditsBtn;
    public GameObject howToPlayBtn;
    public GameObject backBtn;

    //references for the text

    public Text creditsText;
    public Text nameText;
    public Text controlsText;
    public Text instructionsText;

    private void Start()
    {
        playBtn.SetActive(true);
        creditsBtn.SetActive(true);
        howToPlayBtn.SetActive(true);
        backBtn.SetActive(false);
        creditsText.gameObject.SetActive(false);
        nameText.gameObject.SetActive(false);
        controlsText.gameObject.SetActive(false);
        instructionsText.gameObject.SetActive(false);
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
        creditsText.gameObject.SetActive(true);
        nameText.gameObject.SetActive(true);
        controlsText.gameObject.SetActive(false);
        instructionsText.gameObject.SetActive(false);
    }

    //function called when how to play is clicked
    public void howToPlayClicked()
    {
        playBtn.SetActive(false);
        creditsBtn.SetActive(false);
        howToPlayBtn.SetActive(false);
        backBtn.SetActive(true);
        creditsText.gameObject.SetActive(false);
        nameText.gameObject.SetActive(false);
        controlsText.gameObject.SetActive(true);
        instructionsText.gameObject.SetActive(true);
    }

    //function called when back button is clicked
    public void backBtnClicked()
    {
        playBtn.SetActive(true);
        creditsBtn.SetActive(true);
        howToPlayBtn.SetActive(true);
        backBtn.SetActive(false);
        creditsText.gameObject.SetActive(false);
        nameText.gameObject.SetActive(false);
        controlsText.gameObject.SetActive(false);
        instructionsText.gameObject.SetActive(false);
    }
   
    
    
    
}
