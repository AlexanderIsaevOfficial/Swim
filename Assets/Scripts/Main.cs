using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
using AppodealAds.Unity.Api;
using AppodealAds.Unity.Common;

public class Main : MonoBehaviour {

    public GameObject panel_GDPR;
    public Text[] txtHome;
    public Text[] txtStudy;
    int trainerStatic;
    public int trainerPrice;
    public int dayCooount;
    public Sprite[] trainersArray;
    public GameObject trainPanel;
    public Text trainDescription;
    public Image trainImg;
    public Text trainName;
    public Text trainAbone;
    public Text trainPrice;
    public Text trainCountTxt;
    public GameObject blockWave;
    public Text wavesTxt;
    public Animator wavesAnim;
    public GameObject panelLoose;
    public GameObject panelWin;
    public GameObject bttnQnext;
    public Button[] bttns;
    int questionCount;
    public GameObject[] questionGO;
    public Text langTxtVstuplenie;
    public GameObject dayFor_1;
    public GameObject dayFor_2;
    public GameObject dayFor_3;
    public GameObject dayFor_4;
    public Text dayForCity;
    public Text dayForObl;
    public Text dayForEurope;
    public Text dayForOlimp;
    public string distanceOriginal;
    public int numRand;
    public string[] distArray;
    public GameObject[] glassHeh;
    Color colorGlassOfficial;
    public static Color glassColor;
    public static int glassNumber;
    public Text langTxtMusic;
    public AudioSource audioClip;
    public Toggle tgglSound;
    public Color orangeClr;
    public Color greenClr;
    public Color redClr;
    public Image colorNotification;
    public Image iznosPlavkiColor;
    public Image iznosGlassColor;
    public static float iznos;
    public Image iznosPlavki;
    public Image iznosShapochka;
    public Image iznosGlass;
    public GameObject[] trunksHeh;
    public Image[] glassesImage;
    bool adsBool;
    public Text langTxtShop;
    public Text langTxtAnimSnow;
    public Text langTxtTrain;
    public Text langTxtRest;
    public Text[] langTxtSoft;
    public Text[] langTxtMedium;
    public Text[] langTxtHard;
    public Text countWinCityGold;
    public Text countWinCitySilver;
    public Text countWinCityBronze;
    public Text countWinOblGold;
    public Text countWinOblSilver;
    public Text countWinOblBronze;
    public Text countWinVillGold;
    public Text countWinVillSilver;
    public Text countWinVillBronze;
    public Text langTxtHeader_1;
    public Text langTxtHeader_2;
    public Text langTxtName;
    public Text langTxtSurname;
    public Text langTxtMainStile;
    public Text langTxtNext;
    public Text langTxtNextEnter;
    public GameObject dropdownRus;
    public GameObject dropdownEng;
    public GameObject panelRating;
    public Toggle tgglAnim;
    public static int snowCount;
    public GameObject panelSnow;
    public GameObject snowPrefab;
    public static int shOrCop;
    public static int numberShapochka;
    public static Color colorShapochka;
    public GameObject clrSliderGO;
    public Sprite melting_1W;
    public Sprite melting_2W;
    public Sprite melting_3W;
    public Sprite melting_4W;
    public Sprite melting_5W;
    public Sprite melting_1M;
    public Sprite melting_2M;
    public Sprite melting_3M;
    public Sprite melting_4M;
    public Sprite melting_5M;
    public Sprite Shapochka_1M;
    public Sprite Shapochka_2M;
    public Sprite Shapochka_3M;
    public Sprite Shapochka_4M;
    public Sprite Shapochka_5M;
    public Sprite melting_Men;
    public Sprite melting_Woomen;
    int coinsDifference;
    int debugCoinsNum;
    int coinsNum;
    Color colorMeltingofficial;
    Color colorShapochkaofficial;
    public GameObject panelBuy;
    public static Color colorMelting;
    public static int costMelting;
    public static int numberMelting;
    public Image scrollCondition;
    public Text txtSorevVill_1;
    public Text txtSorevVill_2;
    public Text txtSorevVill_3;
    public Text txtSorevVill_4;
    public Toggle tgglSorevVill_1;
    public Toggle tgglSorevVill_2;
    public Toggle tgglSorevVill_3;
    public Toggle tgglSorevVill_4;
    public Text txtSorevObl_1;
    public Text txtSorevObl_2;
    public Text txtSorevObl_3;
    public Text txtSorevObl_4;
    public Text txtSorevObl_5;
    public Text txtSorevObl_6;
    public Toggle tgglSorevObl_1;
    public Toggle tgglSorevObl_2;
    public Toggle tgglSorevObl_3;
    public Toggle tgglSorevObl_4;
    public Toggle tgglSorevObl_5;
    public Toggle tgglSorevObl_6;
    public GameObject panelSorev_1;
    public GameObject panelSorev_2;
    public GameObject panelSorev_3;
    public GameObject panelWhat;
    public GameObject panelWhat2;
    public Text day_save;
    public Text bonusField;
    int roomNumber;
    public Text diamodsTxt;
    public Text resttxt;
    public Text settingstxt;
    public Text vibratetxt;
    public Text languagetxt;
    public GameObject[] roomNum;
    public GameObject[] roomNumBuy;
    public GameObject panelInfoCoders;
    public Image shapochkaTrain_1;
    public Image shapochkaTrain_2;
    public Image shapochkaTrain_3;
    public Image shapochkaTrain_4;
    public Image shapochkaTrain_5;
    public Image shapochkaTrain_6;
    public Image shapochkaTrain_7;
    public Image shapochkaTrain_8;
    public Image shapochkaTrain_9;
    public Image shapochkaTrain_10;
    public Text notif_Text;
    public Animator notifAnimator;
    public Text ineend_1;
    public Text ineend_2;
    public Text ineend_3;
    public GameObject checkSwimmingPool_1;
    public GameObject checkSwimmingPool_2;
    public GameObject checkSwimmingPool_3;
    public GameObject checkSwimmingPool_4;
    public GameObject lockImage_1;
    public GameObject lockImage_2;
    public GameObject lockImage_3;
    public int SwPoolBttn;
    float NumColor;
    float NumColorSh;
    public Sprite plavkiM;
    public Sprite plavkiW;
    public Sprite Shapocka;
    public Image imgPlavki;
    public Text txtBuyMainName;
    public Text txtBuySet;
    public Text txtCoins;
    public GameObject buyPanel;
    public Image imgW;
    public Image imgM;
    public Image plavkiColor;
    public Image plavkiColorW;
    public GameObject plavkiWoomen;
    public GameObject plavkiMen;
    public GameObject Men;
    public GameObject Woomen;
    public Text bttnQ1;
    public Text bttnQ2;
    public Text bttnQ3;
    public GameObject panelKvest;
    public Text txtQuestion;
    public Image shapochkaColor;
    public GameObject swimmingPool;
    public GameObject trainers;
    public Button swimmingPoolBttn;
    public Button trainersBttn;
    public GameObject bttnAds;
    public GameObject panel_Prefs;
    public GameObject panel_Main;
    public Text name_text;
    public Text day_text;
    public GameObject panel1;
    public GameObject panel2;
    public GameObject panel3;
    public GameObject panel4;
    public GameObject panel5;
    public Image home_bttn;
    public Toggle tggl1;
    public Toggle tggl2;
    public Toggle tggl3;
    public Toggle tggl4;
    public Toggle tgglVibrate;
    public Text txtstill1;
    public Text txtstill2;
    public Text txtstill3;
    public Text txtstill4;
    public GameObject panelSwimRef;
    public GameObject[] ticks;
    public Text ratingTxt;
    public Text debugMoney;
    int dayNumber;
    int still;
    string stillStr;
    int dist;
    public GameObject errText;
    string distStr;
    public Text textServer;
    public GameObject panelRate;
    int randKvest;
    float conditionFloat;
    public static string[] namesBotMan = { "Александр", "Михаил", "Ярослав", "Кирилл", "Егор", "Николай", "Павел", "Алексей", "Илья", "Никита", "Данил", "Василий", "Дмитрий", "Владислав", "Роман" };
    public static string[] surnameBotMan = { "Исаев", "Бурутин", "Крылов", "Щавелев", "Волков", "Глазов", "Беляков", "Галанов", "Ковтонюк", "Пшеничкин", "Березенцев", "Гаврилов", "Голубев", "Мосолов", "Кондратский"};
    public static string[] namesBotWoomen = { "Варя", "Анастасия", "Снежана", "Василиса", "Александра", "Полина", "Юлия", "Алина", "Ульяна", "Алена", "Лиза", "Елена", "Наталия" };
    public static string[] surnameBotWoomen = { "Борискова", "Ратникова", "Амелина", "Исаева", "Волкова", "Щавелева", "Гаврилова", "Крылова", "Бурутина", "Березенцева", "Пшеничкина", "Галанова", "Корнилова" };
    public static string[] namesBotManEng = { "Alexander", "Michael", "Noah", "Liam", "Mason", "Jacob", "William", "Ethan", "James", "Daniel", "Elijah", "benjamin", "Logan" };
    public static string[] surnameBotManEng = { "Isayev", "Burutin;", "Smith ", "Johnson", "Williams", "Brown", "Whites", "Miller", "Kovtonyuk", "Thompson", "Harris", "Gavrilov", "Taylor" };
    public static string[] namesBotWoomenEng = { "Emma", "Olivia", "Sophia", "Isabella", "Ava", "Mia", "Emily", "Abigail", "Madison", "Charlotte", "Harper", "Sofia", "Avery" };
    public static string[] surnameBotWoomenEng = { "Boriskova", "Smith ", "Johnson", "Williams", "Volkov", "Brown", "Gavrilov", "Krylov", "Miller", "Moore", "Harris", "Martin" };
    public static string[] kvestQuestions = { "Имя Фелпса на русском?", "Что такое пол-тос?", "10x100 батт?", "Спинист?", "Хочешь МС?", "Этот вопрос мы ещё не придумали" };
    public static string[] kvestQuestionsbttn1 = { "Михаил", "500", "1000", "да", "Конечно!", "Бывает" };
    public static string[] kvestQuestionsbttn2 = { "Максим", "5000", "нет", "нет", "Да", "Посмотреть рекламу" };
    public static string[] kvestQuestionsbttn3 = { "Моисей", "50", "да", "не уверен", "МСМК!", "Посмотреть крутую рекламу" };

    private void initializeADS()
    {
        string appKey = "ec48825adf01ddb91bf0e2c1ceaf1b6b7e5f9c5f0b08c8a8";
        Appodeal.disableLocationPermissionCheck();
        Appodeal.initialize(appKey, Appodeal.INTERSTITIAL | Appodeal.REWARDED_VIDEO);
    }

    void Awake() {
        if (PlayerPrefs.HasKey("win"))
        {
            PlayerPrefs.DeleteKey("win");
            panelWin.SetActive(true);
        }
        if (PlayerPrefs.GetInt("q") == 0)
        {
            question();
        }
        distArray = new string[36];
        adsBool = false;
        if (PlayerPrefs.GetInt("vibrate") == 1)
        {
            tgglVibrate.isOn = true;
        }
        else tgglVibrate.isOn = false;
        if (PlayerPrefs.GetInt("snowAnim") == 1)
        {
            tgglAnim.isOn = true;
        }
        else tgglAnim.isOn = false;
        if (PlayerPrefs.GetInt("sound") == 1)
        {
            tgglSound.isOn = true;
            audioClip.volume = 0.3f;
        }
        else
        {
            tgglSound.isOn = false;
            audioClip.volume = 0;
        }
        panel_Prefs.SetActive(false);
        imgM.color = new Vector4(0.19f, 0.66f, 0.87f, 1);
        imgW.color = new Vector4(0.11f, 0.74f, 0.61f, 1);
        setDay();
        panelSwimRef.SetActive(false);
        if (!PlayerPrefs.HasKey("firstPlay"))
        {
            panel_Prefs.SetActive(true);
            panel_GDPR.SetActive(true);
        }
        else
        {
            panel_GDPR.SetActive(false);
            panel_Prefs.SetActive(false);
            panel_Main.SetActive(true);
        }
        panel1.SetActive(false);
        panel2.SetActive(false);
        panel3.SetActive(true);
        panel4.SetActive(false);
        panel5.SetActive(false);
        /**
        switch (PlayerPrefs.GetString("still"))
        {
            case "Krowl":
                still_text.text = "Кролист";
                break;
            case "Bat":
                still_text.text = "Баттист";
                break;
            case "Spin":
                still_text.text = "Спинист";
                break;
            case "Brass":
                still_text.text = "Брассист";
                break;
        }
        */
        name_text.text = (PlayerPrefs.GetString("secName") + " " + PlayerPrefs.GetString("Name"));
        home_bttn.color = new Vector4(0.176f, 0.243f, 0.313f, 1);
        foreach (GameObject tick in ticks)
        {
            tick.SetActive(false);
        }
        debugCoinsNum = PlayerPrefs.GetInt("money");
        debugMoney.text = PlayerPrefs.GetInt("money").ToString();
        errText.SetActive(false);
        //ticks[PlayerPrefs.GetInt("trainer") - 1].SetActive(true);
        if (PlayerPrefs.HasKey("raitbool"))
        {
            panelRating.SetActive(true);
            ratingTxt.text = PlayerPrefs.GetInt("raitbool").ToString();
        }
    }


