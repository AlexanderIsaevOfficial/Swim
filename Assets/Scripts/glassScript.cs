using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class glassScript : MonoBehaviour {

    public Sprite supportSprite;
    public string glassName;
    public string glassDescription;
    public float iznos;
    public int costGlass;
    public Color clrGlass;
    public Sprite spriteGlass;
    private bool imOn;
    public int numberGlass;
    public GameObject blockOn;
    public Image glassSprite;
    public Image glassSpriteBuy;
    public GameObject clrSliderGO;
    public Slider clrSlider;
    public GameObject panelBuy;
    public Text txtName;
    public Text txtDescription;
    public Text txtCost;

    public void Start ()
    {
        imOn = false;
        switch (numberGlass)
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
        glassSprite.sprite = spriteGlass;
        glassSprite.color = clrGlass;
    }

    public void clickGlass()
    {
        if (imOn)
        {
            glassSpriteBuy.sprite = spriteGlass;
            glassSpriteBuy.color = clrGlass;
            if (numberGlass == 3)
            {
                clrSliderGO.SetActive(true);
                glassSpriteBuy.color = Color.HSVToRGB(clrSlider.value, 0.6f, 1);
                glassSpriteBuy.sprite = supportSprite;
            }
            Main.glassNumber = numberGlass;
            Main.costMelting = costGlass;
            Main.glassColor = clrGlass;
            Main.shOrCop = 3;
            Main.iznos = iznos;
            txtName.text = glassName;
            txtDescription.text = glassDescription;
            txtCost.text = costGlass.ToString();
            panelBuy.SetActive(true);
        }
    }
}
