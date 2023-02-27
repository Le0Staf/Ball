using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;

public class Add1 : MonoBehaviour
{
    public Click click;
    public double addOnePrice = 100;
    public TextMeshProUGUI addOnePriceText;
    public SpriteRenderer buyButtonSpriteRenderer;

    void OnMouseDown()
    {
        if (click.Balls >= addOnePrice)
        {
            click.i = click.i + 1;
            click.Balls = click.Balls - addOnePrice;
            addOnePrice = Math.Round(addOnePrice * 1.15);
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
        addOnePriceText.text = addOnePrice.ToString();

        if (click.Balls < addOnePrice)
        {
            addOnePriceText.color = new Color32(255, 0, 0, 255);
        }
        else
        {
            addOnePriceText.color = new Color32(0, 255, 0, 255);
        }
    }
}
