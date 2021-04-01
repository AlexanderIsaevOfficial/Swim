using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class snowflare : MonoBehaviour {

    public GameObject snow;
    public Image snowImg;
    public Sprite[] snowSprites;
    public Transform myPosition;
    float speedSnow;

    float pingPong;

	void Start () {
        snowImg.sprite = snowSprites[Random.Range(0, snowSprites.Length)];
        myPosition.localPosition = new Vector3(Random.Range(-310, 310), 700, 0);
        myPosition.localScale = new Vector3(0.6f, 0.6f, myPosition.localScale.z);
        speedSnow = Random.Range(10, 50);
        StartCoroutine(pingPongGenerator());
    }
	
	void Update ()
    {
        myPosition.localPosition = new Vector3(myPosition.localPosition.x + pingPong, myPosition.localPosition.y - speedSnow * Time.deltaTime, myPosition.localPosition.z);
        myPosition.localScale = new Vector3(myPosition.localScale.x - 0.01f * Time.deltaTime, myPosition.localScale.y - 0.01f * Time.deltaTime, myPosition.localScale.z);
        snowImg.color = new Vector4(snowImg.color.r, snowImg.color.g, snowImg.color.b, myPosition.localScale.x);
        if (myPosition.localScale.x <= 0.1)
        {
            Destroy(snow);
            Main.snowCount -= 1;
        }
    }

    IEnumerator pingPongGenerator()
    {
        while (true)
        {
            while (pingPong < 0.5f)
            {
                pingPong += 0.05f;
                yield return new WaitForSeconds(0.1f);
            }
            while (pingPong > -0.5f)
            {
                pingPong -= 0.05f;
                yield return new WaitForSeconds(0.1f);
            }
        }
    }
}