    public static string[] languageMenuRus = { "НАСТРОЙКИ", "Вибрация при старте", "НАЧАТЬ ЗАНОВО", "Добро пожаловать в SWIM!", "Создайте виртуального пловца", "Имя", "Фамилия", "Предрасположенность", "Продолжить", "ЛЁГКАЯ", "СРЕДНЯЯ", "ТЯЖЁЛАЯ", "Анимация снега", "ТРЕНИРОВКИ", "ОТДЫХ", "МАГАЗИН", "Музыка в меню", "НАСТРОЙКИ", "ТРЕНИРОВКИ", "ДОМ", "МАГАЗИН", "ТРЕНЕР", "МОНЕТЫ", "КАПЕЛЬКИ", "РЕЙТИНГ", "ЗАПАС СИЛ", "ДЕНЬ НЕДЕЛИ", "Нажми для продолжения", "Это твой дом, здесь отображается основная информация - достижения, внешний вид и т.д.", "Магазин - покупай что хочешь и когда хочешь", "Большую часть времени пловец проводит здесь - на тренировках", "Сочетайте сложности тренировок и отдых, чтобы добиться лучшего результата. Старайтесь восстановить силы к соревнованиям", "1 клик - 1 день", "кол-во дней до соревнований", "Здесь - твоя свобода выбора", "Выбери тренера и бассейн под себя, у всего свои плюсы и минусы", "Следуй мечте", "АБОНЕМЕНТ", "БАССЕЙН", "Бесплатные", "Отключить рекламу", "Состояние экипировки", "ГОРОД", "РЕГИОН", "ОЛИМПИАДА", "ДОСТИЖЕНИЯ" };
    public static string[] languageMenuEng = { "SETTINGS", "Vibration at the start", "START OVER", "Welcome to SWIM!", "Create a virtual swimmer", "Name", "Surname", "Ability", "Continue", "EASY", "MEDIUM", "HARD", "Animation of snow", "WORKOUTS", "REST", "SHOP", "Music in menu", "SETTINGS", "TRAINING", "HOUSE", "SHOP", "COACH", "COINS", "DROPLETS", "RATING", "STAMINA", "DAY OF THE WEEK", "Click to continue", "This is your home, the main information is displayed here-achievements, appearance, etc.", "Shop-buy what you want and when you want", "Most of the time a swimmer spends in training", "Combine the difficulty of training and rest to achieve the best result. Try to restore strength to the competition", "1 click - 1 day", "number of days before the event", "Here is your freedom of choice", "Choose a coach and a pool for yourself, all have their pros and cons", "Follow the dream", "SEASON TICKET", "POOL", "Free", "Disable ads", "The condition of your equipment", "CITY", "REGION", "OLYMPIAD", "PROGRESS" };
    public static string[] languageMenuALL;


    public void clickOnDeny()
    {
        Application.Quit();
        Debug.Log("Deny");
    }
    public void clickOnAccept()
    {
        panel_GDPR.SetActive(false);
        Debug.Log("Accept");
    }

    public void clickOnWebGDPR()
    {
        Application.OpenURL("https://www.appodeal.com/home/privacy-policy/");
    }
    public void setLang()
    {
        PlayerPrefs.SetString("language", "rus");
        if (PlayerPrefs.GetString("language") == "rus")
        {
            languageMenuALL = languageMenuRus;
            dropdownRus.SetActive(true);
            dropdownEng.SetActive(false);
        }
        if (PlayerPrefs.GetString("language") == "eng")
        {
            languageMenuALL = languageMenuEng;
            dropdownRus.SetActive(false);
            dropdownEng.SetActive(true);
        }
        settingstxt.text = languageMenuALL[0];
        vibratetxt.text = languageMenuALL[1];
        resttxt.text = languageMenuALL[2];
        langTxtHeader_1.text = languageMenuALL[3];
        langTxtHeader_2.text = languageMenuALL[4];
        langTxtName.text = languageMenuALL[5];
        langTxtSurname.text = languageMenuALL[6];
        langTxtMainStile.text = languageMenuALL[7];
        langTxtNext.text = languageMenuALL[8];
        foreach (Text txtSoft in langTxtSoft)
        {
            txtSoft.text = languageMenuALL[9];
        }
        foreach (Text txtMedium in langTxtMedium)
        {
            txtMedium.text = languageMenuALL[10];
        }
        foreach (Text txtHard in langTxtHard)
        {
            txtHard.text = languageMenuALL[11];
        }
        langTxtAnimSnow.text = languageMenuALL[12];
        langTxtTrain.text = languageMenuALL[13];
        langTxtRest.text = languageMenuALL[14];
        langTxtShop.text = languageMenuALL[15];
        langTxtMusic.text = languageMenuALL[16];
        txtStudy[0].text = languageMenuALL[17];
        txtStudy[1].text = languageMenuALL[18];
        txtStudy[2].text = languageMenuALL[19];
        txtStudy[3].text = languageMenuALL[20];
        txtStudy[4].text = languageMenuALL[21];
        txtStudy[5].text = languageMenuALL[22];
        txtStudy[6].text = languageMenuALL[23];
        txtStudy[7].text = languageMenuALL[24];
        txtStudy[8].text = languageMenuALL[25];
        txtStudy[9].text = languageMenuALL[26];
        txtStudy[10].text = languageMenuALL[27];
        txtStudy[11].text = languageMenuALL[28];
        txtStudy[12].text = languageMenuALL[29];
        txtStudy[13].text = languageMenuALL[30];
        txtStudy[14].text = languageMenuALL[31];
        txtStudy[15].text = languageMenuALL[32];
        txtStudy[16].text = languageMenuALL[33];
        txtStudy[17].text = languageMenuALL[34];
        txtStudy[18].text = languageMenuALL[35];
        txtStudy[19].text = languageMenuALL[36];
        txtStudy[20].text = languageMenuALL[38];
        txtStudy[21].text = languageMenuALL[37];
        txtStudy[22].text = languageMenuALL[39];
        txtStudy[23].text = languageMenuALL[40];
        txtHome[0].text = languageMenuALL[41];
        txtHome[1].text = languageMenuALL[42];
        txtHome[2].text = languageMenuALL[43];
        txtHome[3].text = languageMenuALL[44];
        txtHome[4].text = languageMenuALL[45];
    }

    public void onToggleChanged()
    {
        if (tgglAnim.isOn == true)
        {
            StartCoroutine(snowGenerator());
        }
        if (tgglAnim.isOn == false)
        {
            StopCoroutine(snowGenerator());
        }
    }
    public void onToggleSoundChanged()
    {
        if (tgglSound.isOn == true)
        {
            audioClip.volume = 0.3f;
        }
        if (tgglSound.isOn == false)
        {
            audioClip.volume = 0;
        }
    }

    void Start()
    {
        coinsSet();
        trainCountTxt.text = PlayerPrefs.GetInt("trainerCount").ToString();
        initializeADS();
        setDayFor();
        //PlayerPrefs.SetInt("NoAds", 0);
        setAwardsStat();
        setLang();
        setIznos();
        snowCount = 0;
        numberMelting = PlayerPrefs.GetInt("numMeltings");
        numberShapochka = PlayerPrefs.GetInt("numShapochka");
        colorShapochkaofficial = new Color(PlayerPrefs.GetFloat("colorShapochkaR"), PlayerPrefs.GetFloat("colorShapochkaG"), PlayerPrefs.GetFloat("colorShapochkaB"), PlayerPrefs.GetFloat("colorShapochkaA"));
        colorMeltingofficial = new Color(PlayerPrefs.GetFloat("colorPlavkiR"), PlayerPrefs.GetFloat("colorPlavkiG"), PlayerPrefs.GetFloat("colorPlavkiB"), PlayerPrefs.GetFloat("colorPlavkiA"));
        colorGlassOfficial = new Color(PlayerPrefs.GetFloat("colorGlassR"), PlayerPrefs.GetFloat("colorGlassG"), PlayerPrefs.GetFloat("colorGlassB"), PlayerPrefs.GetFloat("colorGlassA"));
        setColor();
        scrollCondition.fillAmount = PlayerPrefs.GetFloat("condition");
        scrollCondition.color = Color.HSVToRGB(PlayerPrefs.GetFloat("condition") / 2.14f, 0.91f, 1);
        day_save.text = PlayerPrefs.GetInt("SaveDay").ToString() + " День";
        PlayerPrefs.SetInt("roomNum", 0);
        roomNum[PlayerPrefs.GetInt("roomNum")].SetActive(true);
        roomNumber = PlayerPrefs.GetInt("roomNum");
        checkSwimmingPool_1.SetActive(false);
        checkSwimmingPool_2.SetActive(false);
        checkSwimmingPool_3.SetActive(false);
        checkSwimmingPool_4.SetActive(false);
        ineend_1.text = (PlayerPrefs.GetInt("day") + "/30");
        ineend_2.text = (PlayerPrefs.GetInt("day") + "/100");
        ineend_3.text = (PlayerPrefs.GetInt("day") + "/300");
        if (PlayerPrefs.GetInt("SwimmingPool") == 1)
        {
            checkSwimmingPool_1.SetActive(true);
        }
        if (PlayerPrefs.GetInt("SwimmingPool") == 2)
        {
            checkSwimmingPool_2.SetActive(true);
        }
        if (PlayerPrefs.GetInt("SwimmingPool") == 3)
        {
            checkSwimmingPool_3.SetActive(true);
        }
        if (PlayerPrefs.GetInt("SwimmingPool") == 4)
        {
            checkSwimmingPool_4.SetActive(true);
        }
        lockImage_1.SetActive(true);
        lockImage_2.SetActive(true);
        lockImage_3.SetActive(true);
        if (PlayerPrefs.GetInt("rank") >= 2)
        {
            lockImage_1.SetActive(false);
            if (PlayerPrefs.GetInt("rank") >= 3)
            {
                lockImage_2.SetActive(false);
                if (PlayerPrefs.GetInt("rank") >= 4)
                {
                    lockImage_3.SetActive(false);
                }
            }
        }
        if (PlayerPrefs.GetInt("pol") == 1)
        {
            Woomen.SetActive(true);
            Men.SetActive(false);
            plavkiMen.SetActive(false);
            plavkiWoomen.SetActive(true);
        }
        else
        {
            Woomen.SetActive(false);
            Men.SetActive(true);
            plavkiMen.SetActive(true);
            plavkiWoomen.SetActive(false);
        }
        if (PlayerPrefs.GetInt("NoAds") == 1)
        {
            bttnAds.SetActive(false);
        }
        trainApp();
    }

    void OnApplicationPause()
    {
        if (tgglVibrate.isOn == true) PlayerPrefs.SetInt("vibrate", 1);
        else PlayerPrefs.SetInt("vibrate", 0);
        if (tgglAnim.isOn == true) PlayerPrefs.SetInt("snowAnim", 1);
        else PlayerPrefs.SetInt("snowAnim", 0);
        if (tgglSound.isOn == true) PlayerPrefs.SetInt("sound", 1);
        else PlayerPrefs.SetInt("sound", 0);
    }

    public void Cooldown()
    {
        PlayerPrefs.DeleteKey("firstPlay");
        panel_Prefs.SetActive(true);
        panel_Main.SetActive(false);
        name_text.text = (PlayerPrefs.GetString("secName") + " " + PlayerPrefs.GetString("Name"));
    }

