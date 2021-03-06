using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using AppodealAds.Unity.Api;
using AppodealAds.Unity.Common;

public class player_script : MonoBehaviour {

    public static float speedCountBot;
    public Text langTxtDontView;
    public Text langTxtNext_2;
    public Text langTxtPause;
    public Text langTxtNo;
    public Text langTxtYes;
    public Text langTxtRestart;
    public Text langTxtFailstart;
    public Text langTxtStudy_2;
    public Text langTxtStudy;
    public Text langTxtClickToNext;
    public Text langBttnNext;
    public Text langBttnGotov;
    public Image award;
    public Sprite awardGold;
    public Sprite awardSilver;
    public Sprite awardBronze;
    public Sprite awardDiplom;
    public bool timeSpeedBool;
    public Text timeSpeed;
    public GameObject bttnStart;
    public static float timeDelayBot_1;
    public static float timeDelayBot_2;
    public static float timeDelayBot_3;
    public static float timeDelayBot_4;
    public static float timeDelayBot_5;
    public static float bot_1;
    public static float bot_2;
    public static float bot_3;
    public static float bot_4;
    public static float bot_5;
    int finalPosition;
    public Text txtNumberRace;
    public static int raceNumber;
    float greatFloat;
    public Text greatTxt;
    public Animator greatAnim;
    public Animator turnAnim;
    public GameObject bttnTurnUp;
    public GameObject bttnTurnDown;
    public GameObject turnPanel;
    public GameObject circleTurn;
    public GameObject timeGO;
    public Sprite shapochkaSp;
    public Sprite shapochkaSp_1;
    public Sprite shapochkaSp_2;
    public Sprite shapochkaSp_3;
    public Sprite melting_1W;
    public Sprite melting_2W;
    public Sprite melting_3W;
    public Sprite melting_1M;
    public Sprite melting_2M;
    public Sprite melting_3M;
    public Sprite melting_Men;
    public Sprite melting_Woomen;
    public GameObject lightPanel;
    public GameObject panelChek;
    public Animator vignetteAnim;
    public TrailRenderer trlRender1;
    public TrailRenderer trlRender2;
    public TrailRenderer trlRender3;
    public GameObject bttnNext;
    public float endurance;
    public Text timerText;
    public GameObject plavkiM;
    public GameObject plavkiW;
    public AudioSource AUsource;
    public AudioSource HeartSound;
    public AudioClip AUstart;
    public GameObject panelRestart;
    public GameObject tgglSay;
    public Toggle dontSay;
    public Text txtStudy;
    int studyPos;
    public GameObject panel_Study;
    bool svist;
    float plavkiHSV;
    public Image plavki_Woomen;
    public Image plavki;
    public Image shapochka;
    public Rigidbody2D power;
    GameObject panelSwimmingPool;
    public static float speedCount;
    public static int xPosition;
    public static float powerPush;
    public static bool startOn;
    public static int position;
    public static float raceTime;
    public Text text1;
    public Text text2;
    public Text text3;
    public Text text4;
    public Text textSwim1;
    public Text textSwim2;
    public Text textSwim3;
    public Text textSwim4;
    int winnerGold;
    public static string myName;
    float myTime;
    public static int raceDist;
    public static int stileToday;
    bool okSir;
    public GameObject panelReady;
    public Text checkStillText;
    string stillString;
    public Text positionTXT;
    public GameObject panelExit;
    int myPosition;
    public Text winnerText;
    Animator animator;
    TrailRenderer trlRender;
    float fstPos;
    float scndPos;
    public static string anim_stile;
    int sceneNumber;
    float enduranceMinus;
    public GameObject panelPause;
    int langInt;

