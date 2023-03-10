using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private Slider playerHpSlider;
    [SerializeField] private GameObject gameOverMenu;
    [SerializeField] private GameObject pauseMenu;

    public void UpdatePlayerHealth(float health){
        playerHpSlider.value = health;
    }

    public void UpdateScore(float _score){
        scoreText.text = _score.ToString();
    }

    public void ShowDeathGameOverScreen(){
        gameOverMenu.SetActive(true);
    }

    public void ShowPauseMenu(){
        pauseMenu.SetActive(true);
    }

    public void UnshowPauseMenu(){
        pauseMenu.SetActive(false);
    }
}