    public void bttnTrainKrowlSoft()
    {
        if (checkByCondition(0.05f) && checkByIznos() && checkByTrainer())
        {
            PlayerPrefs.SetInt("day", PlayerPrefs.GetInt("day") + 1);
            PlayerPrefs.SetFloat("speedKrowl", PlayerPrefs.GetFloat("speedKrowl") + PlayerPrefs.GetFloat("upTrainKrowl") / 4);
            PlayerPrefs.SetFloat("condition", PlayerPrefs.GetFloat("condition") - 0.05f);
            conditionEnter();
            setDay();
            TrainSetup();
            trainApp();
            setIznosValue(1);
        }
    }
    public void bttnTrainKrowlMedium()
    {
        if (checkByCondition(0.1f) && checkByIznos() && checkByTrainer())
        {
            PlayerPrefs.SetInt("day", PlayerPrefs.GetInt("day") + 1);
            PlayerPrefs.SetFloat("speedKrowl", PlayerPrefs.GetFloat("speedKrowl") + PlayerPrefs.GetFloat("upTrainKrowl") / 2);
            PlayerPrefs.SetFloat("condition", PlayerPrefs.GetFloat("condition") - 0.1f);
            conditionEnter();
            setDay();
            TrainSetup();
            trainApp();
            setIznosValue(2);
        }
    }
    public void bttnTrainKrowlHard()
    {
        if (checkByCondition(0.2f) && checkByIznos() && checkByTrainer())
        {

            PlayerPrefs.SetInt("day", PlayerPrefs.GetInt("day") + 1);
            PlayerPrefs.SetFloat("speedKrowl", PlayerPrefs.GetFloat("speedKrowl") + PlayerPrefs.GetFloat("upTrainKrowl"));
            PlayerPrefs.SetFloat("condition", PlayerPrefs.GetFloat("condition") - 0.2f);
            conditionEnter();
            setDay();
            TrainSetup();
            trainApp();
            setIznosValue(4);
        }
    }
    public void bttnTrainBrassSoft()
    {
        if (checkByCondition(0.05f) && checkByIznos() && checkByTrainer())
        {
            PlayerPrefs.SetInt("day", PlayerPrefs.GetInt("day") + 1);
            PlayerPrefs.SetFloat("speedBrass", PlayerPrefs.GetFloat("speedBrass") + PlayerPrefs.GetFloat("upTrainBrass") / 4);
            PlayerPrefs.SetFloat("condition", PlayerPrefs.GetFloat("condition") - 0.05f);
            conditionEnter();
            setDay();
            TrainSetup();
            trainApp();
            setIznosValue(1);
        }
    }
    public void bttnTrainBrassMedium()
    {
        if (checkByCondition(0.1f) && checkByIznos() && checkByTrainer())
        {
            PlayerPrefs.SetInt("day", PlayerPrefs.GetInt("day") + 1);
            PlayerPrefs.SetFloat("speedBrass", PlayerPrefs.GetFloat("speedBrass") + PlayerPrefs.GetFloat("upTrainBrass") / 2);
            PlayerPrefs.SetFloat("condition", PlayerPrefs.GetFloat("condition") - 0.1f);
            conditionEnter();
            setDay();
            TrainSetup();
            trainApp();
            setIznosValue(2);
        }
    }
    public void bttnTrainBrassHard()
    {
        if (checkByCondition(0.2f) && checkByIznos() && checkByTrainer())
        {
            PlayerPrefs.SetInt("day", PlayerPrefs.GetInt("day") + 1);
            PlayerPrefs.SetFloat("speedBrass", PlayerPrefs.GetFloat("speedBrass") + PlayerPrefs.GetFloat("upTrainBrass"));
            PlayerPrefs.SetFloat("condition", PlayerPrefs.GetFloat("condition") - 0.2f);
            conditionEnter();
            setDay();
            TrainSetup();
            trainApp();
            setIznosValue(4);
        }
    }
    public void bttnTrainSpinSoft()
    {
        if (checkByCondition(0.05f) && checkByIznos() && checkByTrainer())
        {
            PlayerPrefs.SetInt("day", PlayerPrefs.GetInt("day") + 1);
            PlayerPrefs.SetFloat("speedSpina", PlayerPrefs.GetFloat("speedSpina") + PlayerPrefs.GetFloat("upTrainSpina") / 4);
            PlayerPrefs.SetFloat("condition", PlayerPrefs.GetFloat("condition") - 0.05f);
            conditionEnter();
            setDay();
            TrainSetup();
            trainApp();
            setIznosValue(1);
        }
    }
    public void bttnTrainSpinMedium()
    {
        if (checkByCondition(0.1f) && checkByIznos() && checkByTrainer())
        {
            PlayerPrefs.SetInt("day", PlayerPrefs.GetInt("day") + 1);
            PlayerPrefs.SetFloat("speedSpina", PlayerPrefs.GetFloat("speedSpina") + PlayerPrefs.GetFloat("upTrainSpina") / 2);
            PlayerPrefs.SetFloat("condition", PlayerPrefs.GetFloat("condition") - 0.1f);
            conditionEnter();
            setDay();
            TrainSetup();
            trainApp();
            setIznosValue(2);
        }
    }
    public void bttnTrainSpinHard()
    {
        if (checkByCondition(0.2f) && checkByIznos() && checkByTrainer())
        {
            PlayerPrefs.SetInt("day", PlayerPrefs.GetInt("day") + 1);
            PlayerPrefs.SetFloat("speedSpina", PlayerPrefs.GetFloat("speedSpina") + PlayerPrefs.GetFloat("upTrainSpina"));
            PlayerPrefs.SetFloat("condition", PlayerPrefs.GetFloat("condition") - 0.2f);
            conditionEnter();
            setDay();
            TrainSetup();
            trainApp();
            setIznosValue(4);
        }
    }
    public void bttnTrainBatSoft()
    {
        if  (checkByCondition(0.05f) && checkByIznos() && checkByTrainer())
        {
            PlayerPrefs.SetInt("day", PlayerPrefs.GetInt("day") + 1);
            PlayerPrefs.SetFloat("speedBat", PlayerPrefs.GetFloat("speedBat") + PlayerPrefs.GetFloat("upTrainBat") / 4);
            PlayerPrefs.SetFloat("condition", PlayerPrefs.GetFloat("condition") - 0.05f);
            conditionEnter();
            setDay();
            TrainSetup();
            trainApp();
            setIznosValue(1);
        }
    }
    public void bttnTrainBatMedium()
    {
        if (checkByCondition(0.1f) && checkByIznos() && checkByTrainer())
        {
            PlayerPrefs.SetInt("day", PlayerPrefs.GetInt("day") + 1);
            PlayerPrefs.SetFloat("speedBat", PlayerPrefs.GetFloat("speedBat") + PlayerPrefs.GetFloat("upTrainBat") / 2);
            PlayerPrefs.SetFloat("condition", PlayerPrefs.GetFloat("condition") - 0.1f);
            conditionEnter();
            setDay();
            TrainSetup();
            trainApp();
            setIznosValue(2);
        }
    }
    public void bttnTrainBatHard()
    {
        if (checkByCondition(0.2f) && checkByIznos() && checkByTrainer())
        {
            PlayerPrefs.SetInt("day", PlayerPrefs.GetInt("day") + 1);
            PlayerPrefs.SetFloat("speedBat", PlayerPrefs.GetFloat("speedBat") + PlayerPrefs.GetFloat("upTrainBat"));
            PlayerPrefs.SetFloat("condition", PlayerPrefs.GetFloat("condition") - 0.2f);
            conditionEnter();
            setDay();
            TrainSetup();
            trainApp();
            setIznosValue(4);
        }
    }
    public void bttnTrainKmplSoft()
    {
        if (checkByCondition(0.05f) && checkByIznos() && checkByTrainer())
        {
            PlayerPrefs.SetInt("day", PlayerPrefs.GetInt("day") + 1);
            PlayerPrefs.SetFloat("speedBat", PlayerPrefs.GetFloat("speedBat") + PlayerPrefs.GetFloat("upTrainBat")/4/4);
            PlayerPrefs.SetFloat("speedSpina", PlayerPrefs.GetFloat("speedSpina") + PlayerPrefs.GetFloat("upTrainSpina")/4/4);
            PlayerPrefs.SetFloat("speedBrass", PlayerPrefs.GetFloat("speedBrass") + PlayerPrefs.GetFloat("upTrainBrass")/4/4);
            PlayerPrefs.SetFloat("speedKrowl", PlayerPrefs.GetFloat("speedKrowl") + PlayerPrefs.GetFloat("upTrainKrowl")/4/4);
            PlayerPrefs.SetFloat("condition", PlayerPrefs.GetFloat("condition") - 0.05f);
            conditionEnter();
            setDay();
            TrainSetup();
            trainApp();
            setIznosValue(1);
        }
    }
    public void bttnTrainKmplMedium()
    {
        if (checkByCondition(0.1f) && checkByIznos() && checkByTrainer())
        {
            PlayerPrefs.SetInt("day", PlayerPrefs.GetInt("day") + 1);
            PlayerPrefs.SetFloat("speedBat", PlayerPrefs.GetFloat("speedBat") + PlayerPrefs.GetFloat("upTrainBat") / 4 / 2);
            PlayerPrefs.SetFloat("speedSpina", PlayerPrefs.GetFloat("speedSpina") + PlayerPrefs.GetFloat("upTrainSpina") / 4 / 2);
            PlayerPrefs.SetFloat("speedBrass", PlayerPrefs.GetFloat("speedBrass") + PlayerPrefs.GetFloat("upTrainBrass") / 4 / 2);
            PlayerPrefs.SetFloat("speedKrowl", PlayerPrefs.GetFloat("speedKrowl") + PlayerPrefs.GetFloat("upTrainKrowl") / 4 / 2);
            PlayerPrefs.SetFloat("condition", PlayerPrefs.GetFloat("condition") - 0.1f);
            conditionEnter();
            setDay();
            TrainSetup();
            trainApp();
            setIznosValue(2);
        }
    }
    public void bttnTrainKmplHard()
    {
        if (checkByCondition(0.2f) && checkByIznos() && checkByTrainer())
        {
            PlayerPrefs.SetInt("day", PlayerPrefs.GetInt("day") + 1);
            PlayerPrefs.SetFloat("speedBat", PlayerPrefs.GetFloat("speedBat") + PlayerPrefs.GetFloat("upTrainBat") / 4);
            PlayerPrefs.SetFloat("speedSpina", PlayerPrefs.GetFloat("speedSpina") + PlayerPrefs.GetFloat("upTrainSpina") / 4);
            PlayerPrefs.SetFloat("speedBrass", PlayerPrefs.GetFloat("speedBrass") + PlayerPrefs.GetFloat("upTrainBrass") / 4);
            PlayerPrefs.SetFloat("speedKrowl", PlayerPrefs.GetFloat("speedKrowl") + PlayerPrefs.GetFloat("upTrainKrowl") / 4);
            PlayerPrefs.SetFloat("condition", PlayerPrefs.GetFloat("condition") - 0.2f);
            conditionEnter();
            setDay();
            TrainSetup();
            trainApp();
            setIznosValue(4);
        }
    }
    public void bttnTrainRest()
    {
        if(PlayerPrefs.GetFloat("condition") < 1)
        {
            PlayerPrefs.SetFloat("condition", PlayerPrefs.GetFloat("condition") + (float)(Random.Range(30, 50)) / 100);
            if (PlayerPrefs.GetFloat("condition") > 1)
            {
                if (PlayerPrefs.GetString("language") == "rus") notif("Запас сил полон", greenClr);
                else notif("Stamina full", greenClr);
                PlayerPrefs.SetFloat("condition", 1);
            }
            PlayerPrefs.SetInt("day", PlayerPrefs.GetInt("day") + 1);
            conditionEnter();
            TrainSetup();
            setDay();
            trainApp();
        }
    }

