using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class meltingScript : MonoBehaviour {

    public int numberShapochka;
    public int shOrPl;
    public int numberMelting;
    public int costMelting;
    public string nameMelting;
    public string descriptionMelting;
    public Color colorMelting;
    public Image Shapochka;
    public Sprite ShapochkaStandart;
    public Sprite ShapochkaStandartAssist;
    public Sprite MeltingW;
    public Sprite MeltingM;
    public Sprite MeltingW_Assist;
    public Sprite MeltingM_Assist;
    public Image clrMeltings;
    public GameObject panelBuy;
    public Image clrMeltingsBuy;
    public Text txtName;
    public Text txtDescription;
    public Text txtCost;
    public Slider clrSlider;
    public GameObject clrSliderGO;
    public GameObject blockOn;
    public bool imOn;
    public float iznos;

    public void Start()
    {
        imOn = false;
        switch (numberMelting)
        {
            case 1:
                if (PlayerPrefs.GetInt("day") >= 0)
                {
                    blockOn.SetActive(false);
                    imOn = true;
                }
                break;
            case 2:
                if (PlayerPrefs.GetInt("day") >= 20)
                {
                    blockOn.SetActive(false);
                    imOn = true;
                }
                break;
            case 3:
                if (PlayerPrefs.GetInt("day") >= 40)
                {
                    blockOn.SetActive(false);
                    imOn = true;
                }
                break;
            case 4:
                if (PlayerPrefs.GetInt("day") >= 60)
                {
                    blockOn.SetActive(false);
                    imOn = true;
                }
                break;
            case 5:
                if (PlayerPrefs.GetInt("day") >= 80)
                {
                    blockOn.SetActive(false);
                    imOn = true;
                }
                break;
            case 6:
                if (PlayerPrefs.GetInt("day") >= 100)
                {
                    blockOn.SetActive(false);
                    imOn = true;
                }
                break;
            case 7:
                if (PlayerPrefs.GetInt("day") >= 120)
                {
                    blockOn.SetActive(false);
                    imOn = true;
                }
                break;
        }
        switch (numberShapochka)
        {
            case 1:
                if (PlayerPrefs.GetInt("day") >= 0)
                {
                    blockOn.SetActive(false);
                    imOn = true;
                }
                break;
            case 2:
                if (PlayerPrefs.GetInt("day") >= 20)
                {
                    blockOn.SetActive(false);
                    imOn = true;
                }
                break;
            case 3:
                if (PlayerPrefs.GetInt("day") >= 40)
                {
                    blockOn.SetActive(false);
                    imOn = true;
                }
                break;
            case 4:
                if (PlayerPrefs.GetInt("day") >= 60)
                {
                    blockOn.SetActive(false);
                    imOn = true;
                }
                break;
            case 5:
                if (PlayerPrefs.GetInt("day") >= 80)
                {
                    blockOn.SetActive(false);
                    imOn = true;
                }
                break;
            case 6:
                if (PlayerPrefs.GetInt("day") >= 100)
                {
                    blockOn.SetActive(false);
                    imOn = true;
                }
                break;
            case 7:
                if (PlayerPrefs.GetInt("day") >= 120)
                {
                    blockOn.SetActive(false);
                    imOn = true;
                }
                break;
        }
        if (shOrPl == 1)
        {
            if (PlayerPrefs.GetInt("pol") == 1)
            {
                    clrMeltings.sprite = MeltingW;
            }
            else clrMeltings.sprite = MeltingM;
            clrMeltings.color = colorMelting;
        }
        if (shOrPl == 2)
        {
            clrMeltings.sprite = ShapochkaStandart;
            clrMeltings.color = colorMelting;
        }
    }

    public void clickShapochka()
    {
        if (imOn)
        {
            clrMeltingsBuy.color = colorMelting;
            clrMeltingsBuy.sprite = ShapochkaStandart;
            if (numberMelting == 3)
            {
                clrSliderGO.SetActive(true);
                clrMeltingsBuy.sprite = ShapochkaStandartAssist;
                clrMeltingsBuy.color = Color.HSVToRGB(clrSlider.value, 0.6f, 1);
            }
            Main.numberShapochka = numberShapochka;
            Main.costMelting = costMelting;
            Main.colorShapochka = colorMelting;
            Main.shOrCop = shOrPl;
            Main.iznos = iznos;
            txtName.text = nameMelting;
            txtDescription.text = descriptionMelting;
            txtCost.text = costMelting.ToString();
            panelBuy.SetActive(true);
        }
    }

    public void clickMelting()
    {
        if (imOn)
        {
            clrMeltingsBuy.color = colorMelting;
            if (PlayerPrefs.GetInt("pol") == 1)
            {
                clrMeltingsBuy.sprite = MeltingW;
                if (numberMelting == 3)
                {
                    clrSliderGO.SetActive(true);
                    clrMeltingsBuy.sprite = MeltingW_Assist;
                    clrMeltingsBuy.color = Color.HSVToRGB(clrSlider.value, 0.6f, 1);
                }
            }
            else
            {
                clrMeltingsBuy.sprite = MeltingM;
                if (numberMelting == 3)
                {
                    clrSliderGO.SetActive(true);
                    clrMeltingsBuy.sprite = MeltingM_Assist;
                    clrMeltingsBuy.color = Color.HSVToRGB(clrSlider.value, 0.6f, 1);
                }
            }
            Main.numberMelting = numberMelting;
            Main.costMelting = costMelting;
            Main.colorMelting = clrMeltingsBuy.color;
            Main.shOrCop = shOrPl;
            Main.iznos = iznos;
            txtName.text = nameMelting;
            txtDescription.text = descriptionMelting;
            txtCost.text = costMelting.ToString();
            panelBuy.SetActive(true);
        }
    }
    public void onValueClrChanged()
    {
        clrMeltingsBuy.color = Color.HSVToRGB(clrSlider.value, 0.6f, 1);
        Main.colorMelting = Color.HSVToRGB(clrSlider.value, 0.6f, 1);
        Main.colorShapochka = Color.HSVToRGB(clrSlider.value, 0.6f, 1);
        Main.glassColor = Color.HSVToRGB(clrSlider.value, 0.6f, 1);
    }
}
