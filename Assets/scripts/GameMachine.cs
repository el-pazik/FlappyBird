using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMachine : MonoBehaviour
{
    public GameObject StartCanvas;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
    }


    public void GameOver()
    {
        StartCanvas.SetActive(true);
        Time.timeScale = 0;
    }
}