    public void setDay()
    {
        if ((PlayerPrefs.GetInt("day") >= 30) && (PlayerPrefs.GetInt("day") < 100) && (PlayerPrefs.GetInt("rank") != 2))
        {
            PlayerPrefs.SetInt("rank", 2);
            notif("Открыт бассейн 2 - го уровня!", greenClr);
            lockImage_1.SetActive(false);
        }
        if ((PlayerPrefs.GetInt("day") >= 100) && (PlayerPrefs.GetInt("day") < 300) && (PlayerPrefs.GetInt("rank") != 3))
        {
            PlayerPrefs.SetInt("rank", 3);
            notif("Открыт бассейн 3 - го уровня!", greenClr);
            lockImage_2.SetActive(false);
        }
        if ((PlayerPrefs.GetInt("day") >= 300) && (PlayerPrefs.GetInt("rank") != 4))
        {
            PlayerPrefs.SetInt("rank", 4);
            notif("Открыт бассейн 4 - го уровня!", greenClr);
            lockImage_3.SetActive(false);
        }
        if((PlayerPrefs.GetInt("day") % 20 == 0) && PlayerPrefs.GetInt("day") < 130)
        {
            foreach(GameObject trunk in trunksHeh)
            {
                trunk.GetComponent<meltingScript>().Start();
            }
            foreach (GameObject glass in glassHeh)
            {
                glass.GetComponent<glassScript>().Start();
            }
            notif("Открыта новая экипировка!", greenClr);
        }
        dayNumber = PlayerPrefs.GetInt("day") % 7;
        if (PlayerPrefs.GetString("language") == "rus")
        {
            switch (dayNumber)
            {
                case 1:
                    day_text.text = "Пн";
                    break;
                case 2:
                    day_text.text = "Вт";
                    break;
                case 3:
                    day_text.text = "Ср";
                    break;
                case 4:
                    day_text.text = "Чт";
                    break;
                case 5:
                    day_text.text = "Пт";
                    break;
                case 6:
                    day_text.text = "Сб";
                    break;
                case 0:
                    day_text.text = "Вс";
                    break;
            }
        }
        if (PlayerPrefs.GetString("language") == "eng")
        {
            switch (dayNumber)
            {
                case 1:
                    day_text.text = "Mo";
                    break;
                case 2:
                    day_text.text = "Tu";
                    break;
                case 3:
                    day_text.text = "We";
                    break;
                case 4:
                    day_text.text = "Th";
                    break;
                case 5:
                    day_text.text = "Fr";
                    break;
                case 6:
                    day_text.text = "Sa";
                    break;
                case 0:
                    day_text.text = "Su";
                    break;
            }
        }
        /*
        else
        {
            switch (dayNumber)
            {
                case 1:
                    day_text.text = "Mo";
                    break;
                case 2:
                    day_text.text = "Tu";
                    break;
                case 3:
                    day_text.text = "We";
                    break;
                case 4:
                    day_text.text = "Th";
                    break;
                case 5:
                    day_text.text = "Fr";
                    break;
                case 6:
                    day_text.text = "Sa";
                    break;
                case 0:
                    day_text.text = "Su";
                    break;
            }

        }
        */
        setDayFor();
        PlayerPrefs.SetInt("dayVill", PlayerPrefs.GetInt("dayVill") - 1);
        PlayerPrefs.SetInt("dayObl", PlayerPrefs.GetInt("dayObl") - 1);
    }

    public void clickOnNo()
    {
        panelSwimRef.SetActive(false);
        PlayerPrefs.SetInt("city", 0);
    }
    public void clickOnNoObl()
    {
        panelSorev_1.SetActive(false);
        PlayerPrefs.SetInt("city2", 0);
    }
    public void clickOnNoOb2()
    {
        panelSorev_2.SetActive(false);
        PlayerPrefs.SetInt("city3", 0);
    }
    public void clickOnNoOb3()
    {
        panelSorev_3.SetActive(false);
        PlayerPrefs.SetInt("city4", 0);
    }

    public void clickOnYes()
    {
        panelSwimRef.SetActive(false);
        if(tggl1.isOn == true || tggl2.isOn == true || tggl3.isOn == true || tggl4.isOn == true)
        {
            PlayerPrefs.SetInt("city", 1);
        }
        else PlayerPrefs.SetInt("city", 0);
        if (tggl1.isOn == true)
        {
            PlayerPrefs.SetInt("okdist1", 1);
        }
        else PlayerPrefs.SetInt("okdist1", 0);
        if (tggl2.isOn == true)
        {
            PlayerPrefs.SetInt("okdist2", 1);
        }
        else PlayerPrefs.SetInt("okdist2", 0);
        if (tggl3.isOn == true)
        {
            PlayerPrefs.SetInt("okdist3", 1);
        }
        else PlayerPrefs.SetInt("okdist3", 0);
        if (tggl4.isOn == true)
        {
            PlayerPrefs.SetInt("okdist4", 1);
        }
        else PlayerPrefs.SetInt("okdist4", 0);
        setDayFor();
    }
    public void clickOnYesObl1()
    {
        if (tgglSorevObl_1 == true || tgglSorevObl_2 == true || tgglSorevObl_3 == true || tgglSorevObl_4 == true || tgglSorevObl_5 == true || tgglSorevObl_6 == true)
        {
            PlayerPrefs.SetInt("city2", 1);
        }
        panelSorev_1.SetActive(false);
        if (tgglSorevObl_1.isOn == true)
        {
            PlayerPrefs.SetInt("okdist1Obl", 1);
        }
        else PlayerPrefs.SetInt("okdist1Obl", 0);
        if (tgglSorevObl_2.isOn == true)
        {
            PlayerPrefs.SetInt("okdist2Obl", 1);
        }
        else PlayerPrefs.SetInt("okdist2Obl", 0);
        if (tgglSorevObl_3.isOn == true)
        {
            PlayerPrefs.SetInt("okdist3Obl", 1);
        }
        else PlayerPrefs.SetInt("okdist3Obl", 0);
        if (tgglSorevObl_4.isOn == true)
        {
            PlayerPrefs.SetInt("okdist4Obl", 1);
        }
        else PlayerPrefs.SetInt("okdist4Obl", 0);
        if (tgglSorevObl_5.isOn == true)
        {
            PlayerPrefs.SetInt("okdist5Obl", 1);
        }
        else PlayerPrefs.SetInt("okdist5Obl", 0);
        if (tgglSorevObl_6.isOn == true)
        {
            PlayerPrefs.SetInt("okdist6Obl", 1);
        }
        else PlayerPrefs.SetInt("okdist6Obl", 0);
        setDayFor();
    }
    public void clickOnYesObl2()
    {
        panelSorev_2.SetActive(false);
        PlayerPrefs.SetInt("city3", 1);
        if (tgglSorevVill_1.isOn == true)
        {
            PlayerPrefs.SetInt("okdist1Vill", 1);
        }
        else PlayerPrefs.SetInt("okdist1Vill", 0);
        if (tgglSorevVill_2.isOn == true)
        {
            PlayerPrefs.SetInt("okdist2Vill", 1);
        }
        else PlayerPrefs.SetInt("okdist2Vill", 0);
        if (tgglSorevVill_3.isOn == true)
        {
            PlayerPrefs.SetInt("okdist3Vill", 1);
        }
        else PlayerPrefs.SetInt("okdist3Vill", 0);
        if (tgglSorevVill_4.isOn == true)
        {
            PlayerPrefs.SetInt("okdist4Vill", 1);
        }
        else PlayerPrefs.SetInt("okdist4Vill", 0);
        setDayFor();
    }

    bool checkByDist(string distRand)
    {
        foreach (string distance in distArray)
        {
            if (distRand == distance) return false;
        }
        return true;
    }

    string randomSwimDist()
    {
        if (PlayerPrefs.GetInt("day") <= 70)
        {
            dist = Random.Range(1, 3);
        }
        if (PlayerPrefs.GetInt("day") <= 30)
        {
            dist = 1;
        }
        else
        {
            dist = Random.Range(1, 5);
        }
        Debug.Log(dist);
        switch (dist)
        {
            case 1:
                distStr = "50м";
                break;
            case 2:
                distStr = "100м";
                break;
            case 3:
                distStr = "200м";
                break;
            case 4:
                distStr = "400м";
                break;
        }
        still = Random.Range(1, 5);
        Debug.Log(still);
        switch (still)
        {
            case 1:
                if (PlayerPrefs.GetString("language") == "rus") stillStr = "Брасс";
                else stillStr = "Breaststroke";
                break;
            case 2:
                if (PlayerPrefs.GetString("language") == "rus") stillStr = "Кроль";
                else stillStr = "Crawl";
                break;
            case 3:
                if (PlayerPrefs.GetString("language") == "rus") stillStr = "Спина";
                else stillStr = "Backstroke";
                break;
            case 4:
                if (PlayerPrefs.GetString("language") == "rus") stillStr = "Баттерфляй";
                else stillStr = "Butterfly";
                break;
        }
        distanceOriginal = distStr + " " + stillStr;
        while (checkByDist(distanceOriginal) == false)
        {
            if (PlayerPrefs.GetInt("day") <= 70)
            {
                dist = Random.Range(1, 3);
            }
            if (PlayerPrefs.GetInt("day") <= 30)
            {
                dist = 1;
            }
            else
            {
                dist = Random.Range(1, 5);
            }
            dist = Random.Range(1, 5);
            switch (dist)
            {
                case 1:
                    distStr = "50м";
                    break;
                case 2:
                    distStr = "100м";
                    break;
                case 3:
                    distStr = "200м";
                    break;
                case 4:
                    distStr = "400м";
                    break;
            }
            still = Random.Range(1, 5);
            Debug.Log(still);
            switch (still)
            {
                case 1:
                    if (PlayerPrefs.GetString("language") == "rus") stillStr = "Брасс";
                    else stillStr = "Breaststroke";
                    break;
                case 2:
                    if (PlayerPrefs.GetString("language") == "rus") stillStr = "Кроль";
                    else stillStr = "Crawl";
                    break;
                case 3:
                    if (PlayerPrefs.GetString("language") == "rus") stillStr = "Спина";
                    else stillStr = "Backstroke";
                    break;
                case 4:
                    if (PlayerPrefs.GetString("language") == "rus") stillStr = "Баттерфляй";
                    else stillStr = "Butterfly";
                    break;
            }
            distanceOriginal = distStr + " " + stillStr;
        }
        distArray[numRand] = distanceOriginal;
        numRand++;
        Debug.Log(distArray[numRand]);
        return distanceOriginal;
    }

    public void onClickVK()
    {
        Application.OpenURL("https://vk.com/swimshit");
    }
    public void onClickTelegram()
    {
        Application.OpenURL("https://t.me/swimshit");
    }
    public void onClickInsta()
    {
        Application.OpenURL("https://www.instagram.com/swimexclamation/");
    }

    bool checkByTrainer()
    {
        if (PlayerPrefs.GetInt("trainerCount") > 0)
        {
            return true;
        }
        else
        {
            if (PlayerPrefs.GetString("language") == "rus") notif("У вас закончился абонемент!", redClr);
            else notif("You're out of season tickets!", redClr);
            return false;
        }
    }

    void clickTrainer1_m(int trainer, float krowl, float bat, float spina, float brass)
    {
        trainerStatic = PlayerPrefs.GetInt("trainer");
        PlayerPrefs.SetInt("trainer", trainer);
        PlayerPrefs.SetFloat("upTrainKrowl", krowl);
        PlayerPrefs.SetFloat("upTrainBat", bat);
        PlayerPrefs.SetFloat("upTrainSpina", spina);
        PlayerPrefs.SetFloat("upTrainBrass", brass);
    }
    
    public void clickByAbonement()
    {
        if (PlayerPrefs.GetInt("money") >= trainerPrice)
        {
            ticks[trainerStatic - 1].SetActive(false);
            ticks[PlayerPrefs.GetInt("trainer") - 1].SetActive(true);
            PlayerPrefs.SetInt("money", PlayerPrefs.GetInt("money") - trainerPrice);
            coinsSet();
            PlayerPrefs.SetInt("trainerCount", dayCooount);
            trainPanel.SetActive(false);
            return;
        }
        else if ((PlayerPrefs.GetInt("trainer") == 1) || (PlayerPrefs.GetInt("trainer") == 2))
        {
            notif("Недостаточно средств!", redClr);
            panelLoose.SetActive(true);
        }
        else notif("Недостаточно средств!", redClr);
    }

