using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonAnimation : MonoBehaviour
{
    public SpriteRenderer buyButtonSpriteRenderer;

    void OnMouseDown()
    {
        StartCoroutine(doAnimation());
    }

    IEnumerator doAnimation()
    {
        buyButtonSpriteRenderer.color = new Color32(70, 73, 85, 255);
        yield return new WaitForSeconds(0.1f);
        buyButtonSpriteRenderer.color = new Color32(24, 26, 34, 255);
    }
}
