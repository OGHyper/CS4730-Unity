using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class LogicScript : MonoBehaviour
{
    public int playerHealth = 10;
    public int bossHealth = 75;
    public Text playerHP;
    public Text bossHP;
    public Camera cam;
    public GameObject gameOverScreen;
    public GameObject gameWinScreen;
    public Boolean isAlive = true;

    void Start(){
        isAlive = true;
        playerHP.text = "HP: " + playerHealth;
        bossHP.text = "Boss HP: " + bossHealth;
    }

    void Update(){
        if (playerHealth == 0){
            // Start game over screen
            isAlive = false;
            gameOver();
        }
        else if(bossHealth == 0){
            // Start game win screen
            gameWin();
        }
    }

    public void restartGame(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver(){
        gameOverScreen.SetActive(true);
    }

    public void gameWin(){
        gameWinScreen.SetActive(true);
    }

    public void playerTakeDamage(){
        if (isAlive){
            playerHealth -= 1;
            playerHP.text = "HP: " + playerHealth;
        }
    }

    public void zoomOutCam(){
        // Debug.Log("Entered zoomOutCam");
        cam.orthographicSize = 23;
    }

    public void zoomInCam(){
        // Debug.Log("Entered zoomInCam");
        cam.orthographicSize = 8;
    }

    public void bossTakeDamage(){
        bossHealth -= 1;
        bossHP.text = "Boss HP: " + bossHealth;
    }
}