    public void ClickTrainer1(int dayCount)
    {
        if (PlayerPrefs.GetInt("trainerCount") == 0)
        {
            trainName.text = "Гаврилов Николай";
            trainDescription.text = "Тут должно быть описание";
            trainPanel.SetActive(true);
            trainImg.sprite = trainersArray[0];
            trainAbone.text = "Абонемент на " + dayCount + " дней";
            if (dayCount == 14) trainPrice.text = "100";
            if (dayCount == 30) trainPrice.text = "180";
            dayCooount = dayCount;
            if (dayCount == 14) trainerPrice = 100;
            if (dayCount == 30) trainerPrice = 180;
            clickTrainer1_m(1, 0.02f, 0.02f, 0.01f, 0.01f);
        }
        else notif("Абонемент ещё не закончился", redClr);
    }

    public void ClickTrainer2(int dayCount)
    {
        if (PlayerPrefs.GetInt("trainerCount") == 0)
        {
            trainName.text = "Наталья Исаева";
            trainDescription.text = "Тут должно быть описание";
            trainPanel.SetActive(true);
            trainImg.sprite = trainersArray[1];
            trainAbone.text = "Абонемент на " + dayCount + " дней";
            if (dayCount == 14) trainPrice.text = "100";
            if (dayCount == 30) trainPrice.text = "180";
            dayCooount = dayCount;
            if (dayCount == 14) trainerPrice = 100;
            if (dayCount == 30) trainerPrice = 180;
            clickTrainer1_m(2, 0.01f, 0.01f, 0.02f, 0.02f);
        }
        else notif("Абонемент ещё не закончился", redClr);
    }
    public void ClickTrainer3(int dayCount)
    {
        if (PlayerPrefs.GetInt("trainerCount") == 0)
        {
            trainName.text = "Арина Савельева";
            trainDescription.text = "Тут должно быть описание";
            trainPanel.SetActive(true);
            trainImg.sprite = trainersArray[2];
            trainAbone.text = "Абонемент на " + dayCount + " дней";
            if (dayCount == 14) trainPrice.text = "250";
            if (dayCount == 30) trainPrice.text = "450";
            dayCooount = dayCount;
            if (dayCount == 14) trainerPrice = 250;
            if (dayCount == 30) trainerPrice = 450;
            clickTrainer1_m(3, 0.03f, 0.03f, 0.04f, 0.02f);
        }
        else notif("Абонемент ещё не закончился", redClr);
    }
    public void ClickTrainer4(int dayCount)
    {
        if (PlayerPrefs.GetInt("trainerCount") == 0)
        {
            trainName.text = "Игорь Берёзовский";
            trainDescription.text = "Тут должно быть описание";
            trainPanel.SetActive(true);
            trainImg.sprite = trainersArray[3];
            trainAbone.text = "Абонемент на " + dayCount + " дней";
            if (dayCount == 14) trainPrice.text = "250";
            if (dayCount == 30) trainPrice.text = "450";
            dayCooount = dayCount;
            if (dayCount == 14) trainerPrice = 250;
            if (dayCount == 30) trainerPrice = 450;
            clickTrainer1_m(4, 0.03f, 0.04f, 0.03f, 0.02f);
        }
        else notif("Абонемент ещё не закончился", redClr);
    }

    public void ClickTrainer5(int dayCount)
    {
        if (PlayerPrefs.GetInt("trainerCount") == 0)
        {
            trainName.text = "Артём Гужев";
            trainDescription.text = "Тут должно быть описание";
            trainPanel.SetActive(true);
            trainImg.sprite = trainersArray[4];
            trainAbone.text = "Абонемент на " + dayCount + " дней";
            if (dayCount == 14) trainPrice.text = "500";
            if (dayCount == 30) trainPrice.text = "900";
            dayCooount = dayCount;
            if (dayCount == 14) trainerPrice = 500;
            if (dayCount == 30) trainerPrice = 900;
            clickTrainer1_m(5, 0.05f, 0.06f, 0.09f, 0.05f);
        }
        else notif("Абонемент ещё не закончился", redClr);
    }

    public void ClickTrainer6(int dayCount)
    {
        if (PlayerPrefs.GetInt("trainerCount") == 0)
        {
            trainName.text = "Павел Бурутенко";
            trainDescription.text = "Тут должно быть описание";
            trainPanel.SetActive(true);
            trainImg.sprite = trainersArray[5];
            trainAbone.text = "Абонемент на " + dayCount + " дней";
            if (dayCount == 14) trainPrice.text = "1000";
            if (dayCount == 30) trainPrice.text = "1800";
            dayCooount = dayCount;
            if (dayCount == 14) trainerPrice = 500;
            if (dayCount == 30) trainerPrice = 900;
            clickTrainer1_m(6, 0.1f, 0.1f, 0.03f, 0.1f);
        }
        else notif("Абонемент ещё не закончился", redClr);
    }

    public void clickOnRateYes()
    {
        panelRate.SetActive(false);
        PlayerPrefs.SetInt("Rate", 1);
        Application.OpenURL("https://play.google.com/store/apps/details?id=com.OrangeParadise.Swim");
    }

    public void clickOnRateNo()
    {
        PlayerPrefs.SetInt("Rate", 1);
        panelRate.SetActive(false);
    }

    void TrainSetup()
    {
        setIznos();
        ineend_1.text = (PlayerPrefs.GetInt("day") + "/30");
        ineend_2.text = (PlayerPrefs.GetInt("day") + "/100");
        ineend_3.text = (PlayerPrefs.GetInt("day") + "/300");
        if ((PlayerPrefs.GetInt("day") == 100) && PlayerPrefs.GetInt("Rate") != 1 && PlayerPrefs.GetInt("Rate") != 0)
        {
            panelRate.SetActive(true);
        }
        if (PlayerPrefs.GetInt("kvest") < kvestQuestions.Length)
        {
            randKvest = Random.Range(1, 5);
            if (randKvest == 2 && (PlayerPrefs.GetInt("day") % 7 != 0) && PlayerPrefs.GetInt("day") % 7 != 6)
            {
                panelKvest.SetActive(true);
                txtQuestion.text = kvestQuestions[PlayerPrefs.GetInt("kvest")];
                bttnQ1.text = kvestQuestionsbttn1[PlayerPrefs.GetInt("kvest")];
                bttnQ2.text = kvestQuestionsbttn2[PlayerPrefs.GetInt("kvest")];
                bttnQ3.text = kvestQuestionsbttn3[PlayerPrefs.GetInt("kvest")];
                PlayerPrefs.SetInt("kvest", PlayerPrefs.GetInt("kvest") + 1);
            }
        }
    }
    public void onCLickSwimmingPool()
    {
        swimmingPoolBttn.image.color = new Vector4(0.13f, 0.19f, 0.25f, 1);
        trainersBttn.image.color = new Vector4(0.18f, 0.25f, 0.32f, 1);
        swimmingPool.SetActive(true);
        trainers.SetActive(false);
    }
    public void onCLickTrainers()
    {
        swimmingPoolBttn.image.color = new Vector4(0.18f, 0.25f, 0.32f, 1);
        trainersBttn.image.color = new Vector4(0.13f, 0.19f, 0.25f, 1);
        swimmingPool.SetActive(false);
        trainers.SetActive(true);
    }
    public void bttn1()
    {
        switch (PlayerPrefs.GetInt("kvest"))
        {
            case 0:
                PlayerPrefs.SetInt("money", PlayerPrefs.GetInt("money") + 50);
                coinsSet();
                break;
            case 1:
                //PlayerPrefs.SetInt("money", PlayerPrefs.GetInt("money") + 500);
                break;
            case 2:
                PlayerPrefs.SetInt("money", PlayerPrefs.GetInt("money") + 25);
                break;
            case 3:
                PlayerPrefs.SetInt("money", PlayerPrefs.GetInt("money") + 100);
                break;
            case 4:
                PlayerPrefs.SetInt("money", PlayerPrefs.GetInt("money") + 50);
                break;
            case 5:
                Appodeal.show(Appodeal.INTERSTITIAL);
                break;
        }
        panelKvest.SetActive(false);
    }
    public void bttn2()
    {
        switch (PlayerPrefs.GetInt("kvest"))
        {
            case 0:
                break;
            case 1:
                break;
            case 2:
                break;
            case 3:
                break;
            case 4:
                PlayerPrefs.SetInt("money", PlayerPrefs.GetInt("money") + 100);
                break;
            case 5:
                Appodeal.show(Appodeal.INTERSTITIAL);
                break;
        }
        panelKvest.SetActive(false);
    }
    public void bttn3()
    {
        switch (PlayerPrefs.GetInt("kvest"))
        {
            case 0:
                PlayerPrefs.SetInt("money", PlayerPrefs.GetInt("money") + 25);
                coinsSet();
                break;
            case 1:
                PlayerPrefs.SetInt("money", PlayerPrefs.GetInt("money") + 50);
                break;
            case 2:
                PlayerPrefs.SetInt("money", PlayerPrefs.GetInt("money") + 50);
                break;
            case 3:
                PlayerPrefs.SetInt("money", PlayerPrefs.GetInt("money") + 50);
                break;
            case 4:
                PlayerPrefs.SetInt("money", PlayerPrefs.GetInt("money") + 50);
                break;
            case 5:
                Appodeal.show(Appodeal.REWARDED_VIDEO);
                break;
        }
        panelKvest.SetActive(false);
    }
    public void OnClickBttnM()
    {
        imgM.color = new Vector4(0.19f, 0.66f, 0.87f, 1);
        imgW.color = new Vector4(0.11f, 0.74f, 0.61f, 1);
        PlayerPrefs.SetInt("pol", 0);
        Woomen.SetActive(false);
        Men.SetActive(true);
        plavkiMen.SetActive(true);
        plavkiWoomen.SetActive(false);
    }
    public void OnClickBttnW()
    {
        imgW.color = new Vector4(1, 0.27f, 0.95f, 1);
        imgM.color = new Vector4(0.11f, 0.74f, 0.61f, 1);
        PlayerPrefs.SetInt("pol", 1);
        Woomen.SetActive(true);
        Men.SetActive(false);
        plavkiMen.SetActive(false);
        plavkiWoomen.SetActive(true);
    }
    public void OnClickBack()
    {
        buyPanel.SetActive(false);
    }

