using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public Text timerText; // 用於顯示計時器的文字元件
    private bool isGameStarted = false; // 遊戲是否已經開始
    private float gameTimer = 0f; // 遊戲計時器
    private float gameDuration = 300f; // 遊戲持續時間（60秒）

    public void StartGame()
    {
        isGameStarted = true;
    }

    // 更新遊戲計時器的邏輯
    private void Update()
    {
        if (isGameStarted)
        {
            gameTimer += Time.deltaTime; // 每幀時間增加
            UpdateTimerDisplay();

            if (gameTimer >= gameDuration)
            {
                EndGame();
            }
        }
    }

    // 更新計時器顯示
    public void UpdateTimerDisplay()
    {
        int minutes = Mathf.FloorToInt(gameTimer / 60);
        int seconds = Mathf.FloorToInt(gameTimer % 60);
        string timerString = string.Format("{0:00}:{1:00}", minutes, seconds);
        timerText.text = "Time: " + timerString;
    }

    // 遊戲結束的相關邏輯
    private void EndGame()
    {
        isGameStarted = false;
        Debug.Log("Game Over!");
        // 在這裡添加遊戲結束的相關處理，例如顯示得分、顯示遊戲結果畫面等等
    }
}
