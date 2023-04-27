using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CrashDetector : MonoBehaviour
{
    public UnityEvent OnDeath;


    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("trigger");
        OnDeath?.Invoke();
    }
}
