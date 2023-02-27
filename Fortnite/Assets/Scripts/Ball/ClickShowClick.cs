using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ClickShowClick : MonoBehaviour
{
    public GameObject clickNumber;
    public TextMesh clickNumberText;

    void OnMouseDown()
    {
        clickNumberText.text = "+" + GameObject.Find("Ball").GetComponent<Click>().i.ToString();
        Instantiate(clickNumber);
        clickNumber.transform.localPosition = new Vector3(Random.Range(-4f, 4f), Random.Range(-4f, 4f), 0);
    }
}
