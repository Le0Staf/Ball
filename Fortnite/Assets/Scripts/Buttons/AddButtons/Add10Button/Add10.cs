using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;

public class Add10 : MonoBehaviour
{
    public Click click;
    public double addTenPrice = 250;
    public TextMeshProUGUI addTenPriceText;
    public SpriteRenderer buyButtonSpriteRenderer;

    void OnMouseDown()
    {
        if (click.Balls >= addTenPrice)
        {
            click.i = click.i + 10;
            click.Balls = click.Balls - addTenPrice;
            addTenPrice = Math.Round(addTenPrice * 1.5);
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
        addTenPriceText.text = addTenPrice.ToString();
        if (click.Balls < addTenPrice)
        {
            addTenPriceText.color = new Color32(255, 0, 0, 255);
        }
        else
        {
            addTenPriceText.color = new Color32(0, 255, 0, 255);
        }
    }
}
