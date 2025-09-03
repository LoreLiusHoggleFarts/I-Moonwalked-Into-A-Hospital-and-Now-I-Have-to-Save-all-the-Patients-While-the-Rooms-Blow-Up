using UnityEngine;
using TMPro;
using System;

public class Timer : MonoBehaviour
{
    [SerializeField] float startTime;
    [SerializeField] private float currentTime;
    public TextMeshProUGUI text;
    public bool isRunning = false;
    GameOver finished;

    private void Start()
    {
        currentTime = startTime;
        finished = GetComponent<GameOver>();
    }

    void Update()
    {
        if (currentTime > 0)
        {
            currentTime -= Time.deltaTime;
            text.text = currentTime.ToString("F2");
        }

        if (currentTime <= 0)
        {
            Time.timeScale = 0;
            finished.gameOverUI.SetActive(true);
        }
    }
    

    public void startTimer()
    {
        isRunning = true;
    }
}
