using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class Click : MonoBehaviour
{
    public int i = 1;
    public double Balls = 0;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI perClickText;
    public TextMeshProUGUI perSecondText;
    public int p = 0;
    bool perSecondEnabled = false;
    public GameObject ClickShowClick;
    public SpriteRenderer ballSpriteRenderer;
    double toShowK;
    double toShowM;

    double toShowKPC;
    double toShowMPC;

    double toShowKCPS;
    double toShowMCPS;

    void OnMouseDown()
    {
        Balls = Balls + i;
        StartCoroutine(doAnimation());
    }

    void Update()
    { 
        if(Balls < 1000) {  
            scoreText.text = Balls.ToString() + "\nBalls";
        }
        else if (Balls >= 1000 && Balls <= 1000000)
        {
            scoreText.text = toShowK.ToString() + "K" + "\nBalls";
        }
        else if (Balls >= 1000000 && Balls <= 1000000000)
        {
            scoreText.text = toShowM.ToString() + "M" + "\nBalls";
        }

        perSecondText.text = p.ToString() + "\nPer Second";
        perClickText.text = i.ToString() + "\nPer CLick";
        if (perSecondEnabled == false)
        {
            StartCoroutine(perSecond());
        }
    }

    IEnumerator perSecond()
    {
        //Show for example 1k instead of 1000
        toShowK = Balls / 1000;
        toShowK = Math.Round(toShowK, 1);
        toShowM = Balls / 1000000;
        toShowM = Math.Round(toShowM, 1);

        //Show per click
        toShowKPC = i / 1000;
        toShowKPC = Math.Round(toShowKPC, 1);
        toShowMPC = i / 1000000;
        toShowMPC = Math.Round(toShowMPC, 1);

        //Show per second
        toShowKCPS = p / 1000;
        toShowKCPS = Math.Round(toShowKCPS, 1);
        toShowMCPS = p / 1000000;
        toShowMCPS = Math.Round(toShowMCPS, 1);

        perSecondEnabled = true;
        yield return new WaitForSeconds(1f);
        Balls = Balls + p;
        perSecondEnabled = false;
    }

    IEnumerator doAnimation()
    {
        ballSpriteRenderer.color = new Color32(222, 123, 107, 255);
        transform.localScale = new Vector3(5.2f, 5.2f, 5.2f);
        yield return new WaitForSeconds(0.1f);
        ballSpriteRenderer.color = new Color32(197, 96, 23, 255);
        transform.localScale = new Vector3(5f, 5f, 5f);
    }
}
