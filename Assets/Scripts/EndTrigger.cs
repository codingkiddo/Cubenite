using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameManager gameManager;
    void OnTriggerEnter() {
        Debug.Log("from here ");
        gameManager.CompleteLevel();
    }
}
