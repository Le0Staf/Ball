using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class AddTenPerSecond : MonoBehaviour
{
    public Click click;
    public double addTenPerSecondPrice = 1500;
    public SpriteRenderer buyButtonSpriteRenderer;
    public TextMeshProUGUI addTenPerSecondPriceText;

    void OnMouseDown()
    {
        if (click.Balls >= addTenPerSecondPrice)
        {
            click.p = click.p + 1;
            click.Balls = click.Balls - addTenPerSecondPrice;
            addTenPerSecondPrice = Math.Round(addTenPerSecondPrice * 1.5);
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
        addTenPerSecondPriceText.text = addTenPerSecondPrice.ToString();
        if (click.Balls < addTenPerSecondPrice)
        {
            addTenPerSecondPriceText.color = new Color32(255, 0, 0, 255);
        }
        else
        {
            addTenPerSecondPriceText.color = new Color32(0, 255, 0, 255);
        }
    }
}
