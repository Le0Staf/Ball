using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddOneButtonAnimation : MonoBehaviour
{
    public SpriteRenderer ballSpriteRenderer;
    public GameObject ball;

    void OnMouseDown()
    {
        StartCoroutine(doAnimation());
    }

    IEnumerator doAnimation()
    {
        ballSpriteRenderer.color = new Color32(222, 123, 107, 255);
        ball.transform.localScale = new Vector3(5.2f, 5.2f, 5.2f);
        yield return new WaitForSeconds(0.1f);
        ballSpriteRenderer.color = new Color32(197, 96, 23, 255);
        ball.transform.localScale = new Vector3(5f, 5f, 5f);
    }
}
