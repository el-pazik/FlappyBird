using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    [SerializeField] private GameObject pipe_top;
    [SerializeField] private GameObject pipe_bottom;
    [SerializeField] private Transform StartPosition;

    private float maxTime = 2;
    private float timer = 0;


    void Update()
    {
        if (timer > maxTime)
        {
            SpawnPipes();
            timer = 0;
        }

        timer += Time.deltaTime;
    }

    private void SpawnPipes()
    {
        GameObject newPipeTop = Instantiate(pipe_top, StartPosition);
        GameObject newPipeBottom = Instantiate(pipe_bottom, StartPosition);
        int bottom_position = Random.Range(-8, -4);
        int space_between;
        if (bottom_position > -7)
        {
            space_between = Random.Range(3, 9 - (bottom_position + 10));
        }
        else
        {
            space_between = Random.Range(3, 5);
        }
        
        
        newPipeBottom.transform.position = new Vector2(4, bottom_position);
        newPipeTop.transform.position = new Vector2(4, bottom_position + space_between + 10);
        Destroy(newPipeBottom, 3);
        Destroy(newPipeTop, 3);
    }
}
