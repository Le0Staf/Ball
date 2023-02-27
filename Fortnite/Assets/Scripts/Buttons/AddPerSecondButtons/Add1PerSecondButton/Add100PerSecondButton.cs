using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class Add100PerSecondButton : MonoBehaviour
{
    public Click click;
    public double add100PerSecondPrice = 5500;
    public SpriteRenderer buyButtonSpriteRenderer;
    public TextMeshProUGUI add100PerSecondPriceText;

    void OnMouseDown()
    {
        if (click.Balls >= add100PerSecondPrice)
        {
            click.p = click.p + 100;
            click.Balls = click.Balls - add100PerSecondPrice;
            add100PerSecondPrice = Math.Round(add100PerSecondPrice * 1.15);
            StartCoroutine(doAnimation());
        }
    }

    IEnumerator doAnimation()
    {
        buyButtonSpriteRenderer.color = new Color32(70, 73, 85, 255);
        yield return new WaitForSeconds(0.1f);
        buyButtonSpriteRenderer.color = new Color32(24, 26, 34, 255);
    }

    void Update()
    {
        add100PerSecondPriceText.text = add100PerSecondPrice.ToString();
        if (click.Balls < add100PerSecondPrice)
        {
            add100PerSecondPriceText.color = new Color32(255, 0, 0, 255);
        }
        else
        {
            add100PerSecondPriceText.color = new Color32(0, 255, 0, 255);
        }
    }
}
