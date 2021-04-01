using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class botScript : MonoBehaviour {

    public Text textSwim1;
    public Text textSwim2;
    public Text textSwim3;
    public Text textSwim4;
    public GameObject plavkiM;
    public GameObject plavkiW;
    public Image plavki_Woomen;
    float plavkiHSV;
    float shapochkaHSV;
    public Image plavki;
    public Image shapochka;
    Animator animator;
    public Rigidbody2D powerFlowing;
    bool why;
    public int myPosition;
    float mySpeed;
    float powerPush;
    int counRace;
    string myName;
    public Text textMyName;
    public Text textPlayer;
    int myRaceDist;
    float myTime;
    TrailRenderer trlRender;
    float timeDelay;
    float endurance;
    float enduranceMinus;

    void Awake()
    {
        myRaceDist = 0;
        myTime = 0;
        if (PlayerPrefs.GetInt("pol") == 1)
        {
            if (PlayerPrefs.GetString("language") == "rus")
            {
                myName = Main.surnameBotWoomen[Random.Range(0, Main.surnameBotWoomen.Length)] + " " + Main.namesBotWoomen[Random.Range(0, Main.namesBotWoomen.Length)];
            }
            else
            {
                myName = Main.surnameBotWoomenEng[Random.Range(0, Main.surnameBotWoomenEng.Length)] + " " + Main.namesBotWoomenEng[Random.Range(0, Main.namesBotWoomenEng.Length)];
            }
        }
        else
        {
            if (PlayerPrefs.GetString("language") == "rus")
            {
                myName = Main.surnameBotMan[Random.Range(0, Main.surnameBotMan.Length)] + " " + Main.namesBotMan[Random.Range(0, Main.namesBotMan.Length)];
            }
            else
            {
                myName = Main.surnameBotManEng[Random.Range(0, Main.surnameBotManEng.Length)] + " " + Main.namesBotManEng[Random.Range(0, Main.namesBotManEng.Length)];
            }
        }
    }

    void Start () {
        endurance = 1;
        shapochkaHSV = (float)Random.Range(0, 1000) / (float)1000;
        plavkiHSV = (float)Random.Range(0, 1000) / (float)1000;
        shapochka.color = Color.HSVToRGB(shapochkaHSV, 0.65f, 1);
        plavki.color = Color.HSVToRGB(plavkiHSV, 0.65f, 1);
        animator = GetComponent<Animator>();
        trlRender = GetComponent<TrailRenderer>();
        animator.SetBool(player_script.anim_stile, true);
        trlRender.enabled = false;
        myRaceDist = player_script.raceDist;
        counRace = 0;
        why = true;
        switch (myPosition)
        {
            case -174:
                mySpeed = player_script.bot_1;
                timeDelay = player_script.timeDelayBot_4;
                break;
            case -57:
                mySpeed = player_script.bot_2;
                timeDelay = player_script.timeDelayBot_3;
                break;
            case 57:
                mySpeed = player_script.bot_3;
                timeDelay = player_script.timeDelayBot_2;
                break;
            case 174:
                mySpeed = player_script.bot_4;
                timeDelay = player_script.timeDelayBot_1;
                break;
        }
        powerPush = mySpeed;
        //mySpeed = player_script.speedCount * Random.Range(90, 110) / 100;
        enduranceMinus = 0.001f;
        if (player_script.xPosition == myPosition)
        {
            transform.localPosition = new Vector3(57, transform.localPosition.y, -10);
            textPlayer.text = myName;
            myPosition = 57;
        }
        else
        {
            textMyName.text = myName;
        }
        plavki_Woomen.color = Color.HSVToRGB(plavkiHSV, 0.65f, 1);
        plavki.color = Color.HSVToRGB(plavkiHSV, 0.65f, 1);
        if (PlayerPrefs.GetInt("pol") == 1)
        {
            plavkiW.SetActive(true);
            plavkiM.SetActive(false);
        }
        else
        {
            plavkiM.SetActive(true);
            plavkiW.SetActive(false);
        }
    }

	void Update () {
        animator.speed = Mathf.Abs(powerFlowing.velocity.y);
        if (player_script.startOn && why)
        {
            StartCoroutine(strtCour());
            why = false;
        }
    }

    IEnumerator swim()
    {
        yield return new WaitForSeconds(0.1f);
        powerFlowing.AddForce(new Vector2(0, mySpeed * Time.deltaTime * endurance), ForceMode2D.Impulse);
        if(endurance > 0.6f)
        {
            endurance -= enduranceMinus;
        }
        StartCoroutine(swim());
    }

    IEnumerator strtCour()
    {
        yield return new WaitForSeconds(timeDelay);
        trlRender.enabled = true;
        StartCoroutine(swim());
        powerFlowing.AddForce(new Vector2(0, powerPush / 2), ForceMode2D.Impulse);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "TopCollider")
        {
            myRaceDist--;
            transform.Rotate(180, 0, 0);
            counRace++;
            mySpeed = -mySpeed;
            powerFlowing.AddForce(new Vector2(0, -powerPush * ((Random.Range(85, 100)) / 100)), ForceMode2D.Impulse);
            if (myRaceDist == 1)
            {
                endurance += 0.2f;
            }
        }

        if (col.tag == "DownCollider" && counRace > 0)
        {
            myRaceDist--;
            if (myRaceDist <= 0)
            {
                myTime = player_script.raceTime;
                player_script.position++;
                switch (myPosition)
                {
                    case -174:
                        textSwim1.text = player_script.position + " Место - " + string.Format("{0:0.00}", myTime);
                        break;
                    case -57:
                        textSwim2.text = player_script.position + " Место - " + string.Format("{0:0.00}", myTime);
                        break;
                    case 57:
                        textSwim3.text = player_script.position + " Место - " + string.Format("{0:0.00}", myTime);
                        break;
                    case 174:
                        textSwim4.text = player_script.position + " Место - " + string.Format("{0:0.00}", myTime);
                        break;
                }
                trlRender.enabled = false;
            }
            else
            {
                counRace++;
                transform.Rotate(180, 0, 0);
                mySpeed = -mySpeed;
                powerFlowing.AddForce(new Vector2(0, powerPush * ((Random.Range(85, 100)) / 100)), ForceMode2D.Impulse);
            }
        }
    }
}
