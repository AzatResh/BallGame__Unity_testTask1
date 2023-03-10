using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseManager : MonoBehaviour
{
    public void PauseGame(){
        Time.timeScale = 0;
    }

    public void ReturnGame(){
        Time.timeScale = 1;
    }
}
