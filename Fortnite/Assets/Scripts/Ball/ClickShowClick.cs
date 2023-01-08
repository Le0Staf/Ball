using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ClickShowClick : MonoBehaviour
{
    public GameObject clickNumber;
    public TextMeshPro clickNumberText;

    void Start()
    {
        clickNumberText.text = "+" + GameObject.Find("Ball").GetComponent<Click>().i.ToString();
        clickNumber.transform.localPosition = new Vector3(Random.Range(-2.5f, 2.5f), Random.Range(-2.5f, 2.5f), 0);
        StartCoroutine(doAnimation());
    }

    IEnumerator doAnimation()
    {
        clickNumberText.color = new Color32(255, 255, 255, 255);
        clickNumber.transform.localPosition += new Vector3(0, 0.1f, 0);
        yield return new WaitForSeconds(0.03f);
        clickNumberText.color = new Color32(255, 255, 255, 220);
        clickNumber.transform.localPosition += new Vector3(0, 0.1f, 0);
        yield return new WaitForSeconds(0.03f);
        clickNumberText.color = new Color32(255, 255, 255, 200);
        clickNumber.transform.localPosition += new Vector3(0, 0.1f, 0);
        yield return new WaitForSeconds(0.03f);
        clickNumberText.color = new Color32(255, 255, 255, 180);
        clickNumber.transform.localPosition += new Vector3(0, 0.1f, 0);
        yield return new WaitForSeconds(0.03f);
        clickNumberText.color = new Color32(255, 255, 255, 160);
        clickNumber.transform.localPosition += new Vector3(0, 0.1f, 0);
        yield return new WaitForSeconds(0.03f);
        clickNumberText.color = new Color32(255, 255, 255, 140);
        clickNumber.transform.localPosition += new Vector3(0, 0.1f, 0);
        yield return new WaitForSeconds(0.03f);
        clickNumberText.color = new Color32(255, 255, 255, 120);
        clickNumber.transform.localPosition += new Vector3(0, 0.1f, 0);
        yield return new WaitForSeconds(0.03f);
        clickNumberText.color = new Color32(255, 255, 255, 100);
        clickNumber.transform.localPosition += new Vector3(0, 0.1f, 0);
        yield return new WaitForSeconds(0.03f);
        clickNumberText.color = new Color32(255, 255, 255, 80);
        clickNumber.transform.localPosition += new Vector3(0, 0.1f, 0);
        yield return new WaitForSeconds(0.03f);
        clickNumberText.color = new Color32(255, 255, 255, 60);
        clickNumber.transform.localPosition += new Vector3(0, 0.1f, 0);
        yield return new WaitForSeconds(0.03f);
        clickNumberText.color = new Color32(255, 255, 255, 40);
        clickNumber.transform.localPosition += new Vector3(0, 0.1f, 0);
        yield return new WaitForSeconds(0.03f);
        clickNumberText.color = new Color32(255, 255, 255, 20);
        clickNumber.transform.localPosition += new Vector3(0, 0.1f, 0);
        yield return new WaitForSeconds(0.03f);
        clickNumberText.color = new Color32(255, 255, 255, 0);
        Destroy(clickNumber);
    }

}