    void Awake()
    {
        if (PlayerPrefs.GetString("language") == "rus")
        {
            langInt = 1;
            langTxtDontView.text = "Не показывать больше";
            langBttnGotov.text = "Готов!";
            langBttnNext.text = "Продолжить";
            langTxtClickToNext.text = "Нажмите для продолжения";
            langTxtFailstart.text = "Фальстарт";
            langTxtNext_2.text = "Продолжить";
            langTxtNo.text = "Перейти к следующему заплыву";
            langTxtYes.text = "Попробовать";
            langTxtRestart.text = "Есть шанс на повторный заплыв";
            langTxtPause.text = "Пауза";
            langTxtStudy.text = "Обучение";
            langTxtStudy_2.text = "Нажмите на экран и удерживайте, пока круги не совпадут (прозвучит свисток)";
        }
        else
        {
            langInt = 2;
            langTxtDontView.text = "Не показывать больше";
            langBttnGotov.text = "Ready!";
            langBttnNext.text = "Continue";
            langTxtClickToNext.text = "Press to continue";
            langTxtFailstart.text = "False start";
            langTxtNext_2.text = "Continue";
            langTxtNo.text = "Go to the next swim";
            langTxtYes.text = "Try";
            langTxtRestart.text = "There is a chance to re-swim";
            langTxtPause.text = "Pause";
            langTxtStudy.text = "Training";
            langTxtStudy_2.text = "Tap the screen and hold down until the circles do not match (sound whistle)";
        }
        enduranceMinus = 0.001f;
        tgglSay.SetActive(false);
        studyPos = 1;
        if(PlayerPrefs.GetInt("study") == 1)
        {
            panel_Study.SetActive(true);
        }
        else panel_Study.SetActive(false);
        svist = false;
        myPosition = 0;
        stillString = "";
        checkStillText.text = "";
        panelReady.SetActive(true);
        if (PlayerPrefs.GetInt("okdist1") == 1)
        {
            stileToday = PlayerPrefs.GetInt("swimStill1");
            raceDist = PlayerPrefs.GetInt("swimDist1");
            PlayerPrefs.SetInt("okdist1", 0);
            sceneNumber = 1;
        }
        else if (PlayerPrefs.GetInt("okdist2") == 1)
        {
            stileToday = PlayerPrefs.GetInt("swimStill2");
            raceDist = PlayerPrefs.GetInt("swimDist2");
            PlayerPrefs.SetInt("okdist2", 0);
            sceneNumber = 2;
        }
        else if (PlayerPrefs.GetInt("okdist3") == 1)
        {
            stileToday = PlayerPrefs.GetInt("swimStill3");
            raceDist = PlayerPrefs.GetInt("swimDist3");
            PlayerPrefs.SetInt("okdist3", 0);
            sceneNumber = 3;
        }
        else if (PlayerPrefs.GetInt("okdist4") == 1)
        {
            stileToday = PlayerPrefs.GetInt("swimStill4");
            raceDist = PlayerPrefs.GetInt("swimDist4");
            PlayerPrefs.SetInt("okdist4", 0);
            sceneNumber = 4;
        }

        else
        {
            SceneManager.LoadScene(0);
            Time.timeScale = 1;
        }

        switch (raceDist)
        {
            case 1:
                raceDist = 2;
                stillString = "50м";
                break;
            case 2:
                raceDist = 4;
                stillString = "100м";
                break;
            case 3:
                raceDist = 8;
                stillString = "200м";
                break;
            case 4:
                raceDist = 16;
                stillString = "400м";
                break;
        }
        animator = GetComponent<Animator>();
        switch (stileToday)
        {
            case 1:
                if(langInt == 2) stillString = stillString + " Breaststroke";
                if (langInt == 1) stillString = stillString + " Брасс";
                animator.SetBool("Brass", true);
                speedCount = PlayerPrefs.GetFloat("speedBrass");
                anim_stile = "Brass";
                if (speedCount < 5) raceNumber = 6;
                if ((speedCount >= 5) && (speedCount <= 5.2f)) raceNumber = 5;
                if ((speedCount >= 5.2f) && (speedCount <= 5.4f)) raceNumber = 4;
                if ((speedCount >= 5.4f) && (speedCount <= 5.6f)) raceNumber = 3;
                if ((speedCount >= 5.6f) && (speedCount <= 5.8f)) raceNumber = 2;
                if (speedCount >= 5.8f)
                {
                    speedCountBot = 5.8f;
                    raceNumber = 1;
                }
                break;
            case 2:
                if (langInt == 2) stillString = stillString + " Сrawl";
                if (langInt == 1) stillString = stillString + " Кроль";
                animator.SetBool("Krowl", true);
                speedCount = PlayerPrefs.GetFloat("speedKrowl");
                anim_stile = "Krowl";
                if (speedCount < 5) raceNumber = 6;
                if ((speedCount >= 5) && (speedCount <= 5.2f)) raceNumber = 5;
                if ((speedCount >= 5.2f) && (speedCount <= 5.4f)) raceNumber = 4;
                if ((speedCount >= 5.4f) && (speedCount <= 5.6f)) raceNumber = 3;
                if ((speedCount >= 5.6f) && (speedCount <= 5.8f)) raceNumber = 2;
                if (speedCount >= 5.8f)
                {
                    speedCountBot = 5.8f;
                    raceNumber = 1;
                }
                break;
            case 3:
                if (langInt == 2) stillString = stillString + " Backstroke";
                if (langInt == 1) stillString = stillString + " На спине";
                animator.SetBool("Spin", true);
                speedCount = PlayerPrefs.GetFloat("speedSpina");
                anim_stile = "Spin";
                if (speedCount < 5) raceNumber = 6;
                if ((speedCount >= 5) && (speedCount <= 5.2f)) raceNumber = 5;
                if ((speedCount >= 5.2f) && (speedCount <= 5.4f)) raceNumber = 4;
                if ((speedCount >= 5.4f) && (speedCount <= 5.6f)) raceNumber = 3;
                if ((speedCount >= 5.6f) && (speedCount <= 5.8f)) raceNumber = 2;
                if (speedCount >= 5.8f)
                {
                    speedCountBot = 5.8f;
                    raceNumber = 1;
                }
                break;
            case 4:
                if (langInt == 2) stillString = stillString + " Butterfly";
                if (langInt == 1) stillString = stillString + " Баттерфляй";
                animator.SetBool("Batt", true);
                speedCount = PlayerPrefs.GetFloat("speedBat");
                anim_stile = "Batt";
                if (speedCount < 5) raceNumber = 6;
                if ((speedCount >= 5) && (speedCount <= 5.2f)) raceNumber = 5;
                if ((speedCount >= 5.2f) && (speedCount <= 5.4f)) raceNumber = 4;
                if ((speedCount >= 5.4f) && (speedCount <= 5.6f)) raceNumber = 3;
                if ((speedCount >= 5.6f) && (speedCount <= 5.8f)) raceNumber = 2;
                if (speedCount >= 5.8f)
                {
                    speedCountBot = 5.8f;
                    raceNumber = 1;
                }
                break;
        }
        speedCountBot = speedCount;
        if (langInt == 2) txtNumberRace.text = (raceNumber + " Swim");
        if (langInt == 1) txtNumberRace.text = (raceNumber + " Заплыв");
        startOn = false;
        position = 0;
        xPosition = Random.Range(1, 5);
        Debug.Log(xPosition);
        myName = PlayerPrefs.GetString("secName") + " " + PlayerPrefs.GetString("Name");
        switch (xPosition)
        {
            case 1:
                xPosition = -174;
                lightPanel.transform.localPosition = new Vector2(-174, lightPanel.transform.position.y);
                text1.text = myName.ToString();
                break;
            case 2:
                xPosition = -57;
                lightPanel.transform.localPosition = new Vector2(-57, lightPanel.transform.position.y);
                text2.text = myName.ToString();
                break;
            case 3:
                xPosition = 57;
                lightPanel.transform.localPosition = new Vector2(57, lightPanel.transform.position.y);
                text3.text = myName.ToString();
                break;
            case 4:
                xPosition = 174;
                lightPanel.transform.localPosition = new Vector2(174, lightPanel.transform.position.y);
                text4.text = myName.ToString();
                break;
        }
        checkStillText.text = stillString;
        bot_1 = speedCountBot * Random.Range(90, 110) / 100;
        bot_2 = speedCountBot * Random.Range(90, 110) / 100;
        bot_3 = speedCountBot * Random.Range(90, 110) / 100;
        bot_4 = speedCountBot * Random.Range(90, 110) / 100;
        bot_5 = speedCountBot * Random.Range(90, 110) / 100;
        timeDelayBot_1 = (float)Random.Range(0, 100) / (float)100;
        timeDelayBot_2 = (float)Random.Range(0, 100) / (float)100;
        timeDelayBot_3 = (float)Random.Range(0, 100) / (float)100;
        timeDelayBot_4 = (float)Random.Range(0, 100) / (float)100;
        timeDelayBot_5 = (float)Random.Range(0, 100) / (float)100;
    }

