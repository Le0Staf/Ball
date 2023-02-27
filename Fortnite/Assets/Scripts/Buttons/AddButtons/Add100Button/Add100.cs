using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class Add100 : MonoBehaviour
{
    public Click click;
    public double add100Price = 12000;
    public TextMeshProUGUI add100PriceText;
    public SpriteRenderer buyButtonSpriteRenderer;

    void OnMouseDown()
    {
        if (click.Balls >= add100Price)
        {
            click.i = click.i + 100;
            click.Balls = click.Balls - add100Price;
            add100Price = Math.Round(add100Price * 1.15);
            StartCoroutine(doAnimation());
        }
    }

    IEnumerator doAnimation()
    {
        buyButtonSpriteRenderer.color = new Color32(185, 245, 85, 255);
        yield return new WaitForSeconds(0.1f);
        buyButtonSpriteRenderer.color = new Color32(24, 26, 34, 255);
    }

    void Update()
    {
        add100PriceText.text = add100Price.ToString();

        if (click.Balls < add100Price)
        {
            add100PriceText.color = new Color32(255, 0, 0, 255);
        }
        else
        {
            add100PriceText.color = new Color32(0, 255, 0, 255);
        }
    }
}
