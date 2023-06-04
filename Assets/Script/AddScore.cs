using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddScore : MonoBehaviour
{
    public GameObject White1;
    public GameObject White2;
    public GameObject White3;
    public GameObject White4;
    public GameObject White5;
    public GameObject White6;
    public GameObject White7;
    public GameObject White8;
    public GameObject White9;

    //每個紅色的按鈕
    public GameObject Red1;
    public GameObject Red2;
    public GameObject Red3;
    public GameObject Red4;
    public GameObject Red5;
    public GameObject Red6;
    public GameObject Red7;
    public GameObject Red8;
    public GameObject Red9;
    public Text NowScore;
    public int Score = 0;
    public void GetScore()
    {
        Score++;
        NowScore.text = "當前分數：" + Score + "分";
        
        StartCoroutine(DelayButtonSetActive());
    }

    IEnumerator DelayButtonSetActive()
    {
        yield return new WaitForSeconds(0.5f); // 延遲0.5秒
        
        ButtonSetActive();
    }

    void ButtonSetActive(){
        //將所有白色按鈕都設成可見
        White1.SetActive(true);
        White2.SetActive(true);
        White3.SetActive(true);
        White4.SetActive(true);
        White5.SetActive(true);
        White6.SetActive(true);
        White7.SetActive(true);
        White8.SetActive(true);
        White9.SetActive(true);
        //將所有紅色按鈕都設成不可見
        Red1.SetActive(false);
        Red2.SetActive(false);
        Red3.SetActive(false);
        Red4.SetActive(false);
        Red5.SetActive(false);
        Red6.SetActive(false);
        Red7.SetActive(false);
        Red8.SetActive(false);
        Red9.SetActive(false);
    }

    public void Refresh(){
        Score = 0;
        NowScore.text = "當前分數：" + Score + "分";
    }
}