    void Start() {
        Time.timeScale = 1;
        timeSpeedBool = false;
        timeSpeed.text = "1X";
        powerPush = 5f;
        endurance = PlayerPrefs.GetFloat("condition") + 0.15f;
        if(PlayerPrefs.GetFloat("condition") < 0.6f)
        {
            endurance = 0.6f;
        }
        powerPush = speedCount;
        okSir = false;
       
        if (((float)Screen.width / Screen.height) == 0.5625)
        {
            Debug.Log("FHD");
            transform.localPosition = new Vector3(xPosition, -549, -10); // -583
        }
        else if (((float)Screen.width / Screen.height) == 0.625)
        {
            Debug.Log("HD");
            transform.localPosition = new Vector3(xPosition, -485, -10);
        }
        else if (((float)Screen.width / Screen.height) == 0.6)
        {
            Debug.Log("FUCK");
            transform.localPosition = new Vector3(xPosition, -500, -10);
        }
        else if (((float)Screen.width / Screen.height) == 0.5)
        {
            Debug.Log("FFFUUUUCK!");
            transform.localPosition = new Vector3(xPosition, -600, -10);
        }
        else 
        {
            Debug.Log("S8");
            transform.localPosition = new Vector3(xPosition, -549, -10);
        }
        trlRender = GetComponent<TrailRenderer>();
        trlRender.enabled = false;
        clothingUp();
        timeGO.SetActive(false);
    }

