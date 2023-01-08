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
    double toShowK;
    double toShowM;

    void OnMouseDown()
    {
        Balls = Balls + i;

        //What To Show

            //Show score
        toShowK = Balls / 1000;
        toShowK = Math.Round(toShowK, 1);
        toShowM = Balls / 1000000;
        toShowM = Math.Round(toShowM, 1);

            //Show per click


            //Show per second

        //Spawn Number that shows when click
        Instantiate(ClickShowClick);
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
        toShowK = Balls / 1000;
        toShowK = Math.Round(toShowK, 1);
        toShowM = Balls / 1000000;
        toShowM = Math.Round(toShowM, 1);

        perSecondEnabled = true;
        yield return new WaitForSeconds(1f);
        Balls = Balls + p;
        perSecondEnabled = false;
    }
}
