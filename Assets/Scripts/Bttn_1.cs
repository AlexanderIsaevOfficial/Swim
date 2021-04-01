using UnityEngine;
using System.Collections;
using System;
using UnityEngine.UI;

public class Bttn_1 : MonoBehaviour {

    public int myNumber;
    public GameObject myPanel;
    public GameObject Another2;
    public GameObject Another3;
    public GameObject Another4;
    public GameObject Another5;
    public Image myImage;
    public Image anyImage2;
    public Image anyImage3;
    public Image anyImage4;
    public Image anyImage5;

    public void clickOnHomeBttns()
    {
        myPanel.SetActive(true);
        Another2.SetActive(false);
        Another3.SetActive(false);
        Another4.SetActive(false);
        Another5.SetActive(false);
        myImage.color = new Vector4(0.13f, 0.19f, 0.25f, 1);
        anyImage2.color = new Vector4(0.968f, 0.984f, 1, 1);
        anyImage3.color = new Vector4(0.968f, 0.984f, 1, 1);
        anyImage4.color = new Vector4(0.968f, 0.984f, 1, 1);
        anyImage5.color = new Vector4(0.968f, 0.984f, 1, 1);
    }
}
