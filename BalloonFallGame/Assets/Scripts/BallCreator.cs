using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallCreator : MonoBehaviour
{
    [SerializeField] private Difficulty difficulty;
    [SerializeField] private BallMovement ball;
    [SerializeField] private Camera mainCamera;

    [Header("Ball speed")]
    [SerializeField] private float minSpeed = 1;
    [SerializeField] private float maxSpeed = 5;
    [Header("Ball creation rate")]
    [SerializeField] private float minRate = 5;
    [SerializeField] private float maxRate = 1;

    private float cameraHalfHeight;
    private float cameraHalfWidth;

    private void Start() {
        cameraHalfHeight = mainCamera.orthographicSize+ball.transform.localScale.y/2;
        cameraHalfWidth = cameraHalfHeight*mainCamera.aspect-ball.transform.localScale.x/2;
        StartCoroutine("CreateBall");
    }

    IEnumerator CreateBall(){
        
        while(true){
            yield return new WaitForSeconds(Mathf.Lerp(minRate, maxRate, difficulty.GetDifficulty()));
            Vector2 ballPosition = new Vector2(Random.Range(-cameraHalfWidth, cameraHalfWidth), cameraHalfHeight);
            BallMovement newBall = Instantiate(ball, ballPosition,Quaternion.identity);
            newBall.SetBallSpeed(Mathf.Lerp(minSpeed, maxSpeed, difficulty.GetDifficulty()));
        }
    }
}
