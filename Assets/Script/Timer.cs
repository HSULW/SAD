using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    //每個白色的按鈕
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

    /*//每個凸起白色的按鈕
    public GameObject WhiteUp1;
    public GameObject WhiteUp2;
    public GameObject WhiteUp3;
    public GameObject WhiteUp4;
    public GameObject WhiteUp5;
    public GameObject WhiteUp6;
    public GameObject WhiteUp7;
    public GameObject WhiteUp8;
    public GameObject WhiteUp9;*/

    public GameObject RemainTime;
    public GameObject Hint;
    public Text RemainTimeWord;
    public Text HintWord;
    public Text WhichDifficulty;
    public Text WhichTime;
    private float currentTime;    // 目前的計時時間
    //記錄這個秒數有沒有出現過，一秒內會update很多次，所以可能會有很多個相同秒數
    private bool IsThisNumberHasAppear = false;
    private bool IsStart = false;
    int difficulty = 3;
    int GameTime = 30;

    void Start()
    {
        currentTime = 0f;  // 將目前計時時間設置為0
    }

    void Update()
    {
        if(IsStart == true){
            //紀錄上一個出現的秒數
            int IntCurrentTime = (int)currentTime;
            int NumBefore = IntCurrentTime;
            
            currentTime += Time.deltaTime;  // 每幀增加過去的時間

            //記錄下一個會出現的秒數
            IntCurrentTime = (int)currentTime;
            int NumNow = IntCurrentTime;

            RemainTimeWord.text = "剩餘時間：" + (GameTime-NumNow) + "秒";

            //若上一個跟下一個秒數不相同則代表是新的一個秒數
            if(NumBefore == NumNow){
                IsThisNumberHasAppear = false;
            }
            else{
                IsThisNumberHasAppear = true;
            }

            //間隔幾秒
            if(IntCurrentTime % difficulty == 0 && IsThisNumberHasAppear == true){
                ChooseWhichIsOn();
            }

            if(NumNow == GameTime){
                IsStart = false;
                currentTime = 0f;
                HintWord.text = "遊戲已結束";
            }
        }    
    }

    void ChooseWhichIsOn(){
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

        /*WhiteUp1.SetActive(false);
        WhiteUp2.SetActive(false);
        WhiteUp3.SetActive(false);
        WhiteUp4.SetActive(false);
        WhiteUp5.SetActive(false);
        WhiteUp6.SetActive(false);
        WhiteUp7.SetActive(false);
        WhiteUp8.SetActive(false);
        WhiteUp9.SetActive(false);*/

        int RandomNumber = Random.Range(1, 10);
        //Debug.Log("隨機數字為:" + RandomNumber);

        switch(RandomNumber){
            case 1:
                White1.SetActive(false);
                Red1.SetActive(true);
                //Debug.Log("1號變紅燈");
                //WhiteUp1.SetActive(true);
                break;
            case 2:
                White2.SetActive(false);
                Red2.SetActive(true);
                //Debug.Log("2號變紅燈");
                //WhiteUp2.SetActive(true);
                break;
            case 3:
                White3.SetActive(false);
                Red3.SetActive(true);
                //Debug.Log("3號變紅燈");
                //WhiteUp3.SetActive(true);
                break;
            case 4:
                White4.SetActive(false);
                Red4.SetActive(true);
                //Debug.Log("4號變紅燈");
                //WhiteUp4.SetActive(true);
                break;
            case 5:
                White5.SetActive(false);
                Red5.SetActive(true);
                //Debug.Log("5號變紅燈");
                //WhiteUp5.SetActive(true);
                break;
            case 6:
                White6.SetActive(false);
                Red6.SetActive(true);
                //Debug.Log("6號變紅燈");
                //WhiteUp6.SetActive(true);
                break;
            case 7:
                White7.SetActive(false);
                Red7.SetActive(true);
                //Debug.Log("7號變紅燈");
                //WhiteUp7.SetActive(true);
                break;
            case 8:
                White8.SetActive(false);
                Red8.SetActive(true);
                //Debug.Log("8號變紅燈");
                //WhiteUp8.SetActive(true);
                break;
            case 9:
                White9.SetActive(false);
                Red9.SetActive(true);
                //Debug.Log("9號變紅燈");
                //WhiteUp9.SetActive(true);
                break;
        }
    }

    public void StartTheGame(){
        IsStart = true;
        HintWord.text = "遊戲已開始";
        Hint.SetActive(true);
        RemainTime.SetActive(true);
    }

    public void DifficultyChooseEasy(){
        difficulty = 3;
        WhichDifficulty.text = "遊戲難度:Easy";
    }

    public void DifficultyChooseMedium(){
        difficulty = 2;
        WhichDifficulty.text = "遊戲難度:Medium";  
    }

    public void DifficultyChooseHard(){
        difficulty = 1;
        WhichDifficulty.text = "遊戲難度:Hard"; 
    }

    public void Seclct10Second(){
        GameTime = 10;
        WhichTime.text = "遊戲時間:10秒";
    }

    public void Seclct30Second(){
        GameTime = 30;
        WhichTime.text = "遊戲時間:30秒";
    }

    public void Seclct60Second(){
        GameTime = 60;
        WhichTime.text = "遊戲時間:60秒";
    }
}