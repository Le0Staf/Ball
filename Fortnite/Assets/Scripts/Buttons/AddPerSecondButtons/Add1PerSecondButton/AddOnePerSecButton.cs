using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class AddOnePerSecButton : MonoBehaviour
{
    public Click click;
    public double addOnePerSecondPrice = 25;
    public SpriteRenderer buyButtonSpriteRenderer;
    public TextMeshProUGUI addOnePerSecondPriceText;

    void OnMouseDown()
    {
        if (click.Balls >= addOnePerSecondPrice)
        {
            click.p = click.p + 1;
            click.Balls = click.Balls - addOnePerSecondPrice;
            addOnePerSecondPrice = Math.Round(addOnePerSecondPrice * 1.5);
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
        addOnePerSecondPriceText.text = addOnePerSecondPrice.ToString();
        if (click.Balls < addOnePerSecondPrice)
        {
            addOnePerSecondPriceText.color = new Color32(255, 0, 0, 255);
        }
        else
        {
            addOnePerSecondPriceText.color = new Color32(0, 255, 0, 255);
        }
    }
}
