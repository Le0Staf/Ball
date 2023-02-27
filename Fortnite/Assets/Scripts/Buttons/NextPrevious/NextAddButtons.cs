using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextAddButtons : MonoBehaviour
{
    public GameObject Button1;
    public GameObject Button2;
    public GameObject Button3;
    public GameObject nextAddButton;

    void OnMouseDown()
    {
        Button1.SetActive(false);
        Button2.SetActive(false);
        Button3.SetActive(false);
    }

    void OnMouseEnter()
    {
        nextAddButton.transform.localScale = new Vector3(0.275f, 1.1f, 1f);
    }

    void OnMouseExit()
    {
        nextAddButton.transform.localScale = new Vector3(0.25f, 1f, 1f);
    }

}
