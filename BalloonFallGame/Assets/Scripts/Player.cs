using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] UIManager ui;
    [SerializeField] PauseManager pauseManager;
    [SerializeField] private int maxHealth = 3;
    private int health;

    private void Start() {
        health = maxHealth;
    }

    public void TakeDamage(int _damage){
        health -= _damage;
        ui.UpdatePlayerHealth((float)health/maxHealth);
        CheckDeath();
    }

    public void CheckDeath(){
        if(health>0) return;
        pauseManager.PauseGame();
        ui.ShowDeathGameOverScreen();
    }
}