    public void onCLickSwimmingPoolBttn(int SwPoolBttn)
    {
        onCLickTrainers();
        if (SwPoolBttn == 1)
        {
            PlayerPrefs.SetInt("SwimmingPool", 1);
            checkSwimmingPool_1.SetActive(true);
            checkSwimmingPool_2.SetActive(false);
            checkSwimmingPool_3.SetActive(false);
            checkSwimmingPool_4.SetActive(false);
        }
        if ((SwPoolBttn == 2) && (PlayerPrefs.GetInt("rank") >= 2))
        {
            PlayerPrefs.SetInt("SwimmingPool", 2);
            checkSwimmingPool_1.SetActive(false);
            checkSwimmingPool_2.SetActive(true);
            checkSwimmingPool_3.SetActive(false);
            checkSwimmingPool_4.SetActive(false);
        }
        if ((SwPoolBttn == 3) && (PlayerPrefs.GetInt("rank") >= 3))
        {
            PlayerPrefs.SetInt("SwimmingPool", 3);
            checkSwimmingPool_1.SetActive(false);
            checkSwimmingPool_2.SetActive(false);
            checkSwimmingPool_3.SetActive(true);
            checkSwimmingPool_4.SetActive(false);
        }
        if ((SwPoolBttn == 4) && (PlayerPrefs.GetInt("rank") >= 4))
        {
            PlayerPrefs.SetInt("SwimmingPool", 4);
            checkSwimmingPool_1.SetActive(false);
            checkSwimmingPool_2.SetActive(false);
            checkSwimmingPool_3.SetActive(false);
            checkSwimmingPool_4.SetActive(true);
        }
    }
    public void notif(string text, Color clrNotif)
    {
        colorNotification.color = clrNotif;
        notif_Text.text = text;
        notifAnimator.SetTrigger("notif");
    }
    public void onClickADS()
    {
        if (Appodeal.isLoaded(Appodeal.REWARDED_VIDEO))
        {
            Appodeal.show(Appodeal.REWARDED_VIDEO);
            //PlayerPrefs.SetInt("diamonds", PlayerPrefs.GetInt("diamonds") + Random.Range(1, 5));
            PlayerPrefs.SetInt("money", PlayerPrefs.GetInt("money") + 100);
            coinsSet();
        }
    }
    public void clickOnRussianL()
    {
        PlayerPrefs.SetString("language", "rus");
        setLang();
    }
    public void clickOnEnglishL()
    {
        PlayerPrefs.SetString("language", "eng");
        setLang();
    }
    public void clickOnCode()
    {
        panelInfoCoders.SetActive(true);
    }
    public void clickOnCodeExit()
    {
        panelInfoCoders.SetActive(false);
    }
    public void clickOnNextRoom()
    {
        if(roomNumber != (roomNum.Length - 1))
        {
            roomNumBuy[roomNumber + 1].SetActive(true);
            roomNumBuy[roomNumber].SetActive(false);
            roomNumber += 1;
        }
    }
    public void clickOnPreviousRoom()
    {
        if (roomNumber != PlayerPrefs.GetInt("roomNum"))
        {
            if((roomNumber - 1) != PlayerPrefs.GetInt("roomNum"))
            {
                roomNumBuy[roomNumber - 1].SetActive(true);
                roomNumBuy[roomNumber].SetActive(false);
                roomNumber -= 1;
            }
            else
            {
                roomNum[PlayerPrefs.GetInt("roomNum")].SetActive(true);
                roomNumBuy[roomNumber].SetActive(false);
                roomNumber -= 1;
            }
        }
    }
    public void onClickBttnBuyRoom1()
    {
        if (PlayerPrefs.GetInt("money") >= 10000)
        {
            PlayerPrefs.SetInt("money", PlayerPrefs.GetInt("money") - 10000);
            roomNumBuy[1].SetActive(false);
            roomNum[1].SetActive(true);
            PlayerPrefs.SetInt("roomNum", 1);
            coinsSet();
        }
    }
    public void onClickBttnBuyRoom2()
    {
        if (PlayerPrefs.GetInt("money") >= 50000)
        {
            PlayerPrefs.SetInt("money", PlayerPrefs.GetInt("money") - 50000);
            roomNumBuy[2].SetActive(false);
            roomNum[2].SetActive(true);
            PlayerPrefs.SetInt("roomNum", 2);
            coinsSet();
        }
    }
    public void onClickBttnBuyRoom3()
    {
        if (PlayerPrefs.GetInt("money") >= 100000)
        {
            PlayerPrefs.SetInt("money", PlayerPrefs.GetInt("money") - 100000);
            roomNumBuy[3].SetActive(false);
            roomNum[3].SetActive(true);
            PlayerPrefs.SetInt("roomNum", 3);
            coinsSet();
        }
    }
    public void onClickEnterBonus()
    {
        switch (bonusField.text)
        {
            case "GOLD_1000":
                PlayerPrefs.SetInt("money", PlayerPrefs.GetInt("money") + 10000);
                break;
            case "GOLD_10000":
                PlayerPrefs.SetInt("money", PlayerPrefs.GetInt("money") + 100000);
                break;
            case "GOLD_100000":
                PlayerPrefs.SetInt("money", PlayerPrefs.GetInt("money") + 1000000);
                break;
            case "DIAMONDS_1":
                PlayerPrefs.SetInt("diamonds", PlayerPrefs.GetInt("diamonds") + 1);
                diamodsTxt.text = PlayerPrefs.GetInt("diamonds").ToString();
                break;
            case "DIAMONDS_10":
                PlayerPrefs.SetInt("diamonds", PlayerPrefs.GetInt("diamonds") + 10);
                diamodsTxt.text = PlayerPrefs.GetInt("diamonds").ToString();
                break;
        }
        coinsSet();
    }
    public void clickOnSave()
    {
        panelWhat.SetActive(true);
    }
    public void clickOnLoad()
    {
        panelWhat2.SetActive(true);
    }
    public void clickOnSaveYes()
    {
        PlayerPrefs.SetInt("roomNumSave", PlayerPrefs.GetInt("roomNumSave"));
        PlayerPrefs.SetString("languageSave", PlayerPrefs.GetString("language"));
        PlayerPrefs.SetInt("SwimmingPoolSave", PlayerPrefs.GetInt("SwimmingPool"));
        PlayerPrefs.SetInt("studySave", PlayerPrefs.GetInt("Study"));
        PlayerPrefs.SetInt("kvestSave", PlayerPrefs.GetInt("kvest"));
        PlayerPrefs.SetInt("vibrateSave", PlayerPrefs.GetInt("vibrate"));
        PlayerPrefs.SetInt("trainerSave", PlayerPrefs.GetInt("trainer"));
        PlayerPrefs.SetFloat("upTrainKrowlSave", PlayerPrefs.GetFloat("upTrainKrowl"));
        PlayerPrefs.SetFloat("upTrainBatSave", PlayerPrefs.GetFloat("upTrainBat"));
        PlayerPrefs.SetFloat("upTrainSpinaSave", PlayerPrefs.GetFloat("upTrainSpina"));
        PlayerPrefs.SetFloat("upTrainBrassSave", PlayerPrefs.GetFloat("upTrainBrass"));
        PlayerPrefs.SetInt("moneySave", PlayerPrefs.GetInt("money"));
        PlayerPrefs.SetInt("daySave", PlayerPrefs.GetInt("day"));
        PlayerPrefs.SetFloat("speedKrowlSave", PlayerPrefs.GetFloat("speedKrowl"));
        PlayerPrefs.SetFloat("speedBatSave", PlayerPrefs.GetFloat("speedBat"));
        PlayerPrefs.SetFloat("speedBrassSave", PlayerPrefs.GetFloat("speedBrass"));
        PlayerPrefs.SetFloat("speedSpinaSave", PlayerPrefs.GetFloat("speedSpina"));
        PlayerPrefs.SetInt("diamondsSave", PlayerPrefs.GetInt("daimonds"));
        PlayerPrefs.SetInt("rankSave", PlayerPrefs.GetInt("rank"));
        PlayerPrefs.SetInt("SaveDay", PlayerPrefs.GetInt("day"));
        day_save.text = PlayerPrefs.GetInt("SaveDay").ToString() + " День";
        PlayerPrefs.SetInt("okdist4Save", PlayerPrefs.GetInt("okdist4"));
        PlayerPrefs.SetInt("okdist3Save", PlayerPrefs.GetInt("okdist3"));
        PlayerPrefs.SetInt("okdist2Save", PlayerPrefs.GetInt("okdist2"));
        PlayerPrefs.SetInt("okdist1Save", PlayerPrefs.GetInt("okdist1"));
        PlayerPrefs.SetInt(("polSave"), PlayerPrefs.GetInt("pol"));
        PlayerPrefs.SetInt("coinsSave", PlayerPrefs.GetInt("coins"));
        PlayerPrefs.SetInt("swimDist1Save", PlayerPrefs.GetInt("swimDist1"));
        PlayerPrefs.SetInt("swimStill1Save", PlayerPrefs.GetInt("swimDistStill1"));
        PlayerPrefs.SetInt("swimDist2Save", PlayerPrefs.GetInt("swimDist2"));
        PlayerPrefs.SetInt("swimStill2Save", PlayerPrefs.GetInt("swimDistStill2"));
        PlayerPrefs.SetInt("swimDist3Save", PlayerPrefs.GetInt("swimDist3"));
        PlayerPrefs.SetInt("swimStill3Save", PlayerPrefs.GetInt("swimDistStill3"));
        PlayerPrefs.SetInt("swimDist4Save", PlayerPrefs.GetInt("swimDist4"));
        PlayerPrefs.SetInt("swimStill4Save", PlayerPrefs.GetInt("swimDistStill4"));
        PlayerPrefs.SetInt("dayVillSave", PlayerPrefs.GetInt("dayVill"));
        PlayerPrefs.SetInt("dayOblSave", PlayerPrefs.GetInt("dayObl"));
        PlayerPrefs.SetFloat("conditionSave", PlayerPrefs.GetFloat("condition"));
        PlayerPrefs.SetFloat("colorPlavkiRSave", PlayerPrefs.GetFloat("colorPlavkiR"));
        PlayerPrefs.SetFloat("colorPlavkiGSave", PlayerPrefs.GetFloat("colorPlavkiG"));
        PlayerPrefs.SetFloat("colorPlavkiBSave", PlayerPrefs.GetFloat("colorPlavkiB"));
        PlayerPrefs.SetFloat("colorPlavkiASave", PlayerPrefs.GetFloat("colorPlavkiA"));
        PlayerPrefs.SetInt("numMeltingsSave", PlayerPrefs.GetInt("numMeltings"));
        PlayerPrefs.SetFloat("colorShapochkaRSave", PlayerPrefs.GetFloat("colorShapochkaR"));
        PlayerPrefs.SetFloat("colorShapochkaGSave", PlayerPrefs.GetFloat("colorShapochkaG"));
        PlayerPrefs.SetFloat("colorShapochkaBSave", PlayerPrefs.GetFloat("colorShapochkaB"));
        PlayerPrefs.SetFloat("colorShapochkaASave", PlayerPrefs.GetFloat("colorShapochkaA"));
        PlayerPrefs.SetInt("numShapochkaSave", PlayerPrefs.GetInt("numShapochka"));
        panelWhat.SetActive(false);
    }
    public void clickOnSaveNo()
    {
        panelWhat.SetActive(false);
    }
    public void clickOnLoadYes()
    {
        panelWhat2.SetActive(false);
        PlayerPrefs.SetInt("roomNum", PlayerPrefs.GetInt("roomNumSaveSave"));
        PlayerPrefs.SetString("language", PlayerPrefs.GetString("languageSave"));
        PlayerPrefs.SetInt("SwimmingPool", PlayerPrefs.GetInt("SwimmingPoolSave"));
        PlayerPrefs.SetInt("study", PlayerPrefs.GetInt("StudySave"));
        PlayerPrefs.SetInt("kvest", PlayerPrefs.GetInt("kvestSave"));
        PlayerPrefs.SetInt("vibrate", PlayerPrefs.GetInt("vibrateSave"));
        PlayerPrefs.SetInt("trainer", PlayerPrefs.GetInt("trainerSave"));
        PlayerPrefs.SetFloat("upTrainKrowl", PlayerPrefs.GetFloat("upTrainKrowlSave"));
        PlayerPrefs.SetFloat("upTrainBat", PlayerPrefs.GetFloat("upTrainBatSave"));
        PlayerPrefs.SetFloat("upTrainSpina", PlayerPrefs.GetFloat("upTrainSpinaSave"));
        PlayerPrefs.SetFloat("upTrainBrass", PlayerPrefs.GetFloat("upTrainBrassSave"));
        PlayerPrefs.SetInt("money", PlayerPrefs.GetInt("moneySave"));
        PlayerPrefs.SetInt("day", PlayerPrefs.GetInt("daySave"));
        PlayerPrefs.SetFloat("speedKrowl", PlayerPrefs.GetFloat("speedKrowlSave"));
        PlayerPrefs.SetFloat("speedBat", PlayerPrefs.GetFloat("speedBatSave"));
        PlayerPrefs.SetFloat("speedBrass", PlayerPrefs.GetFloat("speedBrassSave"));
        PlayerPrefs.SetFloat("speedSpina", PlayerPrefs.GetFloat("speedSpinaSave"));
        PlayerPrefs.SetInt("diamonds", PlayerPrefs.GetInt("daimondsSave"));
        PlayerPrefs.SetInt("rank", PlayerPrefs.GetInt("rankSave"));
        PlayerPrefs.SetInt("okdist4", PlayerPrefs.GetInt("okdist4Save"));
        PlayerPrefs.SetInt("okdist3", PlayerPrefs.GetInt("okdist3Save"));
        PlayerPrefs.SetInt("okdist2", PlayerPrefs.GetInt("okdist2Save"));
        PlayerPrefs.SetInt("okdist1", PlayerPrefs.GetInt("okdist1Save"));
        PlayerPrefs.SetInt(("pol"), PlayerPrefs.GetInt("polSave"));
        PlayerPrefs.SetInt("coins", PlayerPrefs.GetInt("coinsSave"));
        PlayerPrefs.SetInt("swimDist1", PlayerPrefs.GetInt("swimDist1Save"));
        PlayerPrefs.SetInt("swimStill1", PlayerPrefs.GetInt("swimDistStill1Save"));
        PlayerPrefs.SetInt("swimDist2", PlayerPrefs.GetInt("swimDist2Save"));
        PlayerPrefs.SetInt("swimStill2", PlayerPrefs.GetInt("swimDistStill2Save"));
        PlayerPrefs.SetInt("swimDis3", PlayerPrefs.GetInt("swimDist3Save"));
        PlayerPrefs.SetInt("swimStill3", PlayerPrefs.GetInt("swimDistStill3Save"));
        PlayerPrefs.SetInt("swimDist4", PlayerPrefs.GetInt("swimDist4Save"));
        PlayerPrefs.SetInt("swimStill4", PlayerPrefs.GetInt("swimDistStill4Save"));
        PlayerPrefs.SetInt("dayVill", PlayerPrefs.GetInt("dayVillSave"));
        PlayerPrefs.SetInt("dayObl", PlayerPrefs.GetInt("dayOblSave"));
        PlayerPrefs.SetFloat("condition", PlayerPrefs.GetFloat("conditionSave"));
        PlayerPrefs.SetFloat("colorPlavkiR", PlayerPrefs.GetFloat("colorPlavkiRSave"));
        PlayerPrefs.SetFloat("colorPlavkiG", PlayerPrefs.GetFloat("colorPlavkiGSave"));
        PlayerPrefs.SetFloat("colorPlavkiB", PlayerPrefs.GetFloat("colorPlavkiBSave"));
        PlayerPrefs.SetFloat("colorPlavkiA", PlayerPrefs.GetFloat("colorPlavkiASave"));
        PlayerPrefs.SetInt("numMeltings", PlayerPrefs.GetInt("numMeltingsSave"));
        PlayerPrefs.SetFloat("colorShapochkaR", PlayerPrefs.GetFloat("colorShapochkaRSave"));
        PlayerPrefs.SetFloat("colorShapochkaG", PlayerPrefs.GetFloat("colorShapochkaGSave"));
        PlayerPrefs.SetFloat("colorShapochkaB", PlayerPrefs.GetFloat("colorShapochkaBSave"));
        PlayerPrefs.SetFloat("colorShapochkaA", PlayerPrefs.GetFloat("colorShapochkaASave"));
        PlayerPrefs.SetInt("numShapochka", PlayerPrefs.GetInt("numShapochkaSave"));
        SceneManager.LoadScene(0);
    }
    public void clickOnLoadNo()
    {
        panelWhat2.SetActive(false);
    }
    void trainApp()
    {
        if ((PlayerPrefs.GetInt("day") % 80 == 0) && (PlayerPrefs.GetInt("city3") != 1))
        {
            txtSorevVill_1.text = randomSwimDist();
            PlayerPrefs.SetInt("swimDistVill1", dist);
            PlayerPrefs.SetInt("swimStillVill1", still);
            txtSorevVill_2.text = randomSwimDist();
            PlayerPrefs.SetInt("swimDistVill2", dist);
            PlayerPrefs.SetInt("swimStillVill2", still);
            txtSorevVill_3.text = randomSwimDist();
            PlayerPrefs.SetInt("swimDistVill3", dist);
            PlayerPrefs.SetInt("swimStillVill3", still);
            txtSorevVill_4.text = randomSwimDist();
            PlayerPrefs.SetInt("swimDistVill4", dist);
            PlayerPrefs.SetInt("swimStillVill4", still);
            PlayerPrefs.SetInt("dayVill", 50);
            tgglSorevVill_1.isOn = false;
            tgglSorevVill_2.isOn = false;
            tgglSorevVill_3.isOn = false;
            tgglSorevVill_4.isOn = false;
            panelSorev_2.SetActive(true);
        }
        if ((PlayerPrefs.GetInt("day") % 30 == 0) && (PlayerPrefs.GetInt("city2") != 1))
        {
            txtSorevObl_1.text = randomSwimDist();
            PlayerPrefs.SetInt("swimDistObl1", dist);
            PlayerPrefs.SetInt("swimStillObl1", still);
            txtSorevObl_2.text = randomSwimDist();
            PlayerPrefs.SetInt("swimDistObl2", dist);
            PlayerPrefs.SetInt("swimStillObl2", still);
            txtSorevObl_3.text = randomSwimDist();
            PlayerPrefs.SetInt("swimDistObl3", dist);
            PlayerPrefs.SetInt("swimStillObl3", still);
            txtSorevObl_4.text = randomSwimDist();
            PlayerPrefs.SetInt("swimDistObl4", dist);
            PlayerPrefs.SetInt("swimStillObl4", still);
            txtSorevObl_5.text = randomSwimDist();
            PlayerPrefs.SetInt("swimDistObl5", dist);
            PlayerPrefs.SetInt("swimStillObl5", still);
            txtSorevObl_6.text = randomSwimDist();
            PlayerPrefs.SetInt("swimDistObl6", dist);
            PlayerPrefs.SetInt("swimStillObl6", still);
            PlayerPrefs.SetInt("dayObl", 20);
            tgglSorevObl_1.isOn = false;
            tgglSorevObl_2.isOn = false;
            tgglSorevObl_3.isOn = false;
            tgglSorevObl_4.isOn = false;
            tgglSorevObl_5.isOn = false;
            tgglSorevObl_6.isOn = false;
            panelSorev_1.SetActive(true);
        }
        if ((PlayerPrefs.GetInt("day") % 7 == 4) && (PlayerPrefs.GetInt("city") != 1))
        {
            numRand = 0;
            still = 0;
            txtstill1.text = randomSwimDist();
            PlayerPrefs.SetInt("swimDist1", dist);
            PlayerPrefs.SetInt("swimStill1", still);
            txtstill2.text = randomSwimDist();
            PlayerPrefs.SetInt("swimDist2", dist);
            PlayerPrefs.SetInt("swimStill2", still);
            txtstill3.text = randomSwimDist();
            PlayerPrefs.SetInt("swimDist3", dist);
            PlayerPrefs.SetInt("swimStill3", still);
            txtstill4.text = randomSwimDist();
            PlayerPrefs.SetInt("swimDist4", dist);
            PlayerPrefs.SetInt("swimStill4", still);
            tggl1.isOn = false;
            tggl2.isOn = false;
            tggl3.isOn = false;
            tggl4.isOn = false;
            panelSwimRef.SetActive(true);
        }
        if (PlayerPrefs.GetInt("day") % 7 == 0)
        {
            if (PlayerPrefs.GetInt("city") == 1)
            {
                if (PlayerPrefs.GetInt("NoAds") != 1)
                {
                    Appodeal.show(Appodeal.INTERSTITIAL);
                }
                PlayerPrefs.SetInt("city", 0);
                SceneManager.LoadScene(1);
            }
        }
        if (PlayerPrefs.GetInt("dayVill") <= 0)
        {
            if (PlayerPrefs.GetInt("city3") == 1)
            {
                if (PlayerPrefs.GetInt("NoAds") != 1)
                {
                    Appodeal.show(Appodeal.INTERSTITIAL);
                }
                PlayerPrefs.SetInt("city3", 0);
                SceneManager.LoadScene(3);
            }
        }
        if (PlayerPrefs.GetInt("dayObl") <= 0)
        {
            if (PlayerPrefs.GetInt("city2") == 1)
            {
                if (PlayerPrefs.GetInt("NoAds") != 1)
                {
                    Appodeal.show(Appodeal.INTERSTITIAL);
                }
                PlayerPrefs.SetInt("city2", 0);
                SceneManager.LoadScene(2);
            }
        }
    }
    public IEnumerator blockWavee()
    {
        blockWave.SetActive(true);
        yield return new WaitForSeconds(1.31f);
        blockWave.SetActive(false);
    }
    void conditionEnter()
    {
        if (PlayerPrefs.GetString("language") == "rus")
        {
            wavesTxt.text = "День " + PlayerPrefs.GetInt("day");
        }
        else
        {
            wavesTxt.text = "Day " + PlayerPrefs.GetInt("day");
        }
        StartCoroutine("blockWavee");
        wavesAnim.SetTrigger("waves");
        conditionFloat = PlayerPrefs.GetFloat("condition");
        if(scrollCondition.fillAmount < conditionFloat)
        {
            StartCoroutine(conditionCorutinePlus());
        }
        if (scrollCondition.fillAmount > conditionFloat)
        {
            StartCoroutine(conditionCorutineMinus());
        }
    }
    IEnumerator conditionCorutinePlus()
    {
        while (scrollCondition.fillAmount < conditionFloat)
        {
            yield return new WaitForSeconds(0.025f);
            scrollCondition.fillAmount += 0.01f;
            scrollCondition.color = Color.HSVToRGB(scrollCondition.fillAmount / 2.14f, 0.91f, 1);
        }
    }
    IEnumerator conditionCorutineMinus()
    {
        while (scrollCondition.fillAmount > conditionFloat)
        {
            yield return new WaitForSeconds(0.025f);
            scrollCondition.fillAmount -= 0.01f;
            scrollCondition.color = Color.HSVToRGB(scrollCondition.fillAmount / 2.14f, 0.91f, 1);
        }
    }
    IEnumerator coinsUp()
    {
        while (debugCoinsNum < coinsNum)
        {
            yield return new WaitForSeconds(0.001f);
            debugCoinsNum += coinsDifference;
            debugMoney.text = debugCoinsNum.ToString();
        }
        debugCoinsNum = coinsNum;
        debugMoney.text = debugCoinsNum.ToString();
    }
    IEnumerator coinsDown()
    {
        while (debugCoinsNum > coinsNum)
        {
            yield return new WaitForSeconds(0.001f);
            debugCoinsNum -= coinsDifference;
            debugMoney.text = debugCoinsNum.ToString();
        }
        debugCoinsNum = coinsNum;
        debugMoney.text = debugCoinsNum.ToString();
    }
    public void coinsSet()
    {
        diamodsTxt.text = PlayerPrefs.GetInt("diamonds").ToString();
        coinsNum = PlayerPrefs.GetInt("money");
        coinsDifference = coinsNum - debugCoinsNum;
        coinsDifference = Mathf.Abs(coinsDifference);
        coinsDifference = coinsDifference / 50;
        if (coinsDifference < 1) coinsDifference = 1;
        if (debugCoinsNum < coinsNum) StartCoroutine(coinsUp());
        if (debugCoinsNum > coinsNum) StartCoroutine(coinsDown());
    }
    public void clickOnBuy()
    {
        if (PlayerPrefs.GetInt("money") >= costMelting)
        {
            if(shOrCop == 1)
            {
                clrSliderGO.SetActive(false);
                PlayerPrefs.SetFloat("colorPlavkiR", colorMelting.r);
                PlayerPrefs.SetFloat("colorPlavkiG", colorMelting.g);
                PlayerPrefs.SetFloat("colorPlavkiB", colorMelting.b);
                PlayerPrefs.SetFloat("colorPlavkiA", colorMelting.a);
                colorMeltingofficial = new Color(PlayerPrefs.GetFloat("colorPlavkiR"), PlayerPrefs.GetFloat("colorPlavkiG"), PlayerPrefs.GetFloat("colorPlavkiB"), PlayerPrefs.GetFloat("colorPlavkiA"));
                PlayerPrefs.SetInt("money", PlayerPrefs.GetInt("money") - costMelting);
                PlayerPrefs.SetInt("numMeltings", numberMelting);
                PlayerPrefs.SetFloat("iznosPlavkiValue", iznos);
                PlayerPrefs.SetFloat("iznosPlavki", 1);
                setIznos();
                coinsSet();
                panelBuy.SetActive(false);
                setColor();
            }
            if(shOrCop == 2)
            {
                clrSliderGO.SetActive(false);
                PlayerPrefs.SetFloat("colorShapochkaR", colorShapochka.r);
                PlayerPrefs.SetFloat("colorShapochkaG", colorShapochka.g);
                PlayerPrefs.SetFloat("colorShapochkaB", colorShapochka.b);
                PlayerPrefs.SetFloat("colorShapochkaA", colorShapochka.a);
                colorShapochkaofficial = new Color(PlayerPrefs.GetFloat("colorShapochkaR"), PlayerPrefs.GetFloat("colorShapochkaG"), PlayerPrefs.GetFloat("colorShapochkaB"), PlayerPrefs.GetFloat("colorShapochkaA"));
                PlayerPrefs.SetInt("money", PlayerPrefs.GetInt("money") - costMelting);
                PlayerPrefs.SetInt("numShapochka", numberShapochka);
                PlayerPrefs.SetFloat("iznosShapochkaValue", iznos);
                PlayerPrefs.SetFloat("iznosShapochka", 1);
                setIznos();
                panelBuy.SetActive(false);
                coinsSet();
                setColor();
            }
            if(shOrCop == 3)
            {
                clrSliderGO.SetActive(false);
                PlayerPrefs.SetFloat("colorGlassR", glassColor.r);
                PlayerPrefs.SetFloat("colorGlassG", glassColor.g);
                PlayerPrefs.SetFloat("colorGlassB", glassColor.b);
                PlayerPrefs.SetFloat("colorGlassA", glassColor.a);
                colorGlassOfficial = new Color(PlayerPrefs.GetFloat("colorGlassR"), PlayerPrefs.GetFloat("colorGlassG"), PlayerPrefs.GetFloat("colorGlassB"), PlayerPrefs.GetFloat("colorGlassA"));
                PlayerPrefs.SetInt("money", PlayerPrefs.GetInt("money") - costMelting);
                PlayerPrefs.SetInt("numGlass", glassNumber);
                PlayerPrefs.SetFloat("iznosGlassValue", iznos);
                PlayerPrefs.SetFloat("iznosGlass", 1);
                setIznos();
                coinsSet();
                panelBuy.SetActive(false);
                setColor();
            }
        }
        /*
        if (PlayerPrefs.GetInt("NoAds") != 1)
        {
            Appodeal.show(Appodeal.INTERSTITIAL);
        }
        */
    }
    public void clickOnBack()
    {
        clrSliderGO.SetActive(false);
        panelBuy.SetActive(false);
    }
    public void setColor()
    {
        switch (numberMelting)
        {
            case 1:
                plavkiColorW.color = colorMeltingofficial;
                plavkiColor.color = colorMeltingofficial;
                plavkiColorW.sprite = melting_Woomen;
                plavkiColor.sprite = melting_Men;
                break;
            case 2:
                plavkiColorW.color = colorMeltingofficial;
                plavkiColor.color = colorMeltingofficial;
                plavkiColorW.sprite =  melting_Woomen;
                plavkiColor.sprite = melting_Men;
                break;
            case 3:
                plavkiColorW.color = colorMeltingofficial;
                plavkiColor.color = colorMeltingofficial;
                plavkiColorW.sprite = melting_Woomen;
                plavkiColor.sprite = melting_Men;
                break;
            case 4:
                plavkiColorW.color = colorMeltingofficial;
                plavkiColor.color = colorMeltingofficial;
                plavkiColorW.sprite = melting_1W;
                plavkiColor.sprite = melting_1M;
                break;
            case 5:
                plavkiColorW.color = colorMeltingofficial;
                plavkiColor.color = colorMeltingofficial;
                plavkiColorW.sprite = melting_2W;
                plavkiColor.sprite = melting_2M;
                break;
            case 6:
                plavkiColorW.color = colorMeltingofficial;
                plavkiColor.color = colorMeltingofficial;
                plavkiColorW.sprite = melting_3W;
                plavkiColor.sprite = melting_3M;
                break;
            case 7:
                plavkiColorW.color = colorMeltingofficial;
                plavkiColor.color = colorMeltingofficial;
                plavkiColorW.sprite = melting_4W;
                plavkiColor.sprite = melting_4M;
                break;
            case 8:
                plavkiColorW.color = colorMeltingofficial;
                plavkiColor.color = colorMeltingofficial;
                plavkiColorW.sprite = melting_5W;
                plavkiColor.sprite = melting_5M;
                break;
        }
        switch (numberShapochka)
        {
            case 1:
                setColorShap(Shapocka);
                shapochkaColor.sprite = Shapocka;
                break;
            case 2:
                setColorShap(Shapocka);
                shapochkaColor.color = colorShapochkaofficial;
                shapochkaColor.sprite = Shapocka;
                break;
            case 3:
                setColorShap(Shapocka);
                shapochkaColor.color = colorShapochkaofficial;
                shapochkaColor.sprite = Shapocka;
                break;
            case 4:
                setColorShap(Shapochka_1M);
                shapochkaColor.color = colorShapochkaofficial;
                shapochkaColor.sprite = Shapochka_1M;
                break;
            case 5:
                setColorShap(Shapochka_2M);
                shapochkaColor.color = colorShapochkaofficial;
                shapochkaColor.sprite = Shapochka_2M;
                break;
            case 6:
                setColorShap(Shapochka_3M);
                shapochkaColor.color = colorShapochkaofficial;
                shapochkaColor.sprite = Shapochka_3M;
                break;
            case 7:
                setColorShap(Shapochka_4M);
                shapochkaColor.color = colorShapochkaofficial;
                shapochkaColor.sprite = Shapochka_4M;
                break;
            case 8:
                setColorShap(Shapochka_5M);
                shapochkaColor.color = colorShapochkaofficial;
                shapochkaColor.sprite = Shapochka_5M;
                break;
        }
        foreach (Image imgGlasses in glassesImage)
        {
            imgGlasses.color = colorGlassOfficial;
        }
        if(PlayerPrefs.GetInt("pol") == 0)
        {
            iznosPlavkiColor.color = plavkiColor.color;
            iznosPlavkiColor.sprite = plavkiColor.sprite;
        }
        else
        {
            iznosPlavkiColor.color = plavkiColor.color;
            iznosPlavkiColor.sprite = plavkiColorW.sprite;
        }
    }

