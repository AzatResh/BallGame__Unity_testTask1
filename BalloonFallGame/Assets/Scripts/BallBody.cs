using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent (typeof (BallMovement))]
public class BallBody : MonoBehaviour
{
    [SerializeField] private SpriteRenderer ballSprite;
    [SerializeField] private ParticleSystem partycle;
    public static Action AddScore;

    private void Start(){
        ChangeBallColor();
    }
    
    private void OnMouseDown() {
        StartPartycleEffect();
        AddScore?.Invoke();
        Destroy(gameObject, 0.2f);
    }

    private void ChangeBallColor(){
        Color new_color = UnityEngine.Random.ColorHSV();
        ballSprite.color = new_color;
    }

    private void StartPartycleEffect(){
        ParticleSystem.MainModule main = partycle.main;
        main.startColor = ballSprite.color;
        partycle.Play();
    }

    private void OnTriggerEnter2D(Collider2D other) {
        Player _player;
        
        if(other.TryGetComponent<Player>(out _player)){
            _player.TakeDamage(1);
            Destroy(gameObject);
        }
    }
}
