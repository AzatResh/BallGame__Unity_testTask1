
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    private float speed;

    public void SetBallSpeed(float _speed){
        speed = _speed;
    }

    private void Update() {
        transform.Translate(Vector2.down*speed*Time.deltaTime);
    }
}
