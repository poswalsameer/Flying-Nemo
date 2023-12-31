using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    //text used to display the score
    public Text scoreText;
    //gameobject ref to the play button
    public GameObject playButton;
    //gameobject ref to the game over sprite
    public GameObject gameOverImage;

    //ref to the player script
    public Player player;

    private int score;

    //public void Awake()
    //{
      //  Application.targetFrameRate = 60;
        //Pause();
    //}

    //{
      //  score = 0;
        //scoreText.text = score.ToString();

        //playButton.SetActive(false);
        //gameOverImage.SetActive(false);

        //Time.timeScale = 1f;
        //player.enabled = true; 
    //}

    //public void Pause()
    //{
      //  Time.timeScale = 0f;
        //player.enabled = false; 
        
    //}

    //public void increaseScore()
    //{
      //  score++;
        //scoreText.text = score.ToString();
    //}

    //public void gameOver()
    //{
      //  Debug.Log("Game Over");
        //gameOverImage.SetActive(true);  
        //playButton.SetActive(true);

        //Pause();
    //}
}
