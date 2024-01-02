using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    //text used to display the score
    public Text scoreText;
    public Text pauseText;
    //gameobject ref to the play button,main menu button and start game button
    public GameObject playButton;
    public GameObject mainMenuButton;
    public GameObject startGameButton;
    public GameObject resumeButton;
    public GameObject pauseButton;
    //gameobject ref to the game over sprite
    public GameObject gameOverImage;

    //ref to the player script
    public Player player;

    public Walls walls;

    private int score;

    private void Start()
    {
        playButton.SetActive(false);
        mainMenuButton.SetActive(false);
        gameOverImage.SetActive(false);
        resumeButton.SetActive(false);
        startGameButton.SetActive(true);
        pauseText.gameObject.SetActive(false);
    }

    //this function will be called first when the game starts,
    // the game originally will be paused, when the player clicks start, then the game starts
    private void Awake()
    {
        Application.targetFrameRate = 60;
        Pause();
    }

    public void play()
    {
        score = 0;  
        scoreText.text = score.ToString();

        //this is done to reset the position of player when new game is started
        player.transform.position = Vector3.zero;

        startGameButton.SetActive(false);
        playButton.SetActive(false);
        mainMenuButton.SetActive(false);
        resumeButton.SetActive(false);
        gameOverImage.SetActive(false);
        pauseText.gameObject.SetActive(false);

        Time.timeScale = 1f;
        player.enabled = true;

        //logic to destroy all the walls in the screen, when game starts

        Walls[] wallArr = FindObjectsOfType<Walls>();

        for(int i=0; i<wallArr.Length; i++)
        {
            Destroy(wallArr[i].gameObject);
        }
    }

    //logic to pause the game by using timescale
    public void Pause()
    {
        Time.timeScale = 0f;
        //when game is paused, player should not move, that's why false
        player.enabled = false; 
    }

    //logic to increase score
    public void increaseScore()
    {
        score++;
        scoreText.text = score.ToString();
    }

    public void gameOver()
    {
        Debug.Log("Game Over");
        gameOverImage.SetActive(true);  
        playButton.SetActive(true);
        mainMenuButton .SetActive(true);
        startGameButton.SetActive(false);
        resumeButton.SetActive(false);
        pauseText.gameObject.SetActive(false);
        pauseButton.SetActive(false);
        Pause();
    }

    //in this function, when player clicks play again, the play function is called
    public void onClickPlayAgain()
    {
        play();
    }

    //scene changed to main menu when main menu is clicked
    public void onMainMenuClicked()
    {
        SceneManager.LoadScene(0);
    }

    public void pauseGame()
    {
        Time.timeScale = 0f;
        player.enabled=false;   
    }

    public void pauseButtonClicked()
    {
        playButton.SetActive(false);
        resumeButton.SetActive(true);
        mainMenuButton.SetActive(true);
        gameOverImage.SetActive(false);
        startGameButton.SetActive(false);
        pauseText.gameObject.SetActive(true);

        pauseGame();
    }

    public void resumeButtonClicked()
    {
        Time.timeScale = 1f;
        player.enabled = true;

        playButton.SetActive(false);
        resumeButton.SetActive(false);
        mainMenuButton.SetActive(false);
        gameOverImage.SetActive(false);
        startGameButton.SetActive(false);
        pauseText.gameObject.SetActive(false);
    }
}