    public void setColorShap(Sprite myShap)
    {
        shapochkaTrain_1.color = colorShapochkaofficial;
        shapochkaTrain_2.color = colorShapochkaofficial;
        shapochkaTrain_3.color = colorShapochkaofficial;
        shapochkaTrain_4.color = colorShapochkaofficial;
        shapochkaTrain_5.color = colorShapochkaofficial;
        shapochkaTrain_6.color = colorShapochkaofficial;
        shapochkaTrain_7.color = colorShapochkaofficial;
        shapochkaTrain_8.color = colorShapochkaofficial;
        shapochkaTrain_9.color = colorShapochkaofficial;
        shapochkaTrain_10.color = colorShapochkaofficial;
        shapochkaTrain_1.sprite = myShap;
        shapochkaTrain_2.sprite = myShap;
        shapochkaTrain_3.sprite = myShap;
        shapochkaTrain_4.sprite = myShap;
        shapochkaTrain_5.sprite = myShap;
        shapochkaTrain_6.sprite = myShap;
        shapochkaTrain_7.sprite = myShap;
        shapochkaTrain_8.sprite = myShap;
        shapochkaTrain_9.sprite = myShap;
        shapochkaTrain_10.sprite = myShap;
    }
    IEnumerator snowGenerator()
    {
        while (tgglAnim.isOn)
        {
            if(snowCount < 40)
            {
                Instantiate(snowPrefab, new Vector3(0, 0, 0), Quaternion.identity, panelSnow.transform);
                snowCount += 1;
                yield return new WaitForSeconds(0.5f);
            }
            yield return new WaitForSeconds(1);
        }
    }

