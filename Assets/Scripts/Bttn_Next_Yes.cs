using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Bttn_Next_Yes : MonoBehaviour {

    public Text txtError;
    public Text langTxtVstuplenie;
    public GameObject panel_Prefs_Set;
    public GameObject panel_Main;
    public Text moneyTxt;
    public GameObject cumAnim;
    public Text name_input;
    public Text secondname_input;
    public Dropdown still_dropRus;
    public Dropdown still_dropEng;
    public Text name_text;
    public GameObject panel1;
    public GameObject panel2;
    public GameObject panel3;
    public GameObject panel4;
    public GameObject panel5;
    public Image settings_bttn;
    public Image home_bttn;
    public Text day_text;
    public Image scrollCondition;
    public GameObject panelEnter;

    void OnMouseDown()
    {
        if(name_input.text != "" && secondname_input.text != "")
        {
            PlayerPrefs.SetInt("q", 0);
            PlayerPrefs.SetInt("sound", 1);
            PlayerPrefs.SetFloat("iznosShapochkaValue", 0.07f);
            PlayerPrefs.SetFloat("iznosGlassValue", 0.06f);
            PlayerPrefs.SetFloat("iznosPlavkiValue", 0.05f);
            PlayerPrefs.SetFloat("iznosPlavki", 1);
            PlayerPrefs.SetFloat("iznosGlass", 1);
            PlayerPrefs.SetFloat("iznosShapochka", 1);
            PlayerPrefs.SetInt("NoAds", 0);
            PlayerPrefs.SetInt("countWinGoldCity", 0);
            PlayerPrefs.SetInt("countWinSilverCity", 0);
            PlayerPrefs.SetInt("countWinBronzeCity", 0);
            PlayerPrefs.SetInt("countWinGoldObl", 0);
            PlayerPrefs.SetInt("countWinSilverObl", 0);
            PlayerPrefs.SetInt("countWinBronzeObl", 0);
            PlayerPrefs.SetInt("countWinGoldVill", 0);
            PlayerPrefs.SetInt("countWinSilverVill", 0);
            PlayerPrefs.SetInt("countWinBronzeVill", 0);
            PlayerPrefs.DeleteKey("raitbool");
            PlayerPrefs.SetInt("snowAnim", 1);
            PlayerPrefs.SetFloat("condition", 1);
            PlayerPrefs.SetInt("roomNum", 0);
            PlayerPrefs.SetInt("SwimmingPool", 0);
            PlayerPrefs.SetInt("study", 1);
            PlayerPrefs.SetInt("kvest", 0);
            PlayerPrefs.SetInt("vibrate", 1);
            PlayerPrefs.SetInt("trainer", 1);
            PlayerPrefs.SetFloat("upTrainKrowl", 0.2f);
            PlayerPrefs.SetFloat("upTrainBat", 0.2f);
            PlayerPrefs.SetFloat("upTrainSpina", 0.2f);
            PlayerPrefs.SetFloat("upTrainBrass", 0.2f);
            PlayerPrefs.SetInt("money", 250);
            PlayerPrefs.SetInt("day", 1);
            PlayerPrefs.SetString("Name", name_input.text);
            PlayerPrefs.SetString("secName", secondname_input.text);
            PlayerPrefs.SetString("firstPlay", "yes");
            PlayerPrefs.SetFloat("speedKrowl", 4.5f);
            PlayerPrefs.SetFloat("speedBat", 4.5f);
            PlayerPrefs.SetFloat("speedBrass", 4.5f);
            PlayerPrefs.SetFloat("speedSpina", 4.5f);
            PlayerPrefs.SetInt("diamonds", 10);
            PlayerPrefs.SetInt("rank", 0);
            PlayerPrefs.SetInt("SaveDay", 1);
            PlayerPrefs.SetFloat("colorPlavkiR", 1);
            PlayerPrefs.SetFloat("colorPlavkiG", 1);
            PlayerPrefs.SetFloat("colorPlavkiB", 1);
            PlayerPrefs.SetFloat("colorPlavkiA", 1);
            PlayerPrefs.SetFloat("colorShapochkaR", 1);
            PlayerPrefs.SetFloat("colorShapochkaG", 1);
            PlayerPrefs.SetFloat("colorShapochkaB", 1);
            PlayerPrefs.SetFloat("colorShapochkaA", 1);
            PlayerPrefs.SetInt("numShapochka", 1);
            PlayerPrefs.SetInt("numMeltings", 1);
            PlayerPrefs.SetInt("trainerCount", 14);
            moneyTxt.text = PlayerPrefs.GetInt("money").ToString();
            PlayerPrefs.SetInt("Rate", 5);
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
            if (PlayerPrefs.GetString("language") == "rus")
            {
                switch (still_dropRus.value)
                {
                    case 0:
                        PlayerPrefs.SetString("still", "Krowl");
                        break;
                    case 1:
                        PlayerPrefs.SetString("still", "Bat");
                        break;
                    case 2:
                        PlayerPrefs.SetString("still", "Spin");
                        break;
                    case 3:
                        PlayerPrefs.SetString("still", "Brass");
                        break;
                }
            }
            else if (PlayerPrefs.GetString("language") == "eng")
            {
                switch (still_dropEng.value)
                {
                    case 0:
                        PlayerPrefs.SetString("still", "Krowl");
                        break;
                    case 1:
                        PlayerPrefs.SetString("still", "Bat");
                        break;
                    case 2:
                        PlayerPrefs.SetString("still", "Spin");
                        break;
                    case 3:
                        PlayerPrefs.SetString("still", "Brass");
                        break;
                }
            }
            else PlayerPrefs.SetString("still", "Krowl");
            scrollCondition.fillAmount = PlayerPrefs.GetFloat("condition");
            scrollCondition.color = Color.HSVToRGB(PlayerPrefs.GetFloat("condition") / 2.14f, 0.91f, 1);
            if (!cumAnim.GetComponent<Animator>().enabled) cumAnim.GetComponent<Animator>().enabled = true;
            else cumAnim.GetComponent<Animator>().SetTrigger("Ok");
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
            langTxtVstuplenie.text = PlayerPrefs.GetString("Name") + " " + "живёт в забытом всеми городе и мечтает стать олимпийским чемпионом по плаванию. У тебя есть 250 монет и мечта, пройди этот путь и помоги исполнить её";
            if (PlayerPrefs.GetString("language") == "rus")
            {
                langTxtVstuplenie.text = PlayerPrefs.GetString("Name") + " " + "живёт в забытом всеми городе и мечтает стать олимпийским чемпионом по плаванию. У тебя есть 250 монет и мечта, пройди этот путь и помоги исполнить её";
            }
            if (PlayerPrefs.GetString("language") == "eng")
            {
                langTxtVstuplenie.text = PlayerPrefs.GetString("Name") + " " + "lives in a forgotten town and dreams of becoming an Olympic champion in swimming. Walk the path and help to fulfill the dream";
            }
            name_text.text = (PlayerPrefs.GetString("secName") + " " + PlayerPrefs.GetString("Name"));
            home_bttn.color = new Vector4(0.176f, 0.243f, 0.313f, 1);
            settings_bttn.color = new Vector4(0.968f, 0.984f, 1, 1);
            StartCoroutine(show_panel_main());
            panelEnter.SetActive(true);
        }
        else
        {
            StartCoroutine(errorTxt());
        }
    }

    

    IEnumerator show_panel_main()
    {
        yield return new WaitForSeconds(0.8f);
        panel_Prefs_Set.SetActive(false);
        panel_Main.SetActive(true);
        yield return new WaitForSeconds(0.5f);
    }
    IEnumerator errorTxt()
    {
        if (PlayerPrefs.GetString("language") == "rus")
        {
            txtError.text = "Не все данные введены!";
        }
        if (PlayerPrefs.GetString("language") == "eng")
        {
            txtError.text = "Not all data entered!";
        }
        yield return new WaitForSeconds(5);
        txtError.text = "";
    }

    public void enterNext()
    {
        panelEnter.SetActive(false);
        SceneManager.LoadScene(0);
    }
}