    void Update()
    {
        raceTime += Time.deltaTime;
        animator.speed = Mathf.Abs(power.velocity.y);
        if ((circleTurn.transform.localScale.x <= 0.05f) && bttnStart.activeSelf == true)
        {
            greatFloat = circleTurn.transform.localScale.x;
            powerPush = circleTurn.transform.localScale.x * powerPush;
            bttnStart.SetActive(false);
            StartCoroutine(niceStart());
            Debug.Log(greatFloat);
            vignetteAnim.SetTrigger("exit");
            HeartSound.Pause();
            trlRender.enabled = true;
            power.AddForce(new Vector2(0, powerPush / 2), ForceMode2D.Impulse);
            StartCoroutine(swim());
        }
        timerText.text = string.Format("{0:0.00}", raceTime);
    }
    IEnumerator swim()
    {
        yield return new WaitForSeconds(0.1f);
        power.AddForce(new Vector2(0, speedCount * Time.deltaTime * endurance), ForceMode2D.Impulse);
        if(endurance >= 0.6f)
        {
            endurance -= enduranceMinus;
        }
        StartCoroutine(swim());
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "TopCollider")
        {
            Time.timeScale = 0;
            trlRender.enabled = false;
            trlRender1.enabled = false;
            trlRender2.enabled = false;
            trlRender3.enabled = false;
            bttnTurnUp.SetActive(true);
            turnPanel.SetActive(true);
        }

