using System;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public GameObject gameOverUI;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            Time.timeScale = 0;
            gameOverUI.SetActive(true);
        }
    }
}