    public void setAwardsStat()
    {
        countWinCityGold.text = PlayerPrefs.GetInt("countWinGoldCity").ToString();
        countWinCitySilver.text = PlayerPrefs.GetInt("countWinSilverCity").ToString();
        countWinCityBronze.text = PlayerPrefs.GetInt("countWinBronzeCity").ToString();
        countWinOblGold.text = PlayerPrefs.GetInt("countWinGoldObl").ToString();
        countWinOblSilver.text = PlayerPrefs.GetInt("countWinSilverObl").ToString();
        countWinOblBronze.text = PlayerPrefs.GetInt("countWinBronzeObl").ToString();
        countWinVillGold.text = PlayerPrefs.GetInt("countWinGoldVill").ToString();
        countWinVillSilver.text = PlayerPrefs.GetInt("countWinSilverVill").ToString();
        countWinVillBronze.text = PlayerPrefs.GetInt("countWinBronzeVill").ToString();
    }

    public void setIznos()
    {
        iznosPlavki.fillAmount = PlayerPrefs.GetFloat("iznosPlavki");
        iznosGlass.fillAmount = PlayerPrefs.GetFloat("iznosGlass");
        iznosShapochka.fillAmount = PlayerPrefs.GetFloat("iznosShapochka");
        iznosPlavki.color = Color.HSVToRGB(PlayerPrefs.GetFloat("iznosPlavki") / 2.14f, 0.91f, 1);
        iznosGlass.color = Color.HSVToRGB(PlayerPrefs.GetFloat("iznosGlass") / 2.14f, 0.91f, 1);
        iznosShapochka.color = Color.HSVToRGB(PlayerPrefs.GetFloat("iznosShapochka") / 2.14f, 0.91f, 1);
    }

    public void setIznosValue(float dff)
    {
        PlayerPrefs.SetInt("trainerCount", PlayerPrefs.GetInt("trainerCount") - 1);
        trainCountTxt.text = PlayerPrefs.GetInt("trainerCount").ToString();
        PlayerPrefs.SetFloat("iznosPlavki", PlayerPrefs.GetFloat("iznosPlavki") - PlayerPrefs.GetFloat("iznosPlavkiValue") * dff);
        PlayerPrefs.SetFloat("iznosGlass", PlayerPrefs.GetFloat("iznosGlass") - PlayerPrefs.GetFloat("iznosGlassValue") * dff);
        PlayerPrefs.SetFloat("iznosShapochka", PlayerPrefs.GetFloat("iznosShapochka") - PlayerPrefs.GetFloat("iznosShapochkaValue") * dff);
    }

    public bool checkByIznos()
    {
        if (PlayerPrefs.GetFloat("iznosPlavki") < PlayerPrefs.GetFloat("iznosPlavkiValue") * 4)
        {
            if (PlayerPrefs.GetString("language") == "rus") notif("Купите новые плавки!", redClr);
            else notif("Buy a new bathing suit!", redClr);
            return false;
        }
        if (PlayerPrefs.GetFloat("iznosGlass") < PlayerPrefs.GetFloat("iznosGlassValue") * 4)
        {
            if (PlayerPrefs.GetString("language") == "rus") notif("Купите новые очки!", redClr);
            else notif("Buy new glasses!", redClr);
            return false;
        }
        if (PlayerPrefs.GetFloat("iznosShapochka") < PlayerPrefs.GetFloat("iznosGlassValue") * 4)
        {
            if (PlayerPrefs.GetString("language") == "rus") notif("Купите новую шапочку!", redClr);
            else notif("Buy a new hat!", redClr);
            return false;
        }
        return true;
    }
    public bool checkByCondition(float conditionLevel)
    {
        if(PlayerPrefs.GetFloat("condition") < conditionLevel)
        {
            if (PlayerPrefs.GetString("language") == "rus") notif("Требуется отдых!", orangeClr);
            else notif("We need a vacation!", orangeClr);
            return false;
        }
        else return true;
    }
    void setDayFor()
    {
        if (PlayerPrefs.GetInt("city") == 1)
        {
            if ((7 - (PlayerPrefs.GetInt("day") % 7)) < 4)
            {
                dayFor_1.SetActive(true);
                dayForCity.text = (7 - (PlayerPrefs.GetInt("day") % 7)).ToString();
            }
        }
        else dayFor_1.SetActive(false);
        if (PlayerPrefs.GetInt("city2") == 1)
        {
            dayFor_2.SetActive(true);
            dayForObl.text = PlayerPrefs.GetInt("dayObl").ToString();
        }
        else dayFor_2.SetActive(false);
        if (PlayerPrefs.GetInt("city3") == 1)
        {
            dayFor_3.SetActive(true);
            dayForEurope.text = PlayerPrefs.GetInt("dayVill").ToString();
        }
        else dayFor_3.SetActive(false);
        if (PlayerPrefs.GetInt("city4") == 1)
        {
            dayFor_4.SetActive(true);
            dayForOlimp.text = (7 - (PlayerPrefs.GetInt("day") % 7)).ToString();
        }
        else dayFor_4.SetActive(false);
    }

    public void question()
    {
        questionCount = 0;
        questionGO[questionCount].SetActive(true);
        bttns[questionCount].SendMessage("clickOnHomeBttns");
        bttnQnext.SetActive(true);
    }
    public void questionBttn()
    {
        if (questionCount == 4)
        {
            PlayerPrefs.SetInt("q", 1);
            questionGO[questionCount].SetActive(false);
            bttnQnext.SetActive(false);
        }
        else if (questionCount < 5)
        {
            questionGO[questionCount].SetActive(false);
            questionCount += 1;
            bttns[questionCount].SendMessage("clickOnHomeBttns");
            questionGO[questionCount].SetActive(true);
        }
    }

    public void clickContinueWin()
    {
        panelWin.SetActive(false);
    }
}