        if (col.tag == "DownCollider" && okSir)
        {
            raceDist--;
            if (raceDist <= 0)
            {
                trlRender.enabled = false;
                position++;
                myPosition = position;
                myTime = raceTime;
                switch (xPosition)
                {
                    case -174:
                        textSwim1.text = myPosition + " Место - " + string.Format("{0:0.00}", myTime);
                        break;
                    case -57:
                        textSwim2.text = myPosition + " Место - " + string.Format("{0:0.00}", myTime);
                        break;
                    case 57:
                        textSwim3.text = myPosition + " Место - " + string.Format("{0:0.00}", myTime);
                        break;
                    case 174:
                        textSwim4.text = myPosition + " Место - " + string.Format("{0:0.00}", myTime);
                        break;
                }
                finalPosition = ((raceNumber * 4) - (4 - myPosition));
                if (finalPosition <= 3)
                {
                    PlayerPrefs.SetInt("raitbool", (int)(((float)12 - (float)PlayerPrefs.GetFloat("speedKrowl")) * 1000) + Random.Range(0, 10));
                    if (PlayerPrefs.GetInt("NoAds") != 1)
                    {
                        Appodeal.show(Appodeal.INTERSTITIAL);
                    }
                }
                if(finalPosition > 3)
                {
                    award.sprite = awardDiplom;
                    positionTXT.text = finalPosition.ToString();
                }
                winnerCoins();
                if (langInt == 2) winnerText.text = "Earned " + winnerGold;
                if (langInt == 1) winnerText.text = "Получено " + winnerGold;
                PlayerPrefs.SetInt("money", PlayerPrefs.GetInt("money") + winnerGold);
                bttnNext.SetActive(true);
            }
            else
            {
                trlRender.enabled = false;
                trlRender1.enabled = false;
                trlRender2.enabled = false;
                trlRender3.enabled = false;
                Time.timeScale = 0;
                turnPanel.SetActive(true);
                bttnTurnDown.SetActive(true);
            }
        }
    }
    public IEnumerator start()
    {
        turnPanel.SetActive(true);
        turnAnim.SetTrigger("start");
        svist = true;
        bttnStart.SetActive(true);
        yield return new WaitForSeconds(0.1f);
        panelChek.SetActive(false);
        HeartSound.Play();
        yield return new WaitForSeconds(2);
        yield return new WaitForSeconds(1f);
        yield return new WaitForSeconds(1);
        AUsource.PlayOneShot(AUstart, 1);
        yield return new WaitForSeconds(1.7f);
        svist = false;
        startOn = true;
        raceTime = 0;
        timeGO.SetActive(true);
        if (PlayerPrefs.GetInt("vibrate") == 1)
        {
            Handheld.Vibrate();
        }
    }

    public void winnerCoins()
    {
        switch (finalPosition)
        {
            case 1:
                award.sprite = awardGold;
                PlayerPrefs.SetInt("countWinGoldCity", PlayerPrefs.GetInt("countWinGoldCity") + 1);
                winnerGold = 200;
                break;
            case 2:
                award.sprite = awardSilver;
                PlayerPrefs.SetInt("countWinSilverCity", PlayerPrefs.GetInt("countWinSilverCity") + 1);
                winnerGold = 100;
                break;
            case 3:
                award.sprite = awardBronze;
                PlayerPrefs.SetInt("countWinBronzeCity", PlayerPrefs.GetInt("countWinBronzeCity") + 1);
                winnerGold = 50;
                break;
            default:
                award.sprite = awardDiplom;
                winnerGold = 25;
                break;

        }
    }

    public void clickNext()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1;
    }
    public void clickNextADS()
    {
        if (Appodeal.canShow(Appodeal.INTERSTITIAL))
        {
            Appodeal.show(Appodeal.INTERSTITIAL);
            PlayerPrefs.SetInt("money", PlayerPrefs.GetInt("money") + winnerGold);
            SceneManager.LoadScene(1);
            Time.timeScale = 1;
        }
        else clickNext();
    }

    public void bttnNextStudy()
    {
        if (studyPos == 2)
        {
            panel_Study.SetActive(false);
            if (dontSay.isOn == true) PlayerPrefs.SetInt("study", 0);
        }
        if (studyPos == 1)
        {
            if (PlayerPrefs.GetString("language") == "rus")
            {
                txtStudy.text = "Лучше сделать старт чуть позже свистка, чем допустить фальстарт";
            }
            else
            {
                txtStudy.text = "Better to make a start later the whistle, than to allow a false start";
            }
            tgglSay.SetActive(true);
            studyPos++;
        }
    }

    public void bttnADS()
    {
        Time.timeScale = 1;
        if (PlayerPrefs.GetInt("NoAds") != 1)
        {
            Appodeal.show(Appodeal.REWARDED_VIDEO);
            if (sceneNumber == 1) PlayerPrefs.SetInt("okdist1", 1);
            if (sceneNumber == 2) PlayerPrefs.SetInt("okdist2", 1);
            if (sceneNumber == 3) PlayerPrefs.SetInt("okdist3", 1);
            if (sceneNumber == 4) PlayerPrefs.SetInt("okdist4", 1);
            SceneManager.LoadScene(1);
        }
        else
        {
            if (sceneNumber == 1) PlayerPrefs.SetInt("okdist1", 0);
            if (sceneNumber == 2) PlayerPrefs.SetInt("okdist2", 0);
            if (sceneNumber == 3) PlayerPrefs.SetInt("okdist3", 0);
            if (sceneNumber == 4) PlayerPrefs.SetInt("okdist4", 0);
            SceneManager.LoadScene(1);
        }
    }
    public void bttnNoADS()
    {
        SceneManager.LoadScene(1);
    }
    public void bttnNextClick()
    {
        trlRender1.enabled = false;
        trlRender2.enabled = false;
        trlRender3.enabled = false;
        panelExit.SetActive(true);
    }
    public void clickOnNextChek()
    {
        if (raceTime > 3)
        {
            raceTime = -5.8f;
            vignetteAnim.SetTrigger("start");
            vignetteAnim.SetTrigger("state");
            StartCoroutine(start());
        }
    }
    public void clothingUp()
    {
        shapochka.color = new Color(PlayerPrefs.GetFloat("colorShapochkaR"), PlayerPrefs.GetFloat("colorShapochkaG"), PlayerPrefs.GetFloat("colorShapochkaB"), PlayerPrefs.GetFloat("colorShapochkaA"));
        plavki_Woomen.color = new Color(PlayerPrefs.GetFloat("colorPlavkiR"), PlayerPrefs.GetFloat("colorPlavkiG"), PlayerPrefs.GetFloat("colorPlavkiB"), PlayerPrefs.GetFloat("colorPlavkiA"));
        plavki.color = new Color(PlayerPrefs.GetFloat("colorPlavkiR"), PlayerPrefs.GetFloat("colorPlavkiG"), PlayerPrefs.GetFloat("colorPlavkiB"), PlayerPrefs.GetFloat("colorPlavkiA"));
        if (PlayerPrefs.GetInt("pol") == 1)
        {
            plavkiW.SetActive(true);
            plavkiM.SetActive(false);
            switch (PlayerPrefs.GetInt("numMeltings"))
            {
                case 1:
                    plavki_Woomen.sprite = melting_Woomen;
                    break;
                case 2:
                    plavki_Woomen.sprite = melting_Woomen;
                    break;
                case 3:
                    plavki_Woomen.sprite = melting_Woomen;
                    break;
                case 4:
                    plavki_Woomen.sprite = melting_1W;
                    break;
                case 5:
                    plavki_Woomen.sprite = melting_2W;
                    break;
                case 6:
                    plavki_Woomen.sprite = melting_3W;
                    break;
            }
        }
        else
        {
            plavkiM.SetActive(true);
            plavkiW.SetActive(false);
            switch (PlayerPrefs.GetInt("numMeltings"))
            {
                case 1:
                    plavki.sprite = melting_Men;
                    break;
                case 2:
                    plavki.sprite = melting_Men;
                    break;
                case 3:
                    plavki.sprite = melting_Men;
                    break;
                case 4:
                    plavki.sprite = melting_1M;
                    break;
                case 5:
                    plavki.sprite = melting_2M;
                    break;
                case 6:
                    plavki.sprite = melting_3M;
                    break;
            }
        }
        switch (PlayerPrefs.GetInt("numShapochka"))
        {
            case 1:
                shapochka.sprite = shapochkaSp;
                break;
            case 2:
                shapochka.sprite = shapochkaSp;
                break;
            case 3:
                shapochka.sprite = shapochkaSp;
                break;
            case 4:
                shapochka.sprite = shapochkaSp_1;
                break;
            case 5:
                shapochka.sprite = shapochkaSp_2;
                break;
            case 6:
                shapochka.sprite = shapochkaSp_3;
                break;
        }
    }

    public void OnApplicationPause()
    {
        if (panelReady.activeSelf == false)
        {
            if (!PlayerPrefs.HasKey("NoAds"))
            {
                Appodeal.show(Appodeal.INTERSTITIAL);
            }
            Time.timeScale = 0;
            panelPause.SetActive(true);
        }
    }

    public void clickContinue()
    {
        panelPause.SetActive(false);
        if (timeSpeedBool == false)
        {
            Time.timeScale = 1;
            timeSpeed.text = "1X";
        }
        if (timeSpeedBool == true)
        {
            Time.timeScale = 2;
            timeSpeed.text = "2X";
        }
    }
    public void clickTurnTop()
    {
        Debug.Log("scale" + circleTurn.transform.localScale.x);
        if (circleTurn.transform.localScale.x <= 1)
        {
            greatFloat = circleTurn.transform.localScale.x;
            powerPush = circleTurn.transform.localScale.x * powerPush;
        }
        if (circleTurn.transform.localScale.x > 1)
        {
            powerPush = (2 - circleTurn.transform.localScale.x) * powerPush;
            greatFloat = 2 - circleTurn.transform.localScale.x;
        }
        Debug.Log(greatFloat);
        if (timeSpeedBool == false)
        {
            Time.timeScale = 1;
            timeSpeed.text = "1X";
        }
        if (timeSpeedBool == true)
        {
            Time.timeScale = 2;
            timeSpeed.text = "2X";
        }
        transform.Rotate(180, 0, 0);
        raceDist--;
        speedCount = -speedCount;
        power.AddForce(new Vector2(0, -powerPush), ForceMode2D.Impulse);
        okSir = true;
        StartCoroutine(afterTurn());
        bttnTurnUp.SetActive(false);
        bttnTurnDown.SetActive(false);
    }
    public void clickTurnDown()
    {
        if (circleTurn.transform.localScale.x <= 1)
        {
            greatFloat = circleTurn.transform.localScale.x;
            powerPush = circleTurn.transform.localScale.x * powerPush;
        }
        if (circleTurn.transform.localScale.x > 1)
        {
            powerPush = (2 - circleTurn.transform.localScale.x) * powerPush;
            greatFloat = 2 - circleTurn.transform.localScale.x;
        }
        Debug.Log(greatFloat);
        if (timeSpeedBool == false)
        {
            Time.timeScale = 1;
            timeSpeed.text = "1X";
        }
        if (timeSpeedBool == true)
        {
            Time.timeScale = 2;
            timeSpeed.text = "2X";
        }
        transform.Rotate(180, 0, 0);
        speedCount = -speedCount;
        power.AddForce(new Vector2(0, powerPush), ForceMode2D.Impulse);
        StartCoroutine(afterTurn());
        bttnTurnUp.SetActive(false);
        bttnTurnDown.SetActive(false);

    }
    public void clickBttnStart()
    {
        if(svist == true)
        {
            bttnStart.SetActive(false);
            StartCoroutine(failStart());
        }
        else
        {
            bttnStart.SetActive(false);
            if (circleTurn.transform.localScale.x <= 1)
            {
                greatFloat = circleTurn.transform.localScale.x;
                powerPush = circleTurn.transform.localScale.x * powerPush;
            }
            if (circleTurn.transform.localScale.x > 1)
            {
                powerPush = (2 - circleTurn.transform.localScale.x) * powerPush;
                greatFloat = 2 - circleTurn.transform.localScale.x;
            }
            StartCoroutine(niceStart());
            Debug.Log(greatFloat);
            vignetteAnim.SetTrigger("exit");
            HeartSound.Pause();
            trlRender.enabled = true;
            power.AddForce(new Vector2(0, powerPush / 2), ForceMode2D.Impulse);
            StartCoroutine(swim());
        }
    }

    public IEnumerator afterTurn()
    {
        greatTxt.color = new Vector4(0.9f, 0.23f, 0.25f, 1);
        if(langInt == 1) greatTxt.text = "МИМО";
        if (langInt == 2) greatTxt.text = "MISS";
        if (greatFloat > 0.3f)
        {
            if (langInt == 1) greatTxt.text = "ХОРОШО";
            if (langInt == 2) greatTxt.text = "GREAT";
            greatTxt.color = new Vector4(0.97f, 0.98f, 0.98f, 1);
        }
        if (greatFloat > 0.6f)
        {
            if (langInt == 1) greatTxt.text = "ОТЛИЧНО!";
            if (langInt == 2) greatTxt.text = "COOL!";
            greatTxt.color = new Vector4(0, 1, 0.78f, 1);
        }
        if (greatFloat > 0.9f)
        {
            if (langInt == 1) greatTxt.text = "БОГОПОДОБНО!";
            if (langInt == 2) greatTxt.text = "GODLIKE!";
            greatTxt.color = new Vector4(1, 0.8f, 0.4f, 1);
        }
        if (raceDist == 1)
        {
            endurance += 0.2f;
        }
        turnAnim.enabled = false;
        greatAnim.SetTrigger("great");
        yield return new WaitForSeconds(1.5f);
        turnPanel.SetActive(false);
        turnAnim.StartPlayback();
        trlRender.enabled = true;
        trlRender1.enabled = true;
        trlRender2.enabled = true;
        trlRender3.enabled = true;
    }
    public IEnumerator failStart()
    {
        greatTxt.color = new Vector4(0.9f, 0.23f, 0.25f, 1);
        greatTxt.text = string.Format("{0:0.000}", raceTime);
        greatAnim.SetTrigger("great");
        yield return new WaitForSeconds(1.5f);
        turnPanel.SetActive(false);
        vignetteAnim.SetTrigger("empty");
        panelRestart.SetActive(true);
    }
    public IEnumerator niceStart()
    {
        greatTxt.color = new Vector4(0.9f, 0.23f, 0.25f, 1);
        Debug.Log(raceTime);
        if (raceTime <= 1)
        {
            greatTxt.color = new Vector4(0.97f, 0.98f, 0.98f, 1);
        }
        if (raceTime <= 0.5f)
        {
            greatTxt.color = new Vector4(0, 1, 0.78f, 1);
        }
        if (raceTime <= 0.2f)
        {
            greatTxt.color = new Vector4(1, 0.8f, 0.4f, 1);
        }
        greatTxt.text = "+" + string.Format("{0:0.000}", raceTime);
        greatAnim.SetTrigger("great");
        yield return new WaitForSeconds(1.5f);
        turnPanel.SetActive(false);
    }

    public void clickOnSpeedTimeBttn()
    {
        if(timeSpeedBool == false)
        {
            timeSpeedBool = true;
            Time.timeScale = 2;
            timeSpeed.text = "2X";
            return;
        }
        if (timeSpeedBool == true)
        {
            timeSpeedBool = false;
            Time.timeScale = 1;
            timeSpeed.text = "1X";
            return;
        }
    }
